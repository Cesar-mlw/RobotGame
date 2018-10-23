using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torso : MonoBehaviour {
	private double hp;
	private int cost;
	private SpecialEffect specialEfect;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public double Hp {
		get {
			return hp;
		}
		set {
			hp = value;
		}
	}
	public int Cost {
		get{
			return cost;
		}
		set {
			cost = value;
		}
	}
	public SpecialEffect SpecialEffect {
		get{
			return specialEfect;
		}
		set{
			specialEfect = value;
		}
	}
}
