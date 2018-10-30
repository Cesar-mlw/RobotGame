using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour {
	private float hp;
	private int cost;
	private float damage;
	private float dmgInterval= 1f;
	public Transform FirePoint;
	private bool onBoard = true;

	private bool shooting = false;
	public GameObject bullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		if(onBoard && !shooting){
			InvokeRepeating("Shoot", 1.0f, dmgInterval);
			shooting = true;
		}
	}
	void Shoot() {
		Instantiate(bullet, FirePoint.position, FirePoint.rotation);
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
