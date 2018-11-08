using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour {
	public GameManager gm;
	private List<GameObject> spwnedParts = new List<GameObject>();
	// Use this for initialization
	void Start () {
		InvokeRepeating("MovePartsOnConveyor", 1.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		spwnedParts = gm.SpwnedParts;
	}

	void MovePartsOnConveyor(){
		if(spwnedParts.Count >= 0){
			foreach (var item in spwnedParts){
				if(item.transform.position.y - 1.19f >= -2.33f){
					item.GetComponent<Rigidbody2D>().velocity = (transform.up * -1) * 0.3f;
				}
			}
		}
	}
}
