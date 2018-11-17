using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject track;
	private float[] spX = {3.38f, 2.5f};
	private float[] spY = {0.98f, 0.1f, -0.77f, -1.7f, -2.7f};
	public GameObject[] parts;
	private bool equal = false;
	private List<GameObject> spwnedParts = new List<GameObject>();
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
			Vector3 spwnPoint = new Vector3(track.transform.position.x, track.transform.position.y + 1.5f, track.transform.position.z);
			var spwnedPart = Instantiate(part, spwnPoint, new Quaternion(0f, 0f, 0f, 1f), GameObject.FindGameObjectWithTag("Conveyor").transform);
			spwnedParts.Add(spwnedPart);
		}
		
	}
	public void Die(GameObject go) {
		Destroy(go);
		//This is where the death animations will be handled. This function will take the game object and verify its tag, activating the respective death animation
	}

	public void MovePartToBoard(GameObject part, Vector3 spwnPoint){
		spwnPoint.z = 0;
		bool ocuppied = false;
		foreach (var item in spwnedParts){
			Debug.Log(Vector3.Distance(item.transform.position, spwnPoint));
			if(Vector3.Distance(item.transform.position, spwnPoint) <= 5f){
				ocuppied = true;
				break;
			}
		}		
		if(!ocuppied){
			part.transform.position = spwnPoint;
			part.GetComponent<Head>().OnBoard = true;
		}
		else{
			Debug.Log("INVALID POSITION");
			
		}
	}
	public List<GameObject> SpwnedParts {
		get{
			return spwnedParts;
		}
	}
}
