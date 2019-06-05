using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickControl : MonoBehaviour
{
    public AnswerManager answerManager;

    public bool isTicked;

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
    }
    public void Player1R()
    {
        Click(1,2);
    }


    public void Player2L()
    {
        Click(2,1);
    }
    public void Player2R()
    {
        Click(2,2);
    }
}
