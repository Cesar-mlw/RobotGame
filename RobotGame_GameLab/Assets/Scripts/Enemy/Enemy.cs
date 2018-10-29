using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int health = 100;
	
	public void TakeDamage(int damage) {
		health -= damage;

		if(health <= 0) Die();
	}

	public void Die() {
		Destroy(gameObject);
	}
}
