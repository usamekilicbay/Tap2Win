using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    bool p1bool;
    bool p2bool;

    public void P1Restart() { p1bool = true; Restart(); }

    public void P2Restart() { p2bool = true; Restart(); }

    public void Restart()
    {
        if (p1bool && p2bool)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


    public void MainMenuScene() { SceneManager.LoadScene(1); }
}
