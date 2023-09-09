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
       if(AumentarBarra.progAct > 0.98)
        {
            //poner sondio aca malevolo
            //nose mover algo en pantalla
            Invoke("cambiosce", tiempocambio);
        }
    }
    void cambiosce()
    {
        SceneManager.LoadScene(queesena);
    }
}
