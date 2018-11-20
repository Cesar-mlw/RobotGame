using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour {
	private float hp = 200;
	private int cost;
	private float dmgInterval= 1f;
	private bool onBoard = false;
	private bool shooting = false;
	private Vector3 startingPosition;
	public GameManager gameManager;
	public GameObject bullet;
	public Transform FirePoint;
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
	private void OnMouseDrag() {
		if(!onBoard){
			Vector3 currentPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
			Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentPoint);
			currentPosition.z = 0;
			transform.position = currentPosition;
			if(transform.position.x <= 1f){
				transform.position = startingPosition;
			}
		}
		
	}
	private void OnMouseDown() {
		startingPosition = transform.position;
	}
	private void OnMouseUp() {
		if(transform.position.x <= 3.7f){
			onBoard = true;
			shooting = false;
		}
	}
	void Shoot() {
		Instantiate(bullet, FirePoint.position, FirePoint.rotation, gameObject.transform);
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
