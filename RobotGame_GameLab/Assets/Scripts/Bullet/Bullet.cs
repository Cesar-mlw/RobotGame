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
		InitialY = rb.position.y;
	}
	private void FixedUpdate() {
		if(-InitialX + gameObject.transform.position.x < dmgRange){
			Destroy(gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D hitInfo) {
		Enemy enemy = hitInfo.GetComponent<Enemy>();
		if(enemy != null){
			enemy.TakeDamage(damage);
		}
		Destroy(gameObject);
	}
}
