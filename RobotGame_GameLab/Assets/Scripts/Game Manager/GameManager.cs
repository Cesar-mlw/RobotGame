using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject track;
	public GameObject[] parts;
	private List<GameObject> spwnedParts = new List<GameObject>();
	private List<GameObject> partsOnConveyor = new List<GameObject>();
	private List<GameObject> partsOnBoard = new List<GameObject>();

	//Testing only

	private string[] names = {"Head 1", "Legs", "Torso"};
	void Start () {
		InvokeRepeating("SpawnPartIntoConveyor", 1f, 5f);
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void SpawnPartIntoConveyor(/*string name*/){//Part selection will be random
		if(partsOnConveyor.Count < 3){
			string name = names[Random.Range(0,2)];
			GameObject part = null;
			foreach (var item in parts){
				if(item.name == name){
					part = item;
					break;
				}
			}
			if(part != null){
				Vector3 spwnPoint = new Vector3(track.transform.position.x, track.transform.position.y + 1.5f, track.transform.position.z);
				var spwnedPart = Instantiate(part, spwnPoint, new Quaternion(0f, 0f, 0f, 1f), GameObject.FindGameObjectWithTag("Conveyor").transform);
				spwnedParts.Add(spwnedPart);
				partsOnConveyor.Add(spwnedPart);
			}
		}
		RemovePartsFromConveyor();
	}

	public void RemovePartsFromConveyor(){
		List<GameObject> remove = new List<GameObject>();
		foreach (var item in partsOnConveyor){
			if(item.GetComponent<Head>() != null){
				if(item.GetComponent<Head>().OnBoard){
					remove.Add(item);
				}
			}
			else if(item.GetComponent<Legs>() != null){
				if(item.GetComponent<Legs>().OnBoard){
					remove.Add(item);
				}
			}
			else if(item.GetComponent<Torso>() != null){
				if(item.GetComponent<Torso>().OnBoard){
					remove.Add(item);
				}
			}
			//we need to make a script to control if they are onBoard or not, kinda like a superclass
		}
		foreach (var item in remove){
			if(partsOnConveyor.Contains(item)){
				partsOnConveyor.Remove(item);
			}
		}
	}
	public void Die(GameObject go) {
		Destroy(go);
		if(spwnedParts.Contains(go)){
			spwnedParts.Remove(go);
		}
		//This is where the death animations will be handled. This function will take the game object and verify its tag, activating the respective death animation
	}
	//properties
	public List<GameObject> SpwnedParts {
		get{
			return spwnedParts;
		}
	}
	public List<GameObject> PartsOnConveyor {
		get {
			return partsOnConveyor;
		}
		set {
			partsOnConveyor = value;
		}
	}
	public GameObject[] Parts{
		get{
			return parts;
		}
	}
}
