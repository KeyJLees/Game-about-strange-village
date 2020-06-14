using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasks : MonoBehaviour
{
    public bool Text1 = false;
    public bool Text2 = true;
    public bool Text3 = false;
    private bool ty = true;
    public Animator animator;

    void Update()
    {
        if (animator.GetBool("task") == true)
        {
            Text1 = false;
            Text2 = false;
            Text3 = true;
            ty = false;
        }

        if (animator.GetBool("task2") == true && ty)
        {
            Text2 = false;
            Text3 = false;
            Text1 = true;
        }
    }


    void OnGUI()
    {
        if (Text1 == true)
        {
            GUIStyle styleTime = new GUIStyle();
            styleTime.fontSize = 25;
            styleTime.normal.textColor = Color.yellow;
            GUI.Label(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 400, 80, 60), "Найдите способ попасть внутрь", styleTime);
        }

        if (Text2 == true)
        {
            GUIStyle styleTime = new GUIStyle();
            styleTime.fontSize = 25;
            styleTime.normal.textColor = Color.yellow;
            GUI.Label(new Rect(Screen.width / 2 - 70, Screen.height / 2 - 400, 80, 60), "Найдите свой дом", styleTime);
        }

        if (Text3 == true)
        {
            GUIStyle styleTime = new GUIStyle();
            styleTime.fontSize = 25;
            styleTime.normal.textColor = Color.yellow;
            GUI.Label(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 400, 80, 60), "Залезьте в дом через чердак", styleTime);
        }

    }


}
