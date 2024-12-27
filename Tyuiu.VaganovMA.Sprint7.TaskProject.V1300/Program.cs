using Tyuiu.VaganovMA.Sprint7.TaskProject.V13.Lib; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #7 | Выполнил: Ваганов. М. А. | ИИПб-24-2"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #7                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #Project                                                           *"); 
        Console.WriteLine("* Вариант #13                                                          *"); 
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич  | ИИПб-24-2                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите переменную X:"); 
        double x = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Введите переменную Y:"); 
        int y = int.Parse(Console.ReadLine()!); 
 
        string path = $@"C:\DataSprint5\InPutDataFileTaskProjectV13.txt"; 
        Console.WriteLine("данные находятся в файле: " + path); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine(); 
        string res = ds.SaveToFileTextData(x);  
        double res = ds.LoadFromDataFile(path); 
 
        Console.WriteLine($"Файл "+res); 
        Console.WriteLine($"Создан"); 
        Console.ReadKey(); 
    } 
} 
