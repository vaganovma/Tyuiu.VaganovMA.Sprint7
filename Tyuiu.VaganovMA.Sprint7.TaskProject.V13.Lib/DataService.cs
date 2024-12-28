using tyuiu.cources.programming.interfaces.Sprint7; 
using System.IO; 
using Newtonsoft.Json;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
 
namespace Tyuiu.VaganovMA.Sprint7.TaskProject.V13.Lib; 
 
public class DataService : ISprint7ProjectV13
{
    public DataService()
    { 
    
    }
    

   
        public List<Library> GetLibraries(string JsonPath)
        {
            string json = File.ReadAllText(JsonPath);

            var books = JsonConvert.DeserializeObject<List<Library>>(json);

            return books;
        }

        public List<Library> SortLibrary(string JsonPath, int index)
        {
            string json = File.ReadAllText(JsonPath);

            var books = JsonConvert.DeserializeObject<List<Library>>(json);

            switch (index)
            {
                case 0:
                    return books.OrderBy(book => book.Author).ToList();
                case 1:
                    return books.OrderBy(book => book.Title).ToList();
                case 2:
                    return books.OrderBy(book => book.Year).ToList();
                case 3:
                    return books.OrderBy(book => book.Price).ToList();
                case 4:
                    return books.OrderBy(book => book.Is_New_Edition).ToList();
                case 5:
                    return books.OrderBy(book => book.Annotation).ToList();


            }
            return books.ToList();

        }
        public List<Library> SearchBook(string JsonPath, string text)
        {

            string json = File.ReadAllText(JsonPath);

            var books = JsonConvert.DeserializeObject<List<Library>>(json);
            string searchvalue = text.Trim();
            var filteredBooks = books.FindAll(book => book.Title.IndexOf(searchvalue, StringComparison.OrdinalIgnoreCase) >= 0);

            return filteredBooks;
        }


    }
} 
 

     