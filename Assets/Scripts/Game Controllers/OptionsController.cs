﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour
{
    [SerializeField]
    private GameObject easySign, mediumSign, hardSign;

    // Start is called before the first frame update
    void Start()
    {
        SetTheDifficulty();
    }

    void SetInitialDifficulty(string difficulty)
    {
        switch (difficulty)
        {
            case "easy":
                easySign.SetActive(true);
                mediumSign.SetActive(false);
                hardSign.SetActive(false);
                break;
            case "medium":
                mediumSign.SetActive(true);
                easySign.SetActive(false);
                hardSign.SetActive(false);
                break;
            case "hard":
                hardSign.SetActive(true);
                mediumSign.SetActive(false);
                easySign.SetActive(false);
                break;
        }
    }

    void SetTheDifficulty()
    {
        if(GamePreferences.GetEasyDifficultyState() == 1)
        {
            SetInitialDifficulty("easy");
        }
        if (GamePreferences.GetMediumDifficultyState() == 1)
        {
            SetInitialDifficulty("medium");
        }
        if (GamePreferences.GetHardDifficultyState() == 1)
        {
            SetInitialDifficulty("hard");
        }
    }

    public void EasyDifficulty()
    {
        GamePreferences.SetEasyDifficultyState(1);
        GamePreferences.SetMediumDifficultyState(0);
        GamePreferences.SetHardDifficultyState(0);

        SetInitialDifficulty("easy");
    }

    public void MediumDifficulty()
    {
        GamePreferences.SetEasyDifficultyState(0);
        GamePreferences.SetMediumDifficultyState(1);
        GamePreferences.SetHardDifficultyState(0);

        SetInitialDifficulty("medium");
    }

    public void HardDifficulty()
    {
        GamePreferences.SetEasyDifficultyState(0);
        GamePreferences.SetMediumDifficultyState(0);
        GamePreferences.SetHardDifficultyState(1);

        SetInitialDifficulty("hard");
    }

    public void GoBackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
