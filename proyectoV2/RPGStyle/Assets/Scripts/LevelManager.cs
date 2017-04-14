using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

    public Transform mainMenu;
    public Transform optionMenu;
    

     public void loadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
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
