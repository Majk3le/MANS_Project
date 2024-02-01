using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoadGenerator : MonoBehaviour
{
    public GameObject[] Obstacles;
    public GameObject[] SpawnPoints;
    public Transform par;
    int free;
    int Obs;
    // Start is called before the first frame update
    void Start()
    {
        free = Random.Range(0, 3);
        for (int i = 0; i < 3; i++)
        {
            if (i != free)
            {
                Obs = Random.Range(0, Obstacles.Length);
                Instantiate(Obstacles[Obs], SpawnPoints[i].transform.position, Quaternion.identity, par );
            }
            
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
