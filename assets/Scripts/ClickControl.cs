using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickControl : MonoBehaviour
{
    public AnswerManager answerManager;

    public bool isTicked;

    public Button P1LButton;
    public Button P1RButton;

    public Button P2LButton;
    public Button P2RButton;

    public Sprite pushedP1;
    public Sprite pushedP2;

    public void Click(int player, int answer)
    {
        if (!isTicked)
        {
            isTicked = true;
            answerManager.ControlAnswer(player,answer);
        }
    }


    public void Player1L()
    {
        Click(1,1);
        P1LButton.image.sprite = pushedP1;
    }
    public void Player1R()
    {
        Click(1,2);
        P1RButton.image.sprite = pushedP1;
    }


    public void Player2L()
    {
        Click(2,1);
        P2LButton.image.sprite = pushedP2;
    }
    public void Player2R()
    {
        Click(2,2);
        P2RButton.image.sprite = pushedP2;
    }
}
