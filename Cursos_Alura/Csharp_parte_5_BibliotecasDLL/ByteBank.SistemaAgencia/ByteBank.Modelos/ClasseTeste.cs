using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoInterno();
            teste.MetodoPublico();
        }
    }

    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            //teste.MetodoProtected();
        }
    }
    public class ModificadoresTeste
    {

        public void MetodoPublico()
        {

        }
        private void MetodoPrivado()
        {

        }
        protected void MetodoProtected()
        {

        }

        internal void MetodoInterno()
        {
    
        }
    }

}
