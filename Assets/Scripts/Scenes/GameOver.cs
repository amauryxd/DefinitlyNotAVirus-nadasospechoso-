using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    
    void Update()
    {
        if (AumentarBarra.progAct > 0.99)
        {
            Debug.Log("Perdiste");
            //SceneManager.LoadScene("GameOver");
        }
    }
}
