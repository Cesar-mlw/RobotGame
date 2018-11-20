using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legs : MonoBehaviour {
	private float hp;
	private int cost;
	private Vector3 startingPosition;
	private float speed = 0.7f;
	private int traction = 2;
	public Transform trs;
	public Rigidbody2D rb;
	private bool onBoard = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		if(onBoard){
			gameObject.GetComponent<Rigidbody2D>().velocity = (transform.right * -1) * (speed/traction);
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
		}
	}
	void Stop(){
		rb.velocity = Vector2.zero;
	}

	public bool OnBoard{
		get{
			return onBoard;
		}
	}
}
