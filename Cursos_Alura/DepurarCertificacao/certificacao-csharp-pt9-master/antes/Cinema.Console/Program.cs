using Cinema.Dados;
using Cinema.Performance;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        private const string DatabaseServer = "(LocalDB)\\MSSQLLocalDB";
        private const string MasterDatabase = "master";
        private const string DatabaseName = "Cinema";
        static async Task Main(string[] args)
        {
            if (CinemaPerformance.ConfigurarCategoria()) return;
            CinemaPerformance.CriarContadores();
            TraceListener traceListener = new ConsoleTraceListener();
            //TraceListener traceListener = new TextWriterTraceListener("log.txt");
            //Trace.Listeners.Add(traceListener);
            Trace.AutoFlush = true;
            TraceSource traceSource = new TraceSource("Cinema", SourceLevels.All);
            traceSource.Listeners.Add(traceListener);

            traceSource.TraceEvent(TraceEventType.Information, 1001, "A aplicação iniciou.");

            CinemaDB cinemaDB = await CriarBanco();
            IList<Filme> filmes = await cinemaDB.GetFilmes();

            while (true)
            {
                await GerarRelatorio(filmes);
            }
            //traceListener.Flush();

            Console.CancelKeyPress += (source, e) =>
            {
                traceSource.TraceEvent(TraceEventType.Warning, 1003, "Control");
            };
            Console.ReadKey();

            traceSource.TraceEvent(TraceEventType.Information, 1002, "Trace 1002");
            if (!EventLog.SourceExists("MinhaFonte"))
            {
                EventLog.CreateEventSource("MinhaFonte", "Application");
            }

            EventLog eventLog = new EventLog();
            eventLog.Source = "MinhaFonte";
            eventLog.WriteEntry("A aplicação terminou!", EventLogEntryType.Information, 1002);

            foreach (EventLogEntry entrada in eventLog.Entries)
            {
                Console.WriteLine($"Fonte: {entrada.Source} \n Tipo: {entrada.EntryType} \n Hora: {entrada.TimeWritten} \n Mensagem: {entrada.Message}");
            }

            Console.ReadLine();
            eventLog.Close();
        }
        private static async Task<CinemaDB> CriarBanco()
        {
            var cinemaDB = new CinemaDB(DatabaseServer, MasterDatabase, DatabaseName);

            await cinemaDB.CriarBancoDeDadosAsync();
            return cinemaDB;
        }
        private static async Task GerarRelatorio(IList<Filme> filmes)
        {
            Console.WriteLine("RELATÓRIO DE FILMES");
            Console.WriteLine(new string('=', 50));

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            

            foreach (var filme in filmes)
            {
                Console.WriteLine("Diretor: {0} Titulo: {1}", filme.Diretor, filme.Titulo);
            }
            stopwatch.Stop();
            Console.WriteLine($"Gerou o relatorio em {stopwatch.ElapsedMilliseconds}");

            CinemaPerformance.ContadorAverageTimer32.IncrementBy(stopwatch.ElapsedTicks);
            CinemaPerformance.ContadorAverageTimer32Base.Increment();
        }
    }
}
