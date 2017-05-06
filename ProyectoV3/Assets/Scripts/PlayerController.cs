using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    //variable que controla la velocidad de movimiento del personaje
    public float moveSpeed;
    //variable encargada de la animacion del personaje
    private Animator anim;
    // variable de tipo rigidbody encargada de que el objeto asignado con ella pueda colisionar
    private Rigidbody2D myRigidBody;
    // variable de tipo rigidbody encargada de que el objeto asignado con ella pueda colisionar
    private Rigidbody miRigidBody;
    //variable bool que se encarga de decir si el personaje ya existe o no
    private static bool playerExist;
    //variable tipo bool que da movimiento al personaje
    public bool canMove;



    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>(); //inicializa la animacion   
        myRigidBody = GetComponent<Rigidbody2D>();


        //si el personaje no existe cambia la variable de playerexist a true para que quede asignada la variable
        if (!playerExist)
        {
            playerExist = true;
            //no destruye el objeto ya que aun no se repite
            DontDestroyOnLoad(transform.gameObject);
        } else{
            //destruye el objeto (player y maincam)ya que estos ya deben existir, por lo tanto sino se destruye
            //quedaria duplicado
            Destroy(gameObject);
        }
        canMove = true;
	}
	
	// Update is called once per frame
    //es el encargado de dar movimiento al personaje de forma horizontal y vertical
	void Update () {

        if (!canMove)
        {
            myRigidBody.velocity = Vector2.zero;
            return;
        }

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < 0.5f)
        {
            //transform.Translate(new Vector3( Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime,0f,0f));
            myRigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, myRigidBody.velocity.y);
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < 0.5f)
        {
            //transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);

        }
        if (Input.GetAxisRaw("Horizontal")< 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            myRigidBody.velocity= new Vector2(0f,myRigidBody.velocity.y);
        }
        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, 0f);

        }


        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));

    }


}
