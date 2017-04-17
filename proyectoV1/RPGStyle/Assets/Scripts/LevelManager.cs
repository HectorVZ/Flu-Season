using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

    //variable de tipo transfor encargada del menu principal
    public Transform mainMenu;
    //variable de tipo transfor encargada del menu de opciones
    public Transform optionMenu;
    
    //metodo que carga un nuevo escenario dependiendo del nombre de este
     public void loadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    //metodo para cerrar la aplicacion
    public void QuitGame()
    {
        Application.Quit();
    }
    //metodo que abre el menu de opciones
    public void OptionMenu(bool clicked)
    {
        if (clicked == true)
        {
  
            optionMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            optionMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }
}
