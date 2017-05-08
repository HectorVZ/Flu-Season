using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    //variable que se va a encargar de encontrar y seguir un gameObject (player)
    public GameObject followTarget;
    //variable que va a asignar la posicion de inicio del player
    private Vector3 targetPos;
    //variable encargada de la velocidad del player
    public float moveSpeed;
    //variable que identiica si la camara existe o no
    private static bool cameraExist;

	// Use this for initialization
	public void Start () {
        //condicion de existencia de la camara
        if (!cameraExist)
        {   
            //si esta existe entonces el objeto (player) no sera destruido
            cameraExist = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {   
            //si la camara ya existe el player sera destruido, de lo contrario el player se duplicara
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    public void Update () {
        //actualizacion de la posicion del personaje cuando aparezca en un punto de inicio
        targetPos = new Vector3 (followTarget.transform.position.x,followTarget.transform.position.y,transform.position.z);
        transform.position = Vector3.Lerp(transform.position,targetPos,moveSpeed*Time.deltaTime);
	}
}
