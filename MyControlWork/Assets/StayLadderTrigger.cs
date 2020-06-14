using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayLadderTrigger : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public Animator animator;
    public bool Text;
    public bool k;
    public Dialog dialog;
    void OnTriggerEnter(Collider ot)
    {
        Text = true;
        k = true;
    }
    void OnTriggerStay(Collider ot)
    {
        if (Input.GetKeyDown(KeyCode.E) && k)
        {
            Text = false;
            k = false;
            if (animator.GetBool("outladder") == true)
            {
                animator.SetBool("stayladder", true);
                gameObject.SetActive(false);
                Player1.SetActive(false);
                Player2.SetActive(true);
            }
            else
            {
                FindObjectOfType<DialogManager>().StartDialog(dialog);
                animator.SetBool("task", true);
            }
        }
    }
    void OnTriggerExit(Collider ot)
    {
        Text = false;
    }

    void OnGUI()
    {
        if (Text == true)
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2 + 200, 80, 60), "Use E");
        }

    }
}
