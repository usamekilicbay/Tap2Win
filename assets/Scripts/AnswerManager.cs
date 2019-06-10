using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerManager : MonoBehaviour
{
    public ClickControl clickControl;
    public GameOverManager gameOverManager;
    MusicManager musicManager;

    public int rightAnswer;
    public int p1WinCount;
    public int p2WinCount;
    //public int winCount;

    public Image player1Conq;
    public Image player2Conq;

    Vector2 vector2;

    public Text targetNumberTextP1;
    public Text targetNumberTextP2;


    private void Start()
    {
        musicManager = MusicManager.Instance;
        SetRightAnswer();
    }

    void SetRightAnswer()
    {

        rightAnswer = Random.Range(1, 3);

        targetNumberTextP1.text = rightAnswer.ToString();
        targetNumberTextP2.text = rightAnswer.ToString();

        musicManager.StartGame();

        clickControl.isTicked = false;
    }

    public void ControlAnswer(int player ,int comingAnswer)
    {
        if (comingAnswer == rightAnswer)
        {
            Debug.Log("Winner is: Player " + player);

           
            if (player == 1)
            {
                vector2 = player1Conq.rectTransform.sizeDelta;
                player1Conq.rectTransform.sizeDelta = new Vector2(1080, vector2.y + 540);
                //winCount++;
                p1WinCount++;
            }
            else if (player == 2)
            {               
                vector2 = player2Conq.rectTransform.sizeDelta;
                player2Conq.rectTransform.sizeDelta = new Vector2(1080, vector2.y + 540);
                //winCount++;
                p2WinCount++;
            }

            if (p1WinCount == 3)
            {
                gameOverManager.GameOver(1, 2, p1WinCount, p2WinCount);
            }
            else if (p2WinCount == 3)
            {
                gameOverManager.GameOver(2, 1, p1WinCount, p2WinCount);
            }
            else
            {
                SetRightAnswer();
            }
        }
        else
        {
            if (player == 1)
            {
                gameOverManager.GameOver(2, 1, p1WinCount, p2WinCount);
            }
            else if (player == 2)
            {
                gameOverManager.GameOver(1, 2, p1WinCount, p2WinCount);
            }
        }
    }
}
