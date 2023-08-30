namespace StringProcessor.Models
{
  public class Anagram
  {
    public string Reference{get; set;} 
    
    public Anagram(string referenceWord)
    {
      Reference = referenceWord;
    }
  }
}