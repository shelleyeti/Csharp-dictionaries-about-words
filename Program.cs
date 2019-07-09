using System;
using System.Collections.Generic;

namespace dictionaries_about_words
{
  class Program
  {
    static void Main(string[] args)
    {
      // Make a new list
      List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

      /*
          You want to track the following about each word:
              word, definition, part of speech, example sentence

          Example of one dictionary in the list:
          {
              "word": "excited",
              "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
              "part of speech": "adjective",
              "example sentence": "I am excited to learn C#!"
          }
      */

      // Create dictionary to represent a few words
      Dictionary<string, string> excitedWord = new Dictionary<string, string>();
      new Dictionary<string, string>();
      // Add each of the 4 bits of data about the word to the Dictionary
      excitedWord.Add("word", "wild");
      excitedWord.Add("definition", "disbelief that this is happening in the modern time");
      excitedWord.Add("part of speech", "adjective");
      excitedWord.Add("example sentence", "This is wild.");

      // Add Dictionary to your `dictionaryOfWords` list
      dictionaryOfWords.Add(excitedWord);

      // create another Dictionary and add that to the list
      Dictionary<string, string> frustratedWord = new Dictionary<string, string>();
      new Dictionary<string, string>();

      frustratedWord.Add("word", "wack");
      frustratedWord.Add("definition", "outline");
      frustratedWord.Add("part of speech", "adjective");
      frustratedWord.Add("example sentence", "This is wack.");

      dictionaryOfWords.Add(frustratedWord);

      /*
          Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

          Example output for one word in the list of dictionaries:
              word: excited
              definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
              part of speech: adjective
              example sentence: I am excited to learn C#!
      */

      // Iterate the List of Dictionaries
      foreach (Dictionary<string, string> dictionary in dictionaryOfWords)
      {
        // Iterate the KeyValuePairs of the Dictionary
        foreach (KeyValuePair<string, string> wordData in dictionary)
        {
          Console.WriteLine($"{wordData.Key}: {wordData.Value}");
        }
      }
    }
  }
}
