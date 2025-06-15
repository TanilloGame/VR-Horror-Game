using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenuCanvas : MonoBehaviour
{

    public void StartNewGame()
    {
        SceneManager.LoadScene("Juego"); 
    }

    // Método para salir del juego
    public void QuitGame()
    {
        Debug.Log("Saliendo del juego");
        Application.Quit();
    }
}