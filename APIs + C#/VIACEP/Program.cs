Console.WriteLine("Informe o CEP:");
string cep = Console.ReadLine();
using (HttpClient client = new HttpClient())
{
    try
    {
        HttpResponseMessage response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);
    }
    catch (HttpRequestException)
    {
        Console.WriteLine("Cep Errado.");
    }
}