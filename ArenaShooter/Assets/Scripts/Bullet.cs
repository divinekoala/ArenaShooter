using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public int damage;
	public float moveSpeed;
	float timeAlive = 5f;


	void Update(){
		timeAlive -= Time.deltaTime;
		if(timeAlive <= 0)
			Destroy(gameObject);
	}

	void OnCollisionEnter2D(Collision2D other) {
		Destroy(gameObject);
		//Bullet Damage
	}

}
