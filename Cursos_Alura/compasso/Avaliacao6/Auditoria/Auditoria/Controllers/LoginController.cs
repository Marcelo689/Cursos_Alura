using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Auditoria.Controllers
{
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        DbOperacoes<Login> dbOperacoesLogin;
        DbOperacoes<Auditoria> dbOperacoesAuditoria;
        Login login;
        public LoginController()
        {
            dbOperacoesLogin = new DbOperacoes<Login>();
            dbOperacoesAuditoria = new DbOperacoes<Auditoria>();
            
        }

        public bool ConferirLogin()
        {
            SalvarAuditoria("Usuario acessou o sistema pela auditoria");

            var loginresposnse = dbOperacoesLogin.RetornarTudo().Where(l => l.LoginAtual == true);
            if (loginresposnse.Count() == 1)
            {
                login = loginresposnse.First();
                SalvarAuditoria("Usuario Logado com sucesso");
            }

            if (login == null)
            {
                SalvarAuditoria("Usuario acessou sistema sem logar");
                return false;
            }

            return true;
            
        }
        public void SalvarAuditoria(string mensagemEvento)
        {
            if (login == null)
                login = new Login() { Id = 0 };
               dbOperacoesAuditoria.Cadastrar(
               new Auditoria()
               {
                   Evento = mensagemEvento,
                   UsuarioId = login.Id,
                   Data = DateTime.Now
               });
        }
        public void DeslogarTodos()
        {
            var lista = dbOperacoesLogin.RetornarTudo().FindAll(l => l.LoginAtual == true);
            foreach (var item in lista)
            {
                item.LoginAtual = false;
                dbOperacoesLogin.Editar(item);
            }
        }

        [HttpPost]
        [Route("Logar")]
        public ActionResult Logar([FromBody] Login login)
        {
            DeslogarTodos();
            var resposta = dbOperacoesLogin.RetornarTudo().Where(l => l.Usuario == login.Usuario && login.Password == l.Password);

            if (resposta.Count() > 0)
            { 
                login = resposta.First();
                login.LoginAtual = true;
            }
            else
                return NotFound("Login Não encontrado!");
            

            dbOperacoesLogin.Editar(login);
            dbOperacoesAuditoria.Cadastrar(
            new Auditoria()
                {
                    ClienteId = 0,
                    ProdutoId =0,
                    Evento = "Usuario Logou",
                    UsuarioId = login.Id,
                    Data = DateTime.Now
                }
            );
            return Ok();
        }

        [HttpPost]
        [Route("Cadastrar")]
        public ActionResult CadastrarLogin([FromBody] Login login)
        {
            login.LoginAtual = false;
            dbOperacoesLogin.Cadastrar(login);
            SalvarAuditoria("usuario cadastrado");
            return Ok();
        }
        
        [HttpPost]
        [Route("Deslogar")]
        public ActionResult Deslogar()
        {
            if (!ConferirLogin())
            {
                SalvarAuditoria("Alguém falhou ao tentar deslogar");
                return NotFound("Usuario não logado");
            }
            else
                login = dbOperacoesLogin.RetornarTudo().Where(l => l.LoginAtual == true).First();
            login.LoginAtual = false;
            dbOperacoesLogin.Editar(login);
            SalvarAuditoria("Usuario Deslogou");
            return Ok();
        }
        
        [HttpDelete]
        [Route("Deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id)
        {
            if (!ConferirLogin())
            {
                SalvarAuditoria("Alguém falhou ao deletar Login");
                return NotFound("Usuario não logado");
            }

            dbOperacoesLogin.Deletar(id);
            SalvarAuditoria("usuario deletado");
            return Ok();
        }

        [HttpGet]
        [Route("Selecionar/{id}")]
        public ActionResult<Login> Selecionar([FromRoute] int id)
        {
            if (!ConferirLogin())
            {
                SalvarAuditoria("Alguém falhou ao selecionar login");
                return NotFound("Usuario não logado");
            }
            var login = dbOperacoesLogin.SelecionarPorId(id);
            SalvarAuditoria("usuario cadastrado");
            return Ok(login);
        }

        [HttpGet]
        [Route("SelecionarTodos")]
        public ActionResult<List<Login>> SelecionarTodos()
        {
            var lista = new List<Login>();
            if (!ConferirLogin())
            {
                SalvarAuditoria("Alguém falhou ao selecionar todos logins");
                return NotFound(lista);
            }
            
            lista = dbOperacoesLogin.RetornarTudo();
            SalvarAuditoria("Usuario selecionou todos logins");
            return Ok(lista);
        }

        [HttpPut]
        [Route("Atualizar")]
        public ActionResult Atualizar([FromBody] Login login)
        {
            if (!ConferirLogin())
            {
                SalvarAuditoria("Alguém tentou atualizar login");
                return NotFound("Usuario não logado");
            }
            dbOperacoesLogin.Editar(login);
            SalvarAuditoria("Usuario atualizou login");
            return Ok();
        }
    }
}
