using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public Dialogue ScrewDriver;
    public Dialogue Enemy;
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
            notification.Play();
            FindObjectOfType<DialogueManager>().StartDialogue(ScrewDriver);
        }
        if(other.gameObject.tag == "Enemy")
        {
            notification.Play();
            FindObjectOfType<DialogueManager>().StartDialogue(Enemy);
        }
    }

}


