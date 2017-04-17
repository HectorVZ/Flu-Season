using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour {

    //variable de tipo PlayerControler encargada del movimiento del personaje
    private PlayerController thePlayer;
    //variable de tipo CameraController encargada del seguimiento de la camara al personaje
    private CameraController theCamera;

	// Use this for initialization
    //encuentra los objetos de cada tipo playercontroller y cameracontroller y los asigna a la posicion que tiene el 
    //personaje actualmente
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        thePlayer.transform.position = transform.position;

        theCamera = FindObjectOfType<CameraController>();
        theCamera.transform.position = new Vector3(transform.position.x,transform.position.y,theCamera.transform.position.z);
    }

    // Update is called once per frame
    void Update () {
	}
}
