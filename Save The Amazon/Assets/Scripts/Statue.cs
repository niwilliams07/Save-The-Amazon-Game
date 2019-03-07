using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour {
    public Dialogue dialogue;
    public AudioSource notification;
    public Material[] material;
    Renderer rend;
    
    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

    }

    private void OnTriggerEnter(Collider other)
    { 

        if (other.gameObject.tag == "Screwdriver")
        {
            rend.sharedMaterial = material[1];
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            GameObject[] walls = GameObject.FindGameObjectsWithTag("Walls");
            foreach (GameObject Enemy in enemies)
            {
                Destroy(Enemy);
            }
            foreach (GameObject Walls in walls)
            {
                Destroy(Walls);
            }
            notification.Play();
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            other.gameObject.tag = "Winner";
        }
    }

}
