using Tyuiu.VaganovMA.Sprint7.TaskProject.V13.Lib; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
       string path = @"C:\Users\Ignis\AppData\Local\Temp\OutPutFileTaskProject.txt"; 
       FileInfo fileInfo = new FileInfo(path); 
       bool fileExit = fileInfo.Exists; 
       bool wait = true; 
       Assert.AreEqual(true, fileExit); 
   } 
} 
   //не делал!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
