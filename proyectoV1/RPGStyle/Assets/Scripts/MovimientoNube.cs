using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNube : MonoBehaviour {

	public float moveSpeed;

	private Rigidbody2D myRigidBody;

	public bool isWalking;

	public float walkTime;
	public float waitTime;
	private float walkCounter;
	private float waitCounter;

	private int WalkDirection;
	public bool canMove;


	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D>();


		waitCounter = waitTime;
		walkCounter = walkTime;

		ChooseDirection();
		canMove = true;
	}

	// Update is called once per frame
	void Update () {



		if (isWalking)
		{
			walkCounter -= Time.deltaTime;


			switch (WalkDirection)
			{
			case 0:
				myRigidBody.velocity = new Vector2(0f, moveSpeed);
				break;

			case 1:
				myRigidBody.velocity = new Vector2(moveSpeed,0f);
				break;

			case 2:
				myRigidBody.velocity = new Vector2(0f, -moveSpeed);
				break;

			case 3:
				myRigidBody.velocity = new Vector2(-moveSpeed, 0f);
				break;

			}

			if (walkCounter < 0)
			{
				isWalking = false;
				walkCounter = waitTime;
			}
		}
		else
		{
			walkCounter -= Time.deltaTime;
			myRigidBody.velocity = Vector2.zero;

			if (walkCounter < 0)
			{
				ChooseDirection();
			}
		}
	}

	public void ChooseDirection()
	{
		WalkDirection = Random.Range(0, 4);
		isWalking = true;
		walkCounter = walkTime;
	}
}
