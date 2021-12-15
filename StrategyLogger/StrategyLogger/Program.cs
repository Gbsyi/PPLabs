
namespace StrategyLogger{
    public static class Program
    {
        public static void Main(string[] args)
        {   
            Logger logger = new Logger();
            //Вывод через консоль
            logger.SetStrategy(new ConsoleLogger());
            logger.LogMessage("Проверка 1");
            logger.LogMessage("Проверка 2");
            //Вывод в файл
            logger.SetStrategy(new SimpleFileLogger());
            logger.LogMessage("Обычный вывод в файл");
            //Вывод в файл с временем
            logger.SetStrategy(new TimedFileLogger());
            logger.LogMessage("Вывод в файл с сообщения с временной меткой.");
        }
    }
}