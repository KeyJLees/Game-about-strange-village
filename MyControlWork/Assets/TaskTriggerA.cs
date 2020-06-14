using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskTriggerA : MonoBehaviour
{
    public Animator animator;
    void OnTriggerEnter(Collider ot)
    {
        if (ot.CompareTag("Player"))
        {
            animator.SetBool("task2", true);
        }
    }
}
