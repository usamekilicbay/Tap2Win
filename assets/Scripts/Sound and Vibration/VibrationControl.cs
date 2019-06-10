using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationControl : MonoBehaviour
{
    private string vibrationKey = "Vibration";

    public int vibrationValue;

    public GameObject vibrationOffButton;
    public GameObject vibrationOnButton;

    private void Awake()
    {
        
    }

    void Start()
    {
        if (!PlayerPrefs.HasKey(vibrationKey))
        {
            PlayerPrefs.SetInt(vibrationKey, 1);

            vibrationValue = PlayerPrefs.GetInt(vibrationKey);

            vibrationOffButton.SetActive(false);
            vibrationOnButton.SetActive(true);
        }
        else
        {
            vibrationValue = PlayerPrefs.GetInt(vibrationKey);

            if (PlayerPrefs.GetInt(vibrationKey) == 0)
            {
                vibrationOffButton.SetActive(true);
                vibrationOnButton.SetActive(false);
            }
            else
            {
                vibrationOffButton.SetActive(false);
                vibrationOnButton.SetActive(true);
            }
        }
    }

    public void VibrationOff()
    {
        PlayerPrefs.SetInt(vibrationKey, 0);

        vibrationValue = PlayerPrefs.GetInt(vibrationKey);

        vibrationOffButton.SetActive(true);
        vibrationOnButton.SetActive(false);
    }

    public void VibrationOn()
    {
        PlayerPrefs.SetInt(vibrationKey, 1);

        vibrationValue = PlayerPrefs.GetInt(vibrationKey);

        vibrationOffButton.SetActive(false);
        vibrationOnButton.SetActive(true);
    }

}
