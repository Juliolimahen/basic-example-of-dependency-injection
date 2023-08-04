using exemplo_injecao_de_dependencia.Interface;

namespace exemplo_injecao_de_dependencia.Model;

public class Logger
{
    private readonly ILogger _logger;

    public Logger(ILogger logger)
    {
        _logger = logger;
    }

    public void LogMessage(string message)
    {
        _logger.Log(message);
    }
}