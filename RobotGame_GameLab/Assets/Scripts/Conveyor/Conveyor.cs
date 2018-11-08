using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour {
	public GameManager gm;
	private List<GameObject> spwnedParts = new List<GameObject>();

	private float stoppingPoint = -2.33f;
	// Use this for initialization
	void Start () {
		InvokeRepeating("MovePartsOnConveyor", 1.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		spwnedParts = gm.SpwnedParts;
		StopParts();
	}

	void MovePartsOnConveyor(){
		if(spwnedParts.Count >= 0){
			foreach (var item in spwnedParts){
				item.GetComponent<Rigidbody2D>().velocity = (transform.up * -1) * 0.3f;
			}

		}
	}

	void StopParts(){
		float stoppingPoint = -2.33f;
		foreach (var item in spwnedParts){
			if(item.transform.position.y <= stoppingPoint){
				item.GetComponent<Rigidbody2D>().velocity *= 0;
			}
			stoppingPoint += 1.093f;
		}
	}
}
