using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class backtomenu : MonoBehaviour
{
    public Button Back;
    void Start()
    {
        Back.onClick.AddListener(toMenu);
    }

    void toMenu()
    {
        SceneManager.LoadScene("mainmenu");
    }

}
