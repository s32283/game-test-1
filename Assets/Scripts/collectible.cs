using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
    { 
    //check if cokkision is okayer
    if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        //send info to plyer
        //Inventory playerInventory = null;
        //playerInventory = collision.gameObject.GetComponent<Inventory>();

    //delete collectable

    Destroy(gameObject);
    }
}
    