using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Die(GameObject go) {
		Destroy(go);
		//This is where the death animations will be handled. This function will take the game object and verify its tag, activating the respective death animation
	}
}
