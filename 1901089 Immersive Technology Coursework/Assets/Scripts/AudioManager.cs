using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    public static AudioManager Instance 
    { 
        get 
        {
            if (instance == null)
                Debug.LogError("No AudioManager in scene");

            return instance;
        }
        private set
        {
            instance = value;
        }
    }

    public AudioSource BackgroundMusic;
    public AudioSource PickupSFX;
    public AudioSource WinSFX;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Debug.LogWarning("AudioManager already exists in scene, destroying this extra instance");
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

    public void PlayWinSFX()
    {
        WinSFX.Play();
    }
}
