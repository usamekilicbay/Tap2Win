using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    int restartCount = 0;
    public void Restart()
    {
        restartCount++;
        if (restartCount == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            restartCount = 0;
        }
    }
}
