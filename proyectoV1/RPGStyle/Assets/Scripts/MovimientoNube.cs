using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNube : MonoBehaviour {

    //variable encargada de controlar la velocidad de la nube 
    public float moveSpeed;
    //objeto de tipo rigidBody2D que hace que el objeto pueda colisionar con el entorno
	private Rigidbody2D myRigidBody;
    //variable bool que se encarga de controlar si  la nube  esta en movimiento o no
    public bool isWalking;
    //variable que se encarga de el tiempo de caminata a la nube 
    public float walkTime;
    //variable que se encarga de el tiempo de espera a la nube 
    public float waitTime;
    //variable que se encarga de contar caminata a la nube 
    private float walkCounter;
    //variable que se encarga de contar el tiempo de espera a la nube 
    private float waitCounter;
    //variable que se encarga de dar direccion de caminata a la nube 
    //con valores de entre 0 y 3
    private int WalkDirection;
    //variable bool que se encarga de dar paso a la nube de si puede caminar o no
	public bool canMove;


	// Use this for initialization
    // ademas es el encargado de ejecutar el metodo choose direction
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D>();



		walkCounter = walkTime;

		ChooseDirection();
		canMove = true;
	}

	// Update is called once per frame
    //se encarga de dar la caminata a la nube en una direccion aleatoria
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

    //metodo encargado de dar direccion aleatoria a la nube
	public void ChooseDirection()
	{
		WalkDirection = Random.Range(0, 4);
		isWalking = true;
		walkCounter = walkTime;
	}
}
