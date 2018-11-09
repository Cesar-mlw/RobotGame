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
		StopParts();
	}

	void MovePartsOnConveyor(){
		if(spwnedParts.Count >= 0){
			foreach (var item in spwnedParts){
				item.GetComponent<Rigidbody2D>().velocity = (transform.up * -1) * 0.3f;
			}

		}
	}

	//Instead of creating a spwned parts array, get a parts on conveyor array and then switch it to the spwned parts array
	void StopParts(){
		float stoppingPoint = -2.33f;
		if(spwnedParts.Count > 0){
			foreach (var item in spwnedParts){
				stoppingPoint += 1.65f * spwnedParts.IndexOf(item);
				if(item.transform.position.y <= stoppingPoint){
					item.GetComponent<Rigidbody2D>().velocity *= 0;
				}

			}
		}
	}
}
