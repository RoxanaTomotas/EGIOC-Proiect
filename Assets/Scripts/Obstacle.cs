using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player; 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if(collision.tag == "Border")
        { 
            Destroy(collision.gameObject); 
        }
        else if(collision.tag == "Player")
        { 
            Destroy(player.gameObject);
            this.gameObject.SetActive(false);
        }
    }
}
