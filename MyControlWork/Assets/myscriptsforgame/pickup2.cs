using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pickup2 : MonoBehaviour
{
    public GameObject PLayer;
    public GameObject light1;
    public GameObject light2;
    public GameObject text;
    public GameObject trigger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "pick up")
        {
            text.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                light1.SetActive(false);
                light2.SetActive(true);
                text.SetActive(false);
                trigger.SetActive(false);
            }
        }
    }

}
