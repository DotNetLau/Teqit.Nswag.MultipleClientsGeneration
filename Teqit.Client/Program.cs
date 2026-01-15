using Teqit.Api.Client;

const string apiBaseUrl = "http://localhost:5041/";
var httpClient = new HttpClient();

var airplanesClient = new AirplanesClient(apiBaseUrl, httpClient);
var airplaneResult = await airplanesClient.GetAirplaneByIdAsync(2);
Console.WriteLine($"Airplane ID: {airplaneResult.Id} - Airplane name: {airplaneResult.Name}");

var helicoptersClient = new HelicoptersClient(apiBaseUrl, httpClient);
var heliResult = await helicoptersClient.GetHelicopterByIdAsync(3);
Console.WriteLine($"Helicopter ID: {heliResult.Id} - Airplane name: {heliResult.Name}");

httpClient.Dispose();