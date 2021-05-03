using System;
namespace boxingunboxing
{
  class Program
  {
    static void Main()
    {
      //int i=10;
      //object obj=i;  //boxing with implicit cast
      //int j=Convert.ToInt32(obj);
      //Console.WriteLine(j);

      //int i=10;
      //object obj=i;
      //string s=obj.ToString();      
      //int j=int.Parse(s);
      //Console.WriteLine(j);
   
      int i=10;
      //object obj=i;
      obj="Ten";
      string s=obj.ToString();
      int j;
      bool result=int.TryParse(s, out j);
      if(result==true)
      {
        Console.WriteLine(j);
      }
      else
      {
        Console.WriteLine("Invalid value!!");
      }
        Console.ReadKey();
    }
  }
}