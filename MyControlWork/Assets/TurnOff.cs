using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOff : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public void Turn()
    {
        gameObject.SetActive(false);
        Player1.SetActive(false);
        Player2.SetActive(true);
    }

}
