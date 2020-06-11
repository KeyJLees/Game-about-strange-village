using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogText;
    public bool m_Jump;
    public bool end = true;

    public Animator animator;

    public Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }

    void Update()
    {
        m_Jump = Input.GetKeyDown(KeyCode.F);
        if (m_Jump && end == true)
        {
            DisplayNextSentence();
        }
    }


    public void StartDialog(Dialog dialog)
    {
        animator.SetBool("isOne", true);
        nameText.text = dialog.name;
        sentences.Clear();
        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();

    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialog();
            return;
        }
        end = false;
        string sentence = sentences.Dequeue();
        StartCoroutine(TypeSentence(sentence));

    }

    IEnumerator TypeSentence(string sentence) 
    {
        dialogText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return null;
        }
        end = true;

    }

    public void EndDialog()
    {
        animator.SetBool("isOne", false);
    }

}
