// See https://aka.ms/new-console-template for more information
using RestSharp;
using Newtonsoft.Json;

//using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");

RestClient client = new RestClient();

//Request1 - Get AUth Token
RestRequest reql = new RestRequest("https://localhost:7238/api/Name/authenticate", Method.Post);
reql.AddJsonBody(new
{
    username = "test1",
    password = "password1"
});

var response1 = client.Execute(reql);
var token = JsonConvert.DeserializeObject<string>(response1.Content);
Console.WriteLine(token);

//Request2- Call Authorized API, by attaching the token
RestRequest req2 = new RestRequest("https://localhost:7238/api/Name", Method.Get);
client.AddDefaultHeader("Authorization", $"Bearer {token}");
var response2 = client.Execute(req2);
var content = response2.Content;
Console.WriteLine(content);
    
Console.ReadLine(); //type enter to exit application