using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legs : MonoBehaviour {
	private double hp;
	private int cost;
	private double speed;
	private int traction;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private int Traction{
		get{
			return traction;
		}
		set{
			traction = value;
		}
	}
	private double Speed{
		get{
			return speed;
		}
		set{
			speed = value;
		}
	}
	private int Cost{
		get{
			return cost;
		}
		set{
			cost = value;
		}
	}
	private double Hp{
		get{
			return hp;
		}
		set{
			hp = value;
		}
	}
}
