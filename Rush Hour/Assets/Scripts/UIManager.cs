using System.Collections;

using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI pointsTXT;
    public GameManager gameManager;
    public GameObject PauseUI;
    public GameObject GameUI;
    public GameObject SettingsUI;
    public GameObject GameOverUI;
    public bool IsPause = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointsTXT.text = gameManager.points.ToString();



        if (!IsPause && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Escape)))
        {
            Pause();
           

        }
        else if (IsPause && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Escape)))
        {
            Resume();
           
        }
    }

    public void Pause()
    {
        
        Time.timeScale = 0;
        PauseUI.SetActive(true);
        GameUI.SetActive(false);
        IsPause = true;

    }

    public void Resume()
    {
        
        Time.timeScale = 1;
        PauseUI.SetActive(false);
        GameUI.SetActive(true);
        IsPause = false;
    }

    public void SettingsON()
    {
        SettingsUI.SetActive(true);
    }

    public void SettingsOFF()
    {
        SettingsUI.SetActive(false);
    }

    public void Reset()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        GameOverUI.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartScene");
        Time.timeScale = 1;
    }
}
