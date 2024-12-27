using tyuiu.cources.programming.interfaces.Sprint7; 
using System.IO; 
 
namespace Tyuiu.VaganovMA.Sprint7.TaskProject.V13.Lib; 
 
public class DataService //: ISprint7TaskProjectV13 
{ 
} 
 
string path = Path.Combine(Path.GetTempPath(), "OutPutFileTaskProject.txt"); 
double z = (Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2)); 
z =Math.Round(z, 3); 
File.WriteAllText(path, Convert.ToString(z)); 
return path; 
     