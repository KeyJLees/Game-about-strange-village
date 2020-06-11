using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator animator;
    void OnTriggerEnter(Collider ot)
    {
        if (ot.CompareTag("Player"))
        {
            animator.SetBool("Open", true);
        }
    }


}
