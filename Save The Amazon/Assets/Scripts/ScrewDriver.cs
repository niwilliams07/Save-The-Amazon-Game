using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewDriver : MonoBehaviour {
    public Dialogue System;
    public AudioSource notification;
    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "Player")
        {
            notification.Play();
            FindObjectOfType<DialogueManager>().StartDialogue(System);
            other.gameObject.tag = "Screwdriver";
            Destroy(this.gameObject);
        }
    }

}

