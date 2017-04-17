using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoHolderHistoria : MonoBehaviour {
	public string dialogue;
	private DialogueManager dMAn;

	public string[] dialogLines;

	// Use this for initialization
	void Start () {
		dMAn = FindObjectOfType<DialogueManager>();
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.name == "FondoHistoriaInicial")
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

			}
		}

	}
}
