using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider sliderMusic;
    
    public float vol;
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Volume"))
        {
            sliderMusic.value = PlayerPrefs.GetFloat("Volume");
        }
        else
        {
            sliderMusic.value = 0.5f;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        vol = sliderMusic.value;
        
        PlayerPrefs.SetFloat("Volume", vol);
        PlayerPrefs.Save();
    }

    public void changeCamera()
    {
        if (PlayerPrefs.GetFloat("Camera") == 1)
        {
            PlayerPrefs.SetFloat("Camera", 2);
            PlayerPrefs.Save();
        }
        else if (PlayerPrefs.GetFloat("Camera") == 2)
        {
            PlayerPrefs.SetFloat("Camera", 1);
            PlayerPrefs.Save();
        }
    }
}
