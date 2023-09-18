using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfSections : MonoBehaviour
{
    public static void ListOf(string nameOfSection)
    {
        WordsAndDescriptionriptions.listOfWords = new List<string>();
        WordsAndDescriptionriptions.listOfDiscriptions = new List<string>();
        switch (PlayerPrefs.GetString("PlayerLang"))
        {
            case "en-US":
                WordsAndDescriptionriptions.tempDict = JSON_Control.LoadJsonFile(nameOfSection + "_us_upd");
                break;
            case "uk-UA":
                WordsAndDescriptionriptions.tempDict = JSON_Control.LoadJsonFile(nameOfSection + "_ua_upd");
                break;
        }

        foreach (var pair in WordsAndDescriptionriptions.tempDict)
        {
            WordsAndDescriptionriptions.listOfWords.Add(pair.Key);
            WordsAndDescriptionriptions.listOfDiscriptions.Add(pair.Value);
        }
        Debug.Log(WordsAndDescriptionriptions.listOfDiscriptions[0]);
    }
}
