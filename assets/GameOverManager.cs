using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public UIController uiController;


    public void GameOver(int winnerP, int loserP, int p1Score, int p2Score)
    {
        uiController.GameOverUI(winnerP, loserP, p1Score, p2Score);
    }
}
