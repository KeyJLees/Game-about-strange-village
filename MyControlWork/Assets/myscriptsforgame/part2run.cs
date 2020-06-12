using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class part2run : MonoBehaviour
{
    public GameObject player;
    public float dist;
    NavMeshAgent nav;
    public float radius = 15;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    
    }

   
    void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist > radius)
        {
            nav.enabled = false;
            gameObject.GetComponent<Animator>().SetTrigger("Idle");
        }
        if ((dist < radius) && (dist>3))
        {
            nav.enabled = true;
            nav.SetDestination(player.transform.position);
            gameObject.GetComponent<Animator>().SetTrigger("Run");
        }
        if (dist<=3)
            SceneManager.LoadScene("albertvariant");

    }
}
