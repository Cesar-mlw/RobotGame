using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	private float speed = 2f;
	public Rigidbody2D rb;
	private float dmgRange = -5f;
	private int damage = 100;
	
	private float InitialX;
	private float InitialY;
	void Start () {
		rb.velocity = (transform.right * -1) * speed;
		InitialX = rb.position.x;
		Physics2D.IgnoreCollision(GetComponent<BoxCollider2D>(), GetComponent<CircleCollider2D>());
	}
	private void FixedUpdate() {
		if(-InitialX + gameObject.transform.position.x < dmgRange){
			Destroy(gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D hitInfo) {
		Head enemy = hitInfo.GetComponent<Head>();
		if(enemy != null){
			if(enemy.tag != gameObject.transform.parent.tag && enemy.tag != "Bullet"){
				Debug.Log(enemy.tag.Equals(gameObject.transform.parent.tag));
				enemy.TakeDamage(damage);
			}
			else{
				return;
			}
		}
		else{
			return;
		}
		Destroy(gameObject);
	}
}
