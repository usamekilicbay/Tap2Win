using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXMuteControl : MonoBehaviour
{
    private string muteSFX = "MuteSFX";

    AudioSource sfxSource;

    public GameObject muteSFXButton;
    public GameObject nonMuteSFXButton;

    private void Awake()
    {
        sfxSource = GameObject.Find("SFX").GetComponent<AudioSource>();
    }

    void Start()
    {
        if (!PlayerPrefs.HasKey(muteSFX))
        {
            PlayerPrefs.SetInt(muteSFX, 0);
            sfxSource.mute = PlayerPrefs.GetInt(muteSFX) == 1;
            
            muteSFXButton.SetActive(false);
            nonMuteSFXButton.SetActive(true);
        }
        else
        {
            sfxSource.mute = PlayerPrefs.GetInt(muteSFX) == 1;
           
            if (PlayerPrefs.GetInt(muteSFX) == 1)
            {
                muteSFXButton.SetActive(true);
                nonMuteSFXButton.SetActive(false);
            }
            else
            {
                muteSFXButton.SetActive(false);
                nonMuteSFXButton.SetActive(true);
            }
        }
    }

    public void MuteSoundSFX()
    {
        PlayerPrefs.SetInt(muteSFX, 1);
        sfxSource.mute = PlayerPrefs.GetInt(muteSFX) == 1;

        muteSFXButton.SetActive(true);
        nonMuteSFXButton.SetActive(false);
    }

    public void NonMuteSFX()
    {
        PlayerPrefs.SetInt(muteSFX, 0);
        sfxSource.mute = PlayerPrefs.GetInt(muteSFX) == 1;

        muteSFXButton.SetActive(false);
        nonMuteSFXButton.SetActive(true);
    }

}
