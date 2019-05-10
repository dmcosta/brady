using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brady
{
  class Program
  {
    //Note: This program could be made simpler with Lists and LINQ. 
    //But I kept the constrain of using arrays.
    static void Main(string[] args)
    {
      //var init
      StringBuilder builder = new StringBuilder();
      string inputString = "id=321#Name=ordeP#Salary=2000#teste=sdssdff";
      string[,] inputArray = new string[,] { { "id", "123" }, { "Name", "Pedro" }, { "Salary", "1000" }, { "teste", "2343243" } };
      string[,] outputArray = new string[,] { };
      
      //Encode array to string
      Console.WriteLine("Encoded String:");
      Console.WriteLine(Encoder.Encode(inputArray, builder));

      //Decode string to array
      Console.WriteLine("Decoded String in an array:");
      Decoder.Decode(outputArray, inputString);
      //Wait for key
      Console.Read();
    }
  }
}
