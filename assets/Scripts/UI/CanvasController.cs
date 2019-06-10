using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExtraTools;

public class CanvasController : MonoBehaviour
{
    public void MainMenu() { UIManager.Instance.CanvasChanger(CanvasObjects.MainMenu); }

    public void Settings() { UIManager.Instance.CanvasChanger(CanvasObjects.Settings); }

    public void InGame() { UIManager.Instance.CanvasChanger(CanvasObjects.InGame); }

    public void Tutorial() { UIManager.Instance.CanvasChanger(CanvasObjects.Tutorial); }
}
