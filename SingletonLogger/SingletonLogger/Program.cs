namespace SingletonLogger;
class Program
{
    public static void Main(string[] args)
    {
        Logger logger = Logger.GetLogger();
        Logger.SetLogFile("log.txt");

        logger.Log("Программа запущена: ", DateTime.Now);
        Person bob = new Person("Bob", 12);
        Person bobToo = new Person("Bob", bob.Age);
        logger.Log("Программа выполнилась");
    }
}