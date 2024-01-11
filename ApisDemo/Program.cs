
//Create an instance of HTTPClient, this is what actually makes the api call

using Newtonsoft.Json.Linq;

var client = new HttpClient();

//We need to built an api url from where the api call comes from

var kanyeURL = "https://api.kanye.rest/";

//Using the HTTPClient instance we made above
//Send a GET request to the url created above, this is going to give us back a string of JSON

var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

//This just writes the whole body of Json
//Console.WriteLine(kanyeResponse);

//Parse the JSON response we just got back into JObject, we do this so we can access certain pieces of the JSON
//In this case we will be getting the value of "quote" which will be the actual quote not the whole JSON body
//Without ToString() it will be of type JToken, so we could never use it as a string
//var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
var kanyeQuote = JObject.Parse(kanyeResponse)["quote"].ToString();

