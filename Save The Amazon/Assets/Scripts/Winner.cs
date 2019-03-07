using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour
{
    public Dialogue Win;
    public AudioSource notification;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Winner")
        {
            notification.Play();
            FindObjectOfType<DialogueManager>().StartDialogue(Win);
        }
    }
}
