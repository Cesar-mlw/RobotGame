using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legs : MonoBehaviour {
	private float hp;
	private int cost;
	private float speed = 0.7f;
	private int traction = 2;
	public Transform trs;
	public Rigidbody2D rb;
	private bool onBoard = false;
	// Use this for initialization
	void Start () {
		rb.velocity = (transform.right * -1) * (speed/traction);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(trs.position.x <= -3.07)	{
			Stop();
		}
	}

	void Walk() {

	}
	void Stop(){
		rb.velocity = Vector2.zero;
	}
	private int Traction{
		get{
			return traction;
		}
		set{
			traction = value;
		}
	}
	private float Speed{
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
	private float Hp{
		get{
			return hp;
		}
		set{
			hp = value;
		}
	}
}
