using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscenas : MonoBehaviour
{
    public void toGame()
    {
        //SceneManager.LoadScene("Game");
        Debug.Log("se supone que pasas al juego xd");
    }
    public void toCredits()
    {
        //SceneManager.LoadScene("creditos");
        Debug.Log("deberias pasar a creditos");
    }
    public void toExit()
    {
        Debug.Log("saliste del juego xd");
        Application.Quit();
    }
}
