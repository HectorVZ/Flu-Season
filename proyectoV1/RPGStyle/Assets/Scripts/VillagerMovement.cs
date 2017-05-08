﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerMovement : MonoBehaviour 
{
    //variable que controla la velocidad de movimiento del personaje
    public float moveSpeed;
    // variable de tipo rigidbody encargada de que el objeto asignado con ella pueda colisionar
    private Rigidbody2D myRigidBody;
    //variable bool que se encarga de controlar si  la nube  esta en movimiento o no
    public bool isWalking;
    //variable que se encarga de el tiempo de caminata a la nube 
    public float walkTime;
    //variable que se encarga de el tiempo de espera a la nube 
    public float waitTime;
    //variable que se encarga de contar caminata a la nube 
    private float walkCounter;
    //variable que se encarga de dar direccion de caminata a la nube 
    //con valores de entre 0 y 3
    private int WalkDirection;
    //variable bool que se encarga de dar paso a la nube de si puede caminar o no
    public bool canMove;
    //objeto manager de dialogo
    private DialogueManager theDM;

    // Use this for initialization
    // ademas es el encargado de ejecutar el metodo choose direction
    public void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
        theDM = FindObjectOfType<DialogueManager>();

        
        walkCounter = walkTime;

        ChooseDirection();
        canMove = true;
	}

    // Update is called once per frame
    //se encarga de dar la caminata a la nube en una direccion aleatoria
    public void Update () {

        if (!theDM.dialogActive)
        {
            canMove=true;
        }

        if (!canMove)
        {
            myRigidBody.velocity = Vector2.zero;
            return;
        }

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
