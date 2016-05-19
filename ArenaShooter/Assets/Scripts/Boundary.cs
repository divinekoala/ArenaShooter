using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {
	
	void OnCollisionEnter2d(Collision2D other){
		if(other.gameObject.tag == "Player"){}
			
	}
}
