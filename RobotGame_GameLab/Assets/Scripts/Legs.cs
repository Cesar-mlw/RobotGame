using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legs : MonoBehaviour {
	private double hp;
	private int cost;
	private int speed;
	private double traction;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public double Hp{
		get{
			return hp;
		}
		set{
			hp = value;
		}
	}
	
	public int Cost {
		get{
			return cost;
		}
		set{
			cost = value;
		}
	}
	public int Speed{
		get{
			return speed;
		}
		set{
			speed = value;
		}
	}
	public double Traction{
		get{
			return traction;
		}
		set{
			traction = value;
		}
	}
}
