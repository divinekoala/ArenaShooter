using UnityEngine;
using System.Collections;

public class GunAimStickToPlayer : MonoBehaviour {

	public Transform player;

	
	// Update is called once per frame
	void Update () {
		this.transform.position = player.transform.position;
	}
}
