using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour {
	private float hp;

	private bool hasHead = false;
	private bool hasTorso = false;
	private bool hasLegs = false;
	private
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public bool HasHead{
		get{
			return hasHead;
		}
	}
	public bool HasTorso{
		get{
			return hasTorso;
		}
	}
	public bool HasLegs{
		get{
			return hasLegs;
		}
	}
}
