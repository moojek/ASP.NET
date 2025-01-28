using System.Net.Http.Headers;
using System.Net.Http.Json;
using Z1.Model;

var client = new HttpClient();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

await Get();
await Post();

Console.ReadLine();

return;

async Task Post()
{
    var person = new Person() { Id = 188, Name = "ghj" };
    var response = await client.PostAsJsonAsync("http://localhost:5204/api/Person", person);
    var personResp = await response.Content.ReadFromJsonAsync<Person>();
    if (personResp != null) Console.WriteLine($"{personResp.Id} {personResp.Name}");
}

async Task Get()
{
    var response = await client.GetFromJsonAsync<IEnumerable<Person>>("http://localhost:5204/api/Person");

    if (response == null) return;
    foreach (var person in response)
    {
        Console.WriteLine($"{person.Id} {person.Name}");
    }
}