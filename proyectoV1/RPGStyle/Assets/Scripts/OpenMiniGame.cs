using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OpenMiniGame : MonoBehaviour {

    //variable encargada de revisar el nombre del minijuego a abrir
    public string miniJuego;


 
    //metodo que abre una nueva escena cuando el personaje colisiona con un enemigo
	public void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name == "player")
		{
			SceneManager.LoadScene(miniJuego);
		}
	}
}
