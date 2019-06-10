using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    AudioSource musicSource;
    AudioSource sfxSource;
    public Slider volumeSlider;

    private void Awake()
    {
       musicSource = GameObject.Find("Music Player").GetComponent<AudioSource>();
       sfxSource = GameObject.Find("SFX").GetComponent<AudioSource>();
    }

    void Start()
    {
        if (!PlayerPrefs.HasKey("Volume"))
        {
            volumeSlider.value = 50f;
            PlayerPrefs.SetFloat("Volume", volumeSlider.value);
            musicSource.volume = volumeSlider.value;
            sfxSource.volume = volumeSlider.value;
        }
        else
        {
            volumeSlider.value = PlayerPrefs.GetFloat("Volume");
            musicSource.volume = volumeSlider.value;
            sfxSource.volume = volumeSlider.value;
        }
    }

    public void SetVolume()
    {
        PlayerPrefs.SetFloat("Volume", volumeSlider.value);
        musicSource.volume = volumeSlider.value;
        sfxSource.volume = volumeSlider.value;
    }
}
