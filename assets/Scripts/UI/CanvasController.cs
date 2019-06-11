using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExtraTools;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    public void MainMenu() { UIManager.Instance.CanvasChanger(CanvasObjects.MainMenu); }

    public void Settings() { UIManager.Instance.CanvasChanger(CanvasObjects.Settings); }

    public void Tutorial() { UIManager.Instance.CanvasChanger(CanvasObjects.Tutorial); }
}
