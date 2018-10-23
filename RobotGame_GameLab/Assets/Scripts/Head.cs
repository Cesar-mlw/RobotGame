using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour {
	private double hp;
	private int cost;
	private double damage;
	private double dmgInterval;
	private int dmgRange;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	void Shoot() {
		
	}
	public int DmgRange{
		get{
			return dmgRange;
		}
		set{
			dmgRange = value;
		}
	}
	public double DmgInterval{
		get{
			return dmgInterval;
		}
		set{
			dmgInterval = value;
		}
	}
	public double Damage{
		get{
			return damage;
		}
		set{
			damage = value;
		}
	}
	public double Hp{
		get{
			return hp;
		}
		set{
			hp = value;
		}
	}
	public int Cost{
		get{
			return cost;
		}
		set{
			cost = value;
		}
	}
}
