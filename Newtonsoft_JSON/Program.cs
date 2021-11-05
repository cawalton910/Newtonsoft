using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Newtonsoft_JSON
{
    class Program
    {
          static void Main(string[] args)
          {
              //Deserializing JSON files using Newtonsoft
              List<string> files = new List<string>();
              files.Add(FilePath("AtmosphericConvection"));
              files.Add(FilePath("Cosmos"));
              files.Add(FilePath("Endless Universe"));
              files.Add(FilePath("Quantum Physics"));
              files.Add(FilePath("TheTheoryOfEverything"));

              List<Book> books = new List<Book>();
              for (int i = 0; i < files.Count; i++)
              {
                  var jsonText = File.ReadAllText(files[i]);
                  Book book = JsonConvert.DeserializeObject<Book>(jsonText);
                  books.Add(book);
              }
              foreach (var item in books)
              {
                  Console.WriteLine(item.ToString());
              }
              //------------------------------------------------



              //Serializing JSON files using Newtonsoft
              Book book2 = new Book { id = "123", selfLink = "example link", volumeInfo = new volumeInfo { title = "Chase's book", authors = new List<string> { "Chase" }, description = "My book" } };
              string fileName = FilePath("Object to JSON.json");
              string jsonString = JsonConvert.SerializeObject(book2);
              File.WriteAllText(fileName, jsonString);
              //-----------------------------------------------


          }
          /// <summary>
          /// Method FilePath returns type string that finds the file path of file "rootFile1.txt"
          /// </summary>
          /// <returns></returns>
          public static string FilePath(string fileName)
          {
              string rootDirectory = System.IO.Directory.GetCurrentDirectory();           //Finds the path of the current working directory of the project
              rootDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
              return rootDirectory + $"{Path.DirectorySeparatorChar}JsonBooks{Path.DirectorySeparatorChar}{fileName}.json";       //Using our root directory from the RootPath() method find the file named 'rootFile1.txt.'      
          }
    }
}
