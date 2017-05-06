using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour {

    //variable de tipo string que se va a encargar de capturar el nombre del nivel a cargar
    public string levelToLoad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //metodo que se encarga de cargar el escenario cuando el player colisione con el objeto cargado con este script
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "player")
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
