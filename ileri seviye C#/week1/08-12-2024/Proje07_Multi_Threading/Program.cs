//SENKRON;
//String içinde r ne işe yarıyor araştırın.
// System.Console.WriteLine("1.İşlem(5 saniye)");
// for (int i = 0; i <= 5; i++)
// {
//     System.Console.WriteLine($"\r[1.işlem] Geçen Süre: {i}sn ");
//     Thread.Sleep(1000);
// }
// System.Console.WriteLine("1.İşlem Sona Erdi.");

// System.Console.WriteLine("2.işlem(10 saniye)");
// for (int i = 0; i <= 10; i++)
// {
//     System.Console.WriteLine($"\r2.işlem] Geçen Süre: {i}sn ");
//     Thread.Sleep(1000);
// }
// System.Console.WriteLine("2.işlem sona erdi.");

//ASENKRON;
string task1Status = "5 saniyelik işlem bekleniyor..";
string task2Status = "10saniyelik işlem bekleniyor..";

object consolelock = new object();

Thread thread1 = new Thread(() =>
{
    for (int i = 1; i <= 5; i++)
    {
        lock (consolelock)
        {
            task1Status = $"5 saniyelik işlem için geçen süre:{i}sn";
            Console.Clear();
            System.Console.WriteLine($"{task1Status} \n {task2Status}");
        }
        Thread.Sleep(1000);
    }
    lock (consolelock)
    {
        task1Status = "5 saniyelik işlem tamamlandı.";
        Console.Clear();
        System.Console.WriteLine($"{task1Status} \n {task2Status}");
    }


});
Thread thread2 = new Thread(() =>
{
    for (int i = 1; i <= 10; i++)
    {
        lock (consolelock)
        {
            task2Status = $"10 saniyelik işlem için geçen süre:{i}sn";
            Console.Clear();
            System.Console.WriteLine($"{task1Status} \n {task2Status}");
        }

        Thread.Sleep(1000);
    }
    lock (consolelock)
    {
        task2Status = "10 saniyelik işlem tamamlandı.";
        Console.Clear();
        System.Console.WriteLine($"{task1Status} \n {task2Status}");
    }

});
thread1.Start();
thread2.Start();

