﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torso : MonoBehaviour {
	private bool onBoard = false;
	public GameManager gameManager;
	private Vector3 startingPosition;
	// Use this for initialization
	void Start () {
		// List<GameObject> parts = gameManager.SpwnedParts;
		// foreach (var item in parts){
		// 	if(item.GetComponent<Head>() != null){
		// 		Physics2D.IgnoreCollision(item.GetComponent<CircleCollider2D>(), gameObject.GetComponent<BoxCollider2D>());
		// 	}
		// }
		//THIS WILL ONLY WORK IF THERE'S A SINGLE PARTS OF EACH TYPE. CHANGE THIS FOR FUTURE BUILDS
	}
	
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnMouseDrag() {
		if(!onBoard){
			Vector3 currentPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
			Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentPoint);
			currentPosition.z = 0;
			transform.position = currentPosition;
			if(transform.position.x <= 1f || transform.position.y >= 1.74f){
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
	public bool OnBoard{
		get{
			return onBoard;
		}
	}
}
