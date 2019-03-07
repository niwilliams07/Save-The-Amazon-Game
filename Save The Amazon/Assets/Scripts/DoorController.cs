using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
    public Dialogue dialogue;
    public AudioSource notification;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            notification.Play();
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }

        if (other.gameObject.tag == "Screwdriver")
        {
           
            Destroy(this.gameObject);
            
        }
    }

}
