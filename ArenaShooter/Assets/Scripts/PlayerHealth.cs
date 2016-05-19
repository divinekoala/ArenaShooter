using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth;
	private int adjustedHealth;
	public int currentHealth;


	void Awake(){
		AdjustedPlayerStats aps = new AdjustedPlayerStats();
		Character c = GetComponent<Character>();
		adjustedHealth = aps.AdjustedHealth(startingHealth, c.strength);
		currentHealth = adjustedHealth;
	}

	public void TakeDamage (int damage){
		currentHealth -= damage;
	}
}
