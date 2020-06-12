using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tobabfrommain : MonoBehaviour
{

    public GameObject PLayer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tograndmother")
        {
            SceneManager.LoadScene("albertvariant");
        }
    }
}
