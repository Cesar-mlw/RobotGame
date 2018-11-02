using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject[] parts;

	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftControl)){
			var part = Instantiate(parts[0], new Vector3(2.58f, 0.29f, 0.05f), new Quaternion(0, 0, 0, 1));
			part.transform.parent = player.transform;
		}
	}

	public void Die(GameObject go) {
		Destroy(go);
		//This is where the death animations will be handled. This function will take the game object and verify its tag, activating the respective death animation
	}
}
