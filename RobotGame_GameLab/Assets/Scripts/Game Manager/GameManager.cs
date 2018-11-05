using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	private float[] SpawnPointsX = {2.58f, 3.38f, 1.61f};
	private float[] SpawnPointsY = {-2.6f, -1.75f, -0.74f, 0.21f, 1.01f};
	public GameObject[] parts;

	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftControl)){
			var part = Instantiate(parts[0], new Vector3(SpawnPointsX[Random.Range(0, SpawnPointsX.Length - 1)], SpawnPointsY[Random.Range(0, SpawnPointsY.Length - 1)], 0.05f), new Quaternion(0, 0, 0, 1));
			part.transform.parent = player.transform;
		}
	}

	public void Die(GameObject go) {
		Destroy(go);
		//This is where the death animations will be handled. This function will take the game object and verify its tag, activating the respective death animation
	}
}
