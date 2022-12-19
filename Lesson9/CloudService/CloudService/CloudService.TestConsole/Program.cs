using CloudService.WebAPI.Clients;
/// <summary>
/// Тестовое консольное приложение для проверки работоспособности клиента
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        HttpClient client = new();
        client.BaseAddress = new Uri("http://localhost:5059");
        CloudsClient cloudsClient = new(client);

        var result = cloudsClient.GetAllAsync().Result;

        foreach (var item in result)
        {
            Console.WriteLine($"{item.Id} / {item.Os} / {item.Cpu} / {item.Rom}");
        }
        Console.ReadKey(true);
    }
}