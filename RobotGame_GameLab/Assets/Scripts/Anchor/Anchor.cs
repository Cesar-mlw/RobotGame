using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anchor : MonoBehaviour {

	private bool occupied = false;
	void Start () {
		
	}
	
	void Update () {
		
	}

	public bool Occupied{
		get{
			return occupied;
		}
		set{
			occupied = value;
		}
	}
}
