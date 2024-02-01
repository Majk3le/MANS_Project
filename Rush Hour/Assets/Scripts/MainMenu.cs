using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class MainMenu : MonoBehaviour
{
    public GameObject Settings;
    public GameObject MainUI;
    public TMP_InputField NicknameInput;
    public TMP_Text Scoreboard;
    public SavePlayer Players;

    
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Nickname"))
        {
            PlayerPrefs.SetString("Nickname", "Guest");
            PlayerPrefs.Save();
        }
        else
        {
            NicknameInput.text = PlayerPrefs.GetString("Nickname");
        }
        Scoreboard.text = $@"1. {Players.username[0]} {Players.score[0].ToString()}<br>2. {Players.username[1]} {Players.score[1].ToString()}<br>3. {Players.username[2]} {Players.score[2].ToString()}<br>4. {Players.username[3]} {Players.score[3].ToString()}<br>5. {Players.username[4]} {Players.score[4].ToString()}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }

    public void SettingsOn()
    {
        Settings.SetActive(true);
        MainUI.SetActive(false);
    }

    public void SettingsOff()
    {
        Settings.SetActive(false);
        MainUI.SetActive(true);
    }
    public void SetNickname()
    {
        PlayerPrefs.SetString("Nickname", NicknameInput.text);
        PlayerPrefs.Save();
        
    }
    

    public void exit()
    {
        Application.Quit();
    }
}
