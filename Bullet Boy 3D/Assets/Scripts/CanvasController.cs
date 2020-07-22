﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    public Text quantityCoins;
    public Text endLevelText;
    public Image objective;
    public GameObject menu;
    public GameObject nextLevelBtn;

    void Awake()
    {
        //Debug.Log(Progress.instance.coins.ToString());
        RefreshCoinsBar();
    }

    public void RefreshCoinsBar()
    {
        quantityCoins.text = Progress.instance.coins.ToString();
    }

    public void RefreshObjective()
    {
        objective.color = Color.red;
    }

    public void Result(bool result)
    {
        menu.SetActive(true);
        if(result)
        {
            endLevelText.text = "You Win!";
        }
        else
        {
            endLevelText.text = "You Lose:(";
            nextLevelBtn.SetActive(false);
        }
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
