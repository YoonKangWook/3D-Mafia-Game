using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door3 : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool("IsOpen", true);
        }    
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool("IsOpen", false);
        }
    }
}
