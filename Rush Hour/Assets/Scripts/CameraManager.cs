using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Camera"))
        {
            PlayerPrefs.SetFloat("Camera", 1);
            PlayerPrefs.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetFloat("Camera") == 1)
        {
            cam1.enabled = true; 
            cam2.enabled = false;
        }
        if (PlayerPrefs.GetFloat("Camera") == 2)
        {
            cam1.enabled = false;
            cam2.enabled = true;
        }
    }
}
