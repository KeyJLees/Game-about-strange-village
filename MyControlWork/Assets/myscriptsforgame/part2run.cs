using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class part2run : MonoBehaviour
{
    public GameObject player;
    public GameObject lightmy;
    public float dist;
    NavMeshAgent nav;
    public float radius = 10;
    private GameObject point;
    public string tag_point;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    
    }

   
    void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist > radius)
        {
            point = GameObject.FindGameObjectWithTag(tag_point);
            nav.enabled = true;
            // gameObject.GetComponent<Animator>().SetTrigger("Idle");
            gameObject.GetComponent<Animator>().SetTrigger("Walk");
            nav.SetDestination(point.transform.position);
        }
        if (((dist < radius) && (dist>3))||((dist< radius+5) &&(lightmy.GetComponent<Flashlight_PRO>().check==true)))
        {
            nav.enabled = true;
            nav.SetDestination(player.transform.position);
            gameObject.GetComponent<Animator>().SetTrigger("Run");
        }
        if (dist<=3)
            SceneManager.LoadScene("albertvariant");

    }
}
