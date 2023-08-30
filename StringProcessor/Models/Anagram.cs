using System;
using System.Collections.Generic;
namespace StringProcessor.Models
{
  public class Anagram
  {
    public string Reference{get; set;} 
    
    public Anagram(string referenceWord)
    {
      Reference = referenceWord;
    }

    public char[] ToArray()
    {
      char[] letterArr = Reference.ToCharArray();
      return letterArr;
    }
  }
}