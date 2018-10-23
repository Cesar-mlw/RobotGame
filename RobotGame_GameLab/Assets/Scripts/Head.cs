using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour {


	private double hp;
	private int cost;
	private double damage;
	private double interval;
	//interval is the number of seconds that the object takes to initiate another damage giving action
	private int dmgRange;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Properties
	public double Hp {
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
	public double Damage {
		get{
			return damage;
		}
		set{
			damage = value;
		}
	}
	public double Interval {
		get{
			return interval;
		}
		set{
			interval = value;
		}
	}
	public int DmgRange {
		get{
			return dmgRange;
		}
		set{
			dmgRange = value;
		}
	}

}
