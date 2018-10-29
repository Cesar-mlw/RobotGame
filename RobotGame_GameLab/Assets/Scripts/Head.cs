using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour {
	private float hp;
	private int cost;
	private float damage;
	private float dmgInterval;
	private int dmgRange;
	public Transform FirePoint;
	private bool onBoard = false;

	public GameObject bullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(onBoard){
			InvokeRepeating("Shoot", 1f, dmgInterval);
		}
	}
	void Shoot() {
		Instantiate(bullet, FirePoint);
	}
	public int DmgRange{
		get{
			return dmgRange;
		}
		set{
			dmgRange = value;
		}
	}
	public float DmgInterval{
		get{
			return dmgInterval;
		}
		set{
			dmgInterval = value;
		}
	}
	public float Damage{
		get{
			return damage;
		}
		set{
			damage = value;
		}
	}
	public float Hp{
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
