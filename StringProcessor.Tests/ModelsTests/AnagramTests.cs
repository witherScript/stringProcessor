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
      Anagram collection = new Anagram();

      Assert.AreEqual(typeof(Anagram), collection.GetType());
    }
  }
}