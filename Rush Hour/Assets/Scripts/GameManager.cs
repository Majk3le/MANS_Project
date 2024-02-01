using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIManager UIManager;
    public SoundManager SoundManager;
    public GameObject road;
    public GameObject car;
    public SavePlayer Players;
    public int points;
    float road_length;
    float nextRoad;
    private bool IsLower = true;
    private int TmpScore;
    private string TmpUsername;
    // Start is called before the first frame update
    void Start()
    {
        road_length = 10;
        nextRoad = road_length;
        GenerateRoad();
        points = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (car.transform.position.z >= nextRoad -120)
            {
                GenerateRoad();
            }
       
    }
    

        void GenerateRoad()
    {
        Instantiate(road, new Vector3(0, 0, road_length+nextRoad), Quaternion.identity);
        nextRoad += 10;
    }
    void OnCollisionEnter(Collision collision)
    {
        UIManager.GameOverUI.SetActive(true);
        SaveScore();
        Time.timeScale = 0;
        car.GetComponent<movements>().enabled = false;
        SoundManager.StopMusic();
        
    }
    public void SaveScore()
    {
        

        for(int i = 0; i < 5 && IsLower; i++)
        {
            if (!Players.username.Contains(PlayerPrefs.GetString("Nickname")) )
            {


                if (Players.score[i] < points)
                {
                    for (int j = 4; j > i; j--)
                    {
                        if (i != 5 || j != 4)
                        {
                            Players.score[j] = Players.score[j - 1];
                            Players.username[j] = Players.username[j - 1];
                        }
                    }
                    Players.score[i] = points;
                    Players.username[i] = PlayerPrefs.GetString("Nickname");
                    IsLower = false;

                }
            }
            else
            {
                
                if (Players.score[i] < points && Players.username[i]== PlayerPrefs.GetString("Nickname"))
                    {
                    Players.score[i] = points;
                    for (int k = 0; k < 5; k++)
                    {
                        for (int j = k + 1; j < 5; j++)
                        {
                            if (Players.score[k] < Players.score[j])
                            {
                                TmpScore = Players.score[k];
                                TmpUsername = Players.username[k];
                                Players.score[k] = Players.score[j];
                                Players.username[k] = Players.username[j];
                                Players.score[j] = TmpScore;
                                Players.username[j] = TmpUsername;
                            }
                        }

                    }
                    IsLower = false;
                }
            }
        }
    }
}
