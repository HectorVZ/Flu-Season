using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogHolder : MonoBehaviour {

    //variable que contendra el dialogo a mostrar
    public string dialogue;
    //objeto manager de dialogo
    private DialogueManager dMAn;
    //arreglo de lineas de dialogo
    public string[] dialogLines;

	// Use this for initialization
	public void Start () {
        //encuentra y asigna un objeto existente de tipo DialogManager
        dMAn = FindObjectOfType<DialogueManager>();
	}
	
	
    //trigger o "disparador" que se acciona cuando se presiona barra espaciadora en la zona de dialogo de otro personaje
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "player" && Input.GetKeyUp(KeyCode.Space))
        {
			

               

                if (!dMAn.dialogActive)
                {
                    dMAn.dialogLines = dialogLines;
                    dMAn.currentLine = 0;

                    dMAn.ShowDialog();
                }
                if (transform.parent.GetComponent<VillagerMovement>())
                {
                    transform.parent.GetComponent<VillagerMovement>().canMove = false;
                }

            
        }

    }
}

