using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newpoint : MonoBehaviour
{
    public GameObject new_point;

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Tograndmother")
        {
         
            gameObject.SetActive(false);
           
            new_point.SetActive(true);
        }
    }
}
