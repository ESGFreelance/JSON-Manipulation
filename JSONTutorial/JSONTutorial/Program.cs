using JSONTutorial.Classes;
using Newtonsoft.Json;


#region Default Data

Product P = new Product();
P.Id = 1;
P.Name = "Apple";
P.Quantity = 50;


#endregion
#region Serialization
string output = JsonConvert.SerializeObject(P);
JsonSerializer serializer = new JsonSerializer();
string result = JsonConvert.SerializeObject(P);



Console.WriteLine();
#endregion

#region Deserialization

#endregion

#region Search

#endregion

#region Manipulation

#endregion