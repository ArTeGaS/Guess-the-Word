using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public void SettingsGameButton()
    {
        MenuMainScript.playButton.SetActive(false);
        MenuMainScript.settingsButton.SetActive(false);
        MenuMainScript.exitButton.SetActive(false);

        MenuMainScript.backToMenu.SetActive(true);
        MenuMainScript.resetProgress.SetActive(true);
    }
    public void ResetGameProgressButton()
    {
        PlayerPrefs.SetInt("animalsListFirstRunFlag", 0);
    }
    public void BackToMenu()
    {
        MenuMainScript.backToMenu.SetActive(false);
        MenuMainScript.resetProgress.SetActive(false);

        MenuMainScript.playButton.SetActive(true);
        MenuMainScript.settingsButton.SetActive(true);
        MenuMainScript.exitButton.SetActive(true);
    }
}
