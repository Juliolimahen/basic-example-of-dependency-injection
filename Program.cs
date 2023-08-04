// See https://aka.ms/new-console-template for more information
using exemplo_injecao_de_dependencia.Interface;
using exemplo_injecao_de_dependencia.Model;
using exemplo_injecao_de_dependencia.Services;

namespace exemplo_injecao_de_dependencia;

class Program
{

    static void Main(string[] args)
    {
        ILogger logger = new FileLogger("log.txt");
        Logger myLogger = new Logger(logger);

        myLogger.LogMessage("Mensagem de log importante!");
    }

}