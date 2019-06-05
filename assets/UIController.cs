using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject p1WinImage;
    public GameObject p2WinImage;
    public GameObject gameButtons;

    public Text scoreText;

    void Start()
    {
        DefaultGameUI();
    }

    public void DefaultGameUI()
    {
        gameButtons.SetActive(true);
        gameOverPanel.SetActive(false);
        p1WinImage.SetActive(false);
        p2WinImage.SetActive(false);
    }

    public void GameOverUI(int winnerP, int loserP, int p1Score, int p2Score)
    {
        gameOverPanel.SetActive(true);

        if (winnerP == 1)
        {
            p1WinImage.SetActive(true);
            p2WinImage.SetActive(false);
        }
        else if (winnerP == 2)
        {
            p2WinImage.SetActive(true);
            p1WinImage.SetActive(false);
        }

        scoreText.text = p1Score + " + " + p2Score;
    }
}
