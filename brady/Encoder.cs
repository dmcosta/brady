using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brady
{
  /// <summary>
  /// Encodes the Array into string with separators.
  /// </summary>
  class Encoder
  {
    /// <summary>
    /// Encoder Method. This method accepts a 2 dimensional array and a StringBuilder object
    /// Encodes the array items in this format: field1=value1#field"n"=value"n"
    /// </summary>
    /// <param name="dataArray"></param>
    /// <param name="builder"></param>
    /// <returns>String Builder Object with encoded array to string</returns>
    public static StringBuilder Encode(string[,] dataArray, StringBuilder builder)
    {
      //Iterate 1st dimension
      for (int i = 0; i < dataArray.GetLength(0); i++)
      {
        //Iterate 2nd dimension
        for (int l = 0; l < 2; l++)
        {
          //Append data to Strbuilder
          builder.Append(dataArray[i, l]);
          //Append "="
          builder.Append("=");
        }
        //Removes last char, we dont need it.
        builder.Remove(builder.Length - 1, 1);
        //Append "#"
        builder.Append("#");
      }
      //Removes last char, we dont need it.
      builder.Remove(builder.Length - 1, 1);
      //Returns encoded string
      return builder;
    }
  }
}

