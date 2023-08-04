using exemplo_injecao_de_dependencia.Interface;

namespace exemplo_injecao_de_dependencia.Services;

public class FileLogger : ILogger
{
    private readonly string _logFilePath;

    public FileLogger(string logFilePath)
    {
        _logFilePath = logFilePath;
    }

    public void Log(string message)
    {
        // Lógica para escrever a mensagem em um arquivo
        File.AppendAllText(_logFilePath, $"{DateTime.Now}: {message}\n");
    }
}