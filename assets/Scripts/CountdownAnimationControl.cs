using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownAnimationControl : MonoBehaviour
{

    public Animator animator;
    public bool countDown;

    public void CountDownAnimation()
    {
        animator.SetBool("Countdown", countDown);
    }
}
