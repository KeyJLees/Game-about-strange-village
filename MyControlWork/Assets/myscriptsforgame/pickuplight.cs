using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickuplight : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;
    public GameObject text;
    public GameObject trigger;
    void OnTriggerStay (Collider other)
    {
         text.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                light1.SetActive(false);
                light2.SetActive(true);
                trigger.SetActive(false);
            text.SetActive(false);
            

            }

        
    }

    void OnTriggerExit (Collider other)
    {
        text.SetActive(false);
    }

}
