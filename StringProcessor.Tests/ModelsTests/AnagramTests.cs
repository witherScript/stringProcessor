using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using StringProcessor.Models;

namespace StringProcessor.Tests
{
  [TestClass]
  public class AnagramTests
  {
    [TestMethod]
    public void AnagramConstructor_CreatesInstanceOf_Void()
    {
      Anagram collection = new Anagram("string", "");

      Assert.AreEqual(typeof(Anagram), collection.GetType());
    }
    [TestMethod]
    public void GetReference_ShouldReturnReferenceWord_String()
    { 
      string referenceWord = "bread";
      Anagram collection = new Anagram(referenceWord, "");
      
      Assert.AreEqual(referenceWord, collection.Reference);

    }
    [TestMethod]
    public void SetReference_ShouldSetReferenceWord_Void()
    {
      Anagram collection = new Anagram("word", "");
      string newWord = "dragon";
      collection.Reference = newWord;
      Assert.AreEqual(newWord, collection.Reference);
    }
    [TestMethod]
    public void ToArray_ShouldReturnCharArray_CharArray()
    {
      Anagram collection = new Anagram("word", "");
      char[] actual = collection.WordToArray();
      char[] expected = {'w', 'o', 'r', 'd'};

      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ListToArr_ShouldReturnArrayFromString_StringArray()
    {
      string str = "Car, Brook, Bed, Book";
      string[] expected = {"Car", "Brook", "Bed", "Book"};

      Anagram collection = new Anagram("bar", str);
      string[] actual = collection.ListToArray();
      CollectionAssert.AreEqual(expected, actual);
    }
    public void CompareCharArray_ShouldReturnTrueForEqualCharArrays_Bool()
    {
      string str = {"Car"};
      Anagram collection = new Anagram("Car", str);
      string[] actual = collection.CompareCharArray();
      string[] expected = {"true"};
    }
  }
}