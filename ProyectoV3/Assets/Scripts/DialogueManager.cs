using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour {

    //variable de tipo gameObject
    public GameObject dBox;
    //variable de tipo text encargada de almacenar el dialogo
    public Text dText;
    //variable bool encargada de si el dialogo esta activado o no
    public bool dialogActive;
    // arreglo que almacenara las varias lineas de dialogo
    public string[] dialogLines;
    //variable que asignara la posicion del dialogo en el arreglo
    public int currentLine;
    //variable de tipo player controller que se encarga de el player
    private PlayerController thePlayer;

	// Use this for initialization
	void Start () {
        //asignacion a theplayer de un objeto encontrado tipo playercontroller
        thePlayer = FindObjectOfType<PlayerController>();
    
	}
	
	// Update is called once per frame
	void Update () {
        //cuando el bool dialogactive es verdadero y la barra espaciadora esta presionada se activa el if
        //y va pasando las lineas de dialogo
        if (dialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            currentLine++;
        }
        //cuando el contador alcance o supere el tamanio del arreglo se van a desactivar las ventanas
        //y el jugador se podra mover otra vez
        if (currentLine>=dialogLines.Length)
        {
            dBox.SetActive(false);
            dialogActive = false;
            currentLine = 0;
            thePlayer.canMove = true;
        }
        dText.text = dialogLines[currentLine];
    }
    // metodo que muestra caja de texto
    public void ShowBox(string dialog)
    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialog;
    }
    //metodo que muestra dialogo en caja de texto
    public void ShowDialog()
    {
        dialogActive = true;
        dBox.SetActive(true);
        thePlayer.canMove = false;
    }
}
