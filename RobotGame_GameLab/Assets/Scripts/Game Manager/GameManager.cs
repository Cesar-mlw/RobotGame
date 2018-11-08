using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private Vector3 SpawnPoint;
	public GameObject[] parts;
	private bool equal = false;
	private List<GameObject> spwnedParts = new List<GameObject>();
	public GameObject player;
	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnPartIntoConveyor", 1f, 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SpawnPartIntoConveyor(/*string name*/){//Part selection will be random
		string name = "Head 1";
		GameObject part = null;
		foreach (var item in parts){
			if(item.name == name){
				part = item;
				break;
			}
		}
		if(part != null && spwnedParts.Count < 3){
			var spwnedPart = Instantiate(part, new Vector3(4.33f, 0.95f, 0f), new Quaternion(0f, 0f, 0f, 1f), GameObject.FindGameObjectWithTag("Conveyor").transform);
			spwnedParts.Add(spwnedPart);
		}
		
	}
	public void Die(GameObject go) {
		Destroy(go);
		//This is where the death animations will be handled. This function will take the game object and verify its tag, activating the respective death animation
	}

	public List<GameObject> SpwnedParts {
		get{
			return spwnedParts;
		}
	}
}
