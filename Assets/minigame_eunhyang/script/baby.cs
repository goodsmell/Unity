using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baby : MonoBehaviour
{
    private Animator animator; 

    private void Awake(){
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            animator.SetBool("Looking", true);
        }
         if(Input.GetKeyDown(KeyCode.O)){
            animator.SetBool("Looking", false);
            animator.SetBool("Disgorge", true);
        }
        
    }
}
