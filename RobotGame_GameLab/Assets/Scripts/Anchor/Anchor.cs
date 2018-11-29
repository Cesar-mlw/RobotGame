using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anchor : MonoBehaviour {

    public bool Occupied;
    public int count;
    public string ObjectTag;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        ObjectTag = collision.tag;
        Occupied = collision;
                
        if(Occupied == true){
            Debug.Log(ObjectTag + " On " + gameObject);
           
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Occupied = false;

        if (Occupied == false){
            Debug.Log("Free");
        }
    }
}
