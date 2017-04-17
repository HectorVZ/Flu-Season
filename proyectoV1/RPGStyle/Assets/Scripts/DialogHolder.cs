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
	void Start () {
        //encuentra y asigna un objeto existente de tipo DialogManager
        dMAn = FindObjectOfType<DialogueManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //trigger o "disparador" que se acciona cuando se presiona barra espaciadora en la zona de dialogo de otro personaje
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
			
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //dMAn.ShowBox(dialogue);

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
}

