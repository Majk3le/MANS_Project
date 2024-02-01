using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource sourceMusic;
    public AudioClip[] Music;
    public Settings settings;
    public float vol;

    void Start()
    {
        if (!PlayerPrefs.HasKey("Volume"))
        {
            PlayerPrefs.SetFloat("Volume", 0.5f);
        }
        sourceMusic.clip = Music[Random.Range(0, Music.Length)];
        sourceMusic.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
            sourceMusic.volume = PlayerPrefs.GetFloat("Volume");
        

    }
    public void StopMusic()
    {
        sourceMusic.Pause();
    }
}
