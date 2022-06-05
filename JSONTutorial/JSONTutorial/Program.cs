using JSONTutorial.Classes;
using Newtonsoft.Json;


#region Default Data

Product P = new Product();
P.Id = 1;
P.Name = "Apple";
P.Quantity = 50;


#endregion
#region Serialization
//The process of converting .NET objects into JSON
string serialize = JsonConvert.SerializeObject(P, Formatting.Indented);
Console.WriteLine(serialize);  
#endregion

#region Deserialization
//The process of converting JSON into .NET objects
Product deserialize = JsonConvert.DeserializeObject<Product>(serialize);
Console.WriteLine(deserialize);
#endregion