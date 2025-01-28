using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

const string plainTextSecurityKey = "VQDJ4SuqHNNMDF8VuqhRqw77VQQax7rtWEsIH9jxSA3aK98B0ZhC3zzCA67pFs9q\n";

var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(plainTextSecurityKey));
var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256Signature);

var claimsIdentity =
    new ClaimsIdentity(new List<Claim>()
    {
        new(JwtRegisteredClaimNames.Name, "username1")
    });

var securityTokenDescriptor = new SecurityTokenDescriptor
{
    Subject = claimsIdentity,
    SigningCredentials = signingCredentials
};

var tokenHandler = new JwtSecurityTokenHandler();
var plainToken = tokenHandler.CreateToken(securityTokenDescriptor);
var signedAndEncodedToken = tokenHandler.WriteToken(plainToken);

Console.WriteLine(plainToken);
Console.WriteLine(signedAndEncodedToken);

var client = new HttpClient();
client.DefaultRequestHeaders.Add("Authorization", $"Bearer {signedAndEncodedToken}");

var res = await client.GetAsync("http://localhost:5098/weatherforecast");
if (res.StatusCode == System.Net.HttpStatusCode.OK)
{
    var result = await res.Content.ReadAsStringAsync();
    Console.WriteLine(result);
}
else
{
    Console.WriteLine($"Status: {res.StatusCode}");
}

Console.ReadLine();