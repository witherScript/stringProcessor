using System;
using System.Collections.Generic;
namespace StringProcessor.Models
{
  public class Anagram
  {
    public string Reference{get; set;}
    public string WordList{get; set;}
    private string[] WordArray = ListToArray();
    private List<char[]> CharList;
    
    public Anagram(string referenceWord, string wordList)
    {
      Reference = referenceWord;
      WordList = wordList;
      WordArray = ListToArray();
      CharList = new List<char[]>();
      SetCharList();
    }

    public char[] WordToArray()
    {
      char[] letterArr = Reference.ToCharArray();
      return letterArr;
    }

    private string[] SetCharList()
    {
      foreach(string word in WordArray)
      {
        CharList.add(WordToArray(word));
      }
    }

    public string[] ListToArray()
    {
      string[] wordArr = WordList.Split(", ");
      return wordArr;
    }

    public bool CompareCharArray()
    {
      List<string> results = new List<string>{};
      

    }
  }
}