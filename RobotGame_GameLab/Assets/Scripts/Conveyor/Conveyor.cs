using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour {
	public GameManager gm;
	private List<GameObject> partsOnConveyor = new List<GameObject>();
	// Use this for initialization
	void Start () {
		InvokeRepeating("MovePartsOnConveyor", 1.0f, 2.0f);
	}
	void Update () {
		partsOnConveyor = gm.PartsOnConveyor;
		StopParts();
	}
	
	void MovePartsOnConveyor(){
		if(partsOnConveyor.Count >= 0){
			foreach (var item in partsOnConveyor){
				item.GetComponent<Rigidbody2D>().velocity = (transform.up * -1) * 0.3f;
			}

		}
	}
	void StopParts(){
		float stoppingPoint = -2.33f;
		if(partsOnConveyor.Count > 0){
			foreach (var item in partsOnConveyor){
				stoppingPoint += 1.65f * partsOnConveyor.IndexOf(item);
				if(item.transform.position.y <= stoppingPoint){
					item.GetComponent<Rigidbody2D>().velocity *= 0;
				}
			}
		}
	}
}
