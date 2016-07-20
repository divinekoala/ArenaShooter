using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public float fireRate;
	public float bulletSpray;
	public float reloadTime;

	float currentTimer;

	bool canShoot;

	public GameObject bullet;
	public Transform bulletSpawn;


	void Update(){
		if(Input.GetButton("Fire1") && canShoot){
			GameObject go = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation) as GameObject;
			Rigidbody2D rg = go.GetComponent<Rigidbody2D>();
			float bulletSpeed = go.GetComponent<Bullet>().moveSpeed;
			rg.AddForce(go.transform.forward * bulletSpeed);
			canShoot = false;
			currentTimer = fireRate;
		}

		currentTimer -= Time.deltaTime;
		if(currentTimer <= 0){
			currentTimer = 0;
			canShoot = true;
		}
	}

}
