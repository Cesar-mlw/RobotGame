using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legs : MonoBehaviour {
	private float hp;
	private int cost;
	private float speed = 0.7f;
	private int traction = 2;

	public Rigidbody2D rb;
	private bool onBoard = false;
	// Use this for initialization
	void Start () {
		rb.velocity = (transform.right * -1) * (speed/traction);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Walk() {

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
