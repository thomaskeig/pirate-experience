using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1Behaviour : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // Play animation
            animator.SetTrigger("Open_Door1");
        }
    }

}
