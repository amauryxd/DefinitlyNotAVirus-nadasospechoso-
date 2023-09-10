using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public float tiempocambio;
    public string queesena;
    void Update()
    {
        if (AumentarBarra.progAct >= 1)
        {
            SceneManager.LoadScene(queesena);
        }
    }
    
}
