using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 2f;
	public Rigidbody2D rb;

	public int damage = 100;
	void Start () {
		rb.velocity = (transform.right * -1) * speed;
	}

	void OnTriggerEnter2D(Collider2D hitInfo) {
		Enemy enemy = hitInfo.GetComponent<Enemy>();
		if(enemy != null){
			enemy.TakeDamage(damage);
		}
		Destroy(gameObject);
	}
}
