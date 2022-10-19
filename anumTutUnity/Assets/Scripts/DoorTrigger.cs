using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Created by: Aidan Pohl
 * Created on 10/19/2022
 * 
 * modified:
 * 
 * Descrtiption: Trigger for door
 */
public class DoorTrigger : MonoBehaviour
{   
    public GameObject doorObj; //object that has the door to be animated
    Animator animator; //reference to animator controller of the door
    public string animParam; //the animator pramater
    // Start is called before the first frame update
    void Start()
    {
        animator = doorObj.GetComponent<Animator>();
        Debug.Log(animator.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ping!");
        if (other.tag == "Player")
        {
            Debug.Log("Player Ping!");
            animator.SetBool(animParam, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Ping!");
        if (other.tag == "Player")
        {
            Debug.Log("Player Ping!");
            animator.SetBool(animParam, false);
        }
    }
}
