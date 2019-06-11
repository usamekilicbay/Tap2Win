using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExtraTools;

public class MainMenuAnimationControl : MonoBehaviour
{
    public Animator animator;

    public void PlayAnimation()
    {
        animator.SetBool("Play", true);

        StartCoroutine(Play());
    }

    IEnumerator Play()
    {
        yield return new WaitForSeconds(1f);
        UIManager.Instance.InGame();
    }
}
