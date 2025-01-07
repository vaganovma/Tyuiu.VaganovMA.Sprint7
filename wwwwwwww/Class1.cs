using Newtonsoft.Json;
namespace wwwwwwww
{
    public class Class1
    {
        public List<Lib> GetLibraries(string JsonPath)
        {
            string JsonFilePath = "../../../../Library.json";
            string json = File.ReadAllText(JsonFilePath);

            var books = JsonConvert.DeserializeObject<List<Lib>>(json);

            return books;
        }

        public List<Lib> SortLibrary(string JsonPath, int index)
        {
            string JsonFilePath = "../../../../Library.json";

            string json = File.ReadAllText(JsonFilePath);

            var books = JsonConvert.DeserializeObject<List<Lib>>(json);

            switch (index)
            {
                case 0:
                    return books.OrderBy(book => book.video_code).ToList();
                case 1:
                    return books.OrderBy(book => book.record_date).ToList();
                case 2:
                    return books.OrderBy(book => book.duration).ToList();
                case 3:
                    return books.OrderBy(book => book.theme).ToList();
                case 4:
                    return books.OrderBy(book => book.price).ToList();
                case 5:
                    return books.OrderBy(book => book.actor).ToList();

        //             public string video_code { get; set; }
        //public string record_date { get; set; }
        //public int duration { get; set; }
        //public int theme { get; set; }
        //public bool price { get; set; }
        //public string actor { get; set; }
    }
            return books.ToList();

        }
        public List<Lib> SearchFilm(string JsonPath, string text)
        {
            string JsonFilePath = "../../../../Library.json";


            string json = File.ReadAllText(JsonPath);

            var books = JsonConvert.DeserializeObject<List<Lib>>(json);
            string searchvalue = text.Trim();
            var filteredBooks = books.FindAll(book => book.actor.IndexOf(searchvalue, StringComparison.OrdinalIgnoreCase) >= 0);

            return filteredBooks;
        }
    }
}
