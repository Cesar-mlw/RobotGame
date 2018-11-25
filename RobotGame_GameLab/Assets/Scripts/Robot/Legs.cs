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
	public GameManager gameManager;
	private bool onBoard = false;

	private GameObject[] anchors;
	void Start () {
		// List<GameObject> parts = gameManager.SpwnedParts;
		// foreach (var item in parts){
		// 	if(item.GetComponent<Legs>() != null){
		// 		Physics2D.IgnoreCollision(item.GetComponent<PolygonCollider2D>(), gameObject.GetComponent<PolygonCollider2D>());
		// 	}
		// 	else if(item.GetComponent<Torso>() != null){
		// 		Physics2D.IgnoreCollision(item.GetComponent<BoxCollider2D>(), gameObject.GetComponent<PolygonCollider2D>());
		// 	}
		// 	else if(item.GetComponent<Head>() != null){
		// 		Physics2D.IgnoreCollision(item.GetComponent<CircleCollider2D>(), gameObject.GetComponent<PolygonCollider2D>());
		// 	}
		// }
		//THIS WILL ONLY WORK IF THERE'S A SINGLE PARTS OF EACH TYPE. CHANGE THIS FOR FUTURE BUILDS
		anchors = GameObject.FindGameObjectsWithTag("Anchor"); // FIX THIS -> THIS SHOULD COME FROM THE GAME MANAGER, OR TRY TO MAKE THIS MORE EFFICIENT
	}

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
			Vector3 closest = currentPosition;
			float shortest = float.MaxValue;
			foreach (var item in anchors){
				float distance = Vector3.Distance(Camera.main.ScreenToWorldPoint(Input.mousePosition), item.transform.position);
				if(distance < shortest){
					shortest = distance;
					closest = item.transform.position;
				}
			}
			if(Camera.main.ScreenToWorldPoint(Input.mousePosition).x <= 1f || Camera.main.ScreenToWorldPoint(Input.mousePosition).y >= 1.74f){
				transform.position = startingPosition;
			}
			else if(Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 4.294f){
				closest.z = 0;
				transform.position = closest;
			}
			else{
				transform.position = currentPosition;
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
		else{
			transform.position = startingPosition;
		}
	}
	public bool OnBoard{
		get{
			return onBoard;
		}
	}
}
