using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] carPrefab;
    public GameObject container;
    private int CarID;
    private UnityEngine.Quaternion rotation;
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "StartScene")
        {
            rotation = UnityEngine.Quaternion.Euler(new UnityEngine.Vector3(0, 180, 0));
            CarID = PlayerPrefs.GetInt("Car");
        }
        else
        {
            rotation = UnityEngine.Quaternion.identity;
        }
        if (!PlayerPrefs.HasKey("car"))
        {
            PlayerPrefs.SetInt("car", 0);
            PlayerPrefs.Save();
        }
        
            //Destroy(container.transform.GetChild(0).gameObject);
            var child = Instantiate(carPrefab[PlayerPrefs.GetInt("car")], container.transform.position, rotation , container.transform);

            child.transform.parent = container.transform;
        if (SceneManager.GetActiveScene().name == "StartScene")
        {
            child.transform.localScale = new UnityEngine.Vector3(35, 35, 35);
        }
    }
    public void changeCar()
    {
        CarID++;
        if (CarID > 4)
        {
            CarID = 0;
        }
        PlayerPrefs.SetInt("car", CarID);
        PlayerPrefs.Save();
        Destroy(container.transform.GetChild(0).gameObject);
        var child = Instantiate(carPrefab[PlayerPrefs.GetInt("car")], container.transform.position, UnityEngine.Quaternion.Euler(new UnityEngine.Vector3(0, 180, 0)), container.transform);

        child.transform.parent = container.transform;
        child.transform.localScale = new UnityEngine.Vector3(35, 35, 35);
    }
    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "StartScene")
        {
            container.transform.Rotate(new UnityEngine.Vector3(0, 1, 0), 20 * Time.deltaTime);
        }
    }
}
