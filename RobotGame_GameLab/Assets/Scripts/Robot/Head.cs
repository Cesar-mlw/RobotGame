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
    public GameObject LegsPosition;
	public Transform FirePoint;
	private GameObject[] anchors = new GameObject[15];
	// Use this for initialization
	void Start () {
		// List<GameObject> parts = gameManager.SpwnedParts;
		// foreach (var item in parts){
		// 	if(item.GetComponent<Legs>() != null){
		// 		Physics2D.IgnoreCollision(item.GetComponent<PolygonCollider2D>(), gameObject.GetComponent<CircleCollider2D>());
		// 	}
		// 	else if(item.GetComponent<Torso>() != null){
		// 		Physics2D.IgnoreCollision(item.GetComponent<BoxCollider2D>(), gameObject.GetComponent<CircleCollider2D>());
		// 	}
		// 	else if(item.GetComponent<Head>() != null){
		// 		Physics2D.IgnoreCollision(item.GetComponent<CircleCollider2D>(), gameObject.GetComponent<CircleCollider2D>());
		// 	}
		// }
		//THIS WILL ONLY WORK IF THERE'S A SINGLE PARTS OF EACH TYPE. CHANGE THIS FOR FUTURE BUILDS
		anchors = GameObject.FindGameObjectsWithTag("Anchor"); // FIX THIS -> THIS SHOULD COME FROM THE GAME MANAGER, OR TRY TO MAKE THIS MORE EFFICIENT
	}

    // Update is called once per frame
    void FixedUpdate() {
        if (onBoard && !shooting) {
            InvokeRepeating("Shoot", 1.0f, dmgInterval);
            shooting = true;

        }
        if (onBoard) {
            gameObject.GetComponent<Rigidbody2D>().velocity *= 0;
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
			shooting = false;
		}
		else{
			transform.position = startingPosition;
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
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Leg")
        {
            Debug.Log("FUCK THIS SHIT");

        }
    }
}
