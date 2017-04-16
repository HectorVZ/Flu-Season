using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OpenMiniGame : MonoBehaviour {

    public string miniJuego;


    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
       
    }

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name == "player")
		{
			SceneManager.LoadScene(miniJuego);
		}
	}
}
