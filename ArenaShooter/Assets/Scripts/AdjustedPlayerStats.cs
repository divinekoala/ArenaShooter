using UnityEngine;
using System.Collections;

public class AdjustedPlayerStats {

	public int AdjustedHealth(int health, int strength){
		return health += (strength*5);
	}

	public float AdjustedAccuracy(float accuracy, int dexterity){
		return accuracy -= (dexterity/50);
	}

	public float AdjustedReloadSpeed(float reloadSpeed, int dexterity){
		return reloadSpeed -= (dexterity/20);
	}

	public int AdjustedMoveSpeed(int moveSpeed, int agility){
		return moveSpeed  += (agility*30);
	}

	public float AdjustedFireRate(float fireRate, int agility){
		return fireRate -= (agility/50);
	}
		
}
