using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseGame : MonoBehaviour {

    //variable de tipo canvas la cual se encarga de contener el menu de pausa
    public Canvas canvas;


  

    // Update is called once per frame
    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausa();
        }
    }
    //metodo pausa que se encarga de dar continuidad al juego o pausarlo mostrando una ventana
    public void Pausa()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
    //metodo que carga un escenario dependiendo del nombre
    public void loadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
