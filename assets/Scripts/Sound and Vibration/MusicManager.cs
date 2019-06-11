using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager _instance;
    public static MusicManager Instance { get { return _instance; } }

    public AudioClip startSound;

    public AudioSource musicSource;
    public AudioSource sfxSource;


    private void Awake()
    {
        _instance = this;
    //    PlayMusic();
    }

    void PlayMusic()
    {
        //musicSource.clip = startSound;
     //   musicSource.PlayDelayed(0.5f);
    }

    public void StartGame()
    {
        sfxSource.PlayOneShot(startSound);
    }
}
