using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	private float[] SpawnPointsX = {2.58f, 3.38f, 1.61f};
	private float[] SpawnPointsY = {-2.6f, -1.75f, -0.74f, 0.21f, 1.01f};
	private float[] SpawnPointsXE = {-1.22f, -2.18f, -3.05f};

	private Vector3 SpawnPoint;
	public GameObject[] parts;
	private bool equal = false;
	private GameObject[] spwnedParts;
	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftControl)){
			spwnedParts = GameObject.FindGameObjectsWithTag("PlayerHead");
			SpawnPoint = new Vector3(SpawnPointsX[Random.Range(0, SpawnPointsX.Length)], SpawnPointsY[Random.Range(0, SpawnPointsY.Length)], 0f);
			foreach (var item in spwnedParts){
				if(item.transform.position == SpawnPoint){
					equal = true;
					break;
				}
				else{
					equal = false;
				}
			}
			if(!equal && spwnedParts.Length <= 15){
				var part = Instantiate(parts[0], SpawnPoint, new Quaternion(0, 0, 0, 1), player.transform);
				part.tag = "PlayerHead";
			}
		}
		if(Input.GetKeyDown(KeyCode.RightControl)){
			spwnedParts = GameObject.FindGameObjectsWithTag("EnemyHead");
			SpawnPoint = new Vector3(SpawnPointsXE[Random.Range(0, SpawnPointsXE.Length)], SpawnPointsY[Random.Range(0, SpawnPointsY.Length)], 0f);
			foreach (var item in spwnedParts){
				if(item.transform.position == SpawnPoint){
					equal = true;
					break;
				}
				else{
					equal = false;
				}
			}
			if(!equal && spwnedParts.Length <= 15){
				var part = Instantiate(parts[0], SpawnPoint, new Quaternion(0, 180, 0, 1), player.transform);
				part.tag = "EnemyHead";
			}
		}
	}

	public void Die(GameObject go) {
		Destroy(go);
		//This is where the death animations will be handled. This function will take the game object and verify its tag, activating the respective death animation
	}
}
