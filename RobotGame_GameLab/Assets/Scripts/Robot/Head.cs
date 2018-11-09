using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour {
	private float hp = 200;
	private Rigidbody2D rb;
	private int cost;
	private float dmgInterval= 1f;
	public Transform FirePoint;
	private bool onBoard = false;

	public GameManager gameManager;
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
		if(onBoard){
			gameObject.GetComponent<Rigidbody2D>().velocity *= 0;
		}
	}
	void Shoot() {
		Instantiate(bullet, FirePoint.position, FirePoint.rotation, gameObject.transform);
	}

	private void OnMouseOver() {
		if(Input.GetMouseButtonDown(0)){
			if(!onBoard)gameManager.MovePartToBoard(gameObject);
			else return;
		}	
	}
	public void TakeDamage(float damage){
		hp -= damage;
		if(hp <= 0){
			gameManager.Die(gameObject);
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

	public bool OnBoard{
		get{
			return onBoard;
		}
		set{
			onBoard = value;
		}
	}
}
