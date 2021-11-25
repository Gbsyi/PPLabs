namespace CacheStrategy;

class Program
{
    public static void Main(string[] args)
    {
        NullCache nullCache = new NullCache();
        MemoryCache memoryCache = new MemoryCache();
        FileCache fileCache = new FileCache("file.txt");
        PoorManCache poorManCache = new PoorManCache(5);
        Context context = new Context();

        //NullCache
        context.SetStrategy(nullCache);
        Test(context);
        Console.WriteLine();
     
        //MemoryCache
        context.SetStrategy(memoryCache);
        Test(context);
        Console.WriteLine();

        //FileCache
        context.SetStrategy(fileCache);
        Test(context);
        Console.WriteLine();

        //PoorManCache
        context.SetStrategy(poorManCache);
        Test(context);
        Console.WriteLine();
    }
    public static void Test(Context context)
    {
        try
        {
            context.WriteToCache("1", "5");
            Console.WriteLine("Успешно!");
            Console.WriteLine($"Результат чтения: {context.ReadFromCache("1")}");
            context.DeleteFromCache("1");
            Console.WriteLine("Успешно!");
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Указанный ключ отсутствует.");
        }
        catch (KeyExistException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}