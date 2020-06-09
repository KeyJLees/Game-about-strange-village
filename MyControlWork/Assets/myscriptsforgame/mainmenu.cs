using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class mainmenu : MonoBehaviour
{
    public Button Play;
    public Button Settings;
    public Button Exit;
    
    void Start()
    {
        Play.onClick.AddListener(toGame);
        Settings.onClick.AddListener(toSettings);
        Exit.onClick.AddListener(toExit);
    }

    void toExit()
    {
        Application.Quit();
    }

    void toGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void toSettings()
    {
        SceneManager.LoadScene("settings");
    }
}
