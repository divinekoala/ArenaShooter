using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	public int dexterity;
	public int strength;
	public int agility;

	public int moveSpeed;
	private int adjustedMoveSpeed;
	private float h;
	private bool facingRight = false;

	Rigidbody2D rBody;
	public float jumpHeight;
	Cursor cursor;

	bool grounded = false;
	public Transform groundcheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGound;

	public GameObject gunAim;
	Movement movement = new Movement();
	AdjustedPlayerStats aps = new AdjustedPlayerStats();

	Animator anim;

	void Awake(){
		rBody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		adjustedMoveSpeed = aps.AdjustedMoveSpeed(moveSpeed, agility);
	}

	void FixedUpdate () {

		grounded = Physics2D.OverlapCircle(groundcheck.position, groundRadius, whatIsGound);
		h = Input.GetAxisRaw("Horizontal");

		anim.SetFloat("Move", Mathf.Abs(h));

		movement.Move(h, adjustedMoveSpeed, rBody);

		Vector2 cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		facingRight = movement.CharacterTurn(cursor.x, this.transform, facingRight);
		movement.RotateToCursor(cursor, gunAim);

	}

	void Update() {
		if(Input.GetButtonDown("Jump") && grounded){
			movement.Jump(jumpHeight, rBody);
		}
	}

}
