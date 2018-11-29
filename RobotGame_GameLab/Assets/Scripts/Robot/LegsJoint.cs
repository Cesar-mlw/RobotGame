using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegsJoint : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.tag == "Parts"){
            collision.collider.transform.SetParent(transform);
        }
    }

}
