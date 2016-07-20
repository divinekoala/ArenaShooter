using UnityEngine;
using System.Collections;

public class Movement {

	public void Jump(float force, Rigidbody2D rBody){
		rBody.AddForce(Vector2.up*force, ForceMode2D.Impulse);
	}

	public void Move(float h, float force, Rigidbody2D rBody){
		rBody.velocity = new Vector2 (h * force * Time.deltaTime, rBody.velocity.y);
	}

	public void RotateToCursor(Vector2 cursor, GameObject targetToRotate){
		var objectPos = Camera.main.WorldToScreenPoint(targetToRotate.position);
		cursor.x -= objectPos.x;
		cursor.y -= objectPos.y;
		targetToRotate.LookAt(cursor);
		targetToRotate.position.z = 0;
	
	
//		Vector2 playerToMouse = cursor - (Vector2)targetToRotate.transform.position;
//
//		var newRotation = Quaternion.LookRotation(playerToMouse, Vector3.forward);
//		newRotation.x = 0;
//		newRotation.y = 0;
//		newRotation *= Quaternion.Euler(0,0,90);
//		targetToRotate.transform.rotation = newRotation;
		
	}

	public bool CharacterTurn(float cursorX, Transform transform, bool facingRight){
		if (cursorX < transform.position.x && facingRight)
			return Flip(facingRight, transform);
		else if (cursorX > transform.position.x && !facingRight)
			return Flip(facingRight, transform);

		return facingRight;
	}

	public bool Flip(bool facingRight, Transform transform){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
		return facingRight;
	}
}
