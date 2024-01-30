using System;
using NLog;

class Program
{
	private static Logger logger = LogManager.GetCurrentClassLogger();

	static void Main(string[] args)
	{
		LogManager.Setup().LoadConfigurationFromFile("NLog.config");

		logger.Info("Hello, NLog!");
		logger.Warn("This is a warning message");

		try
		{
			throw new Exception("Sample exception");
		}
		catch (Exception ex)
		{
			logger.Error(ex, "Caught an exception");
		}
		
		LogManager.Shutdown();
	}
}
