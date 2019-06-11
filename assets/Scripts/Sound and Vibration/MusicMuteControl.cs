using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMuteControl : MonoBehaviour
{
    private string muteMusic = "MuteMusic";

    AudioSource musicSource;

    public GameObject muteMusicButton;
    public GameObject nonMuteMusicButton;

    private void Awake()
    {
        musicSource = GameObject.Find("Music Player").GetComponent<AudioSource>();
    }

    void Start()
    {
        if (!PlayerPrefs.HasKey(muteMusic))
        {
            musicSource.mute = false;
            PlayerPrefs.SetFloat(muteMusic, 0);
            
            muteMusicButton.SetActive(false);
            nonMuteMusicButton.SetActive(true);
        }
        else
        {
            musicSource.mute = PlayerPrefs.GetFloat(muteMusic) == 1;

            if (PlayerPrefs.GetFloat(muteMusic) == 1)
            {
                muteMusicButton.SetActive(true);
                nonMuteMusicButton.SetActive(false);
            }
            else
            {
                muteMusicButton.SetActive(false);
                nonMuteMusicButton.SetActive(true);
            }
        }
    }

    public void MuteMusic()
    {
        PlayerPrefs.SetFloat(muteMusic, 1);
        musicSource.mute = PlayerPrefs.GetFloat(muteMusic) == 1;
        
        muteMusicButton.SetActive(true);
        nonMuteMusicButton.SetActive(false);
    }

    public void NonMuteMusic()
    {
        PlayerPrefs.SetFloat(muteMusic, 0);
        musicSource.mute = PlayerPrefs.GetFloat(muteMusic) == 1;
        
        muteMusicButton.SetActive(false);
        nonMuteMusicButton.SetActive(true);
    }

}
