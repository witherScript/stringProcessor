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
      Anagram collection = new Anagram("string");

      Assert.AreEqual(typeof(Anagram), collection.GetType());
    }
    [TestMethod]
    public void GetReference_ShouldReturnReferenceWord_String()
    { 
      string referenceWord = "bread";
      Anagram collection = new Anagram(referenceWord);
      
      Assert.AreEqual(referenceWord, collection.Reference);

    }
    [TestMethod]
    public void SetReference_ShouldSetReferenceWord_Void()
    {
      Anagram collection = new Anagram("word");
      string newWord = "dragon";
      collection.Reference = newWord;
      Assert.AreEqual(newWord, collection.Reference);
    }
  }
}