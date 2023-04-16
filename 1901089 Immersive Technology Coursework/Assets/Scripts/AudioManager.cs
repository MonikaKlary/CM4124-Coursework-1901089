using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    public AudioSource BackgroundMusic;
    public AudioSource PickupSFX;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            Instance = this;
            PlayMusic();
        }
    }

    public void SetAudioVolumes(float musicVolume)
    {
        BackgroundMusic.volume = musicVolume;

        //TODO add a separate SFX volume
        PickupSFX.volume = musicVolume;
    }

    public void PlayMusic()
    {
        BackgroundMusic.Play();
    }

    public void PlayPickup()
    {
        PickupSFX.Play();
    }
}
