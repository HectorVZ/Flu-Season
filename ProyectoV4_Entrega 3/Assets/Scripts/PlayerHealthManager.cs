using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

    //variables encargadas de la barra de salud del personaje
    public int playerMaxHealth;
    public int playerCurrentPlayerHealth;

	// Use this for initialization
	public void Start () {
        playerCurrentPlayerHealth = playerMaxHealth;
	}
	
	
}
