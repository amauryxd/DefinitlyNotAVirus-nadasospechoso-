using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioUltimascena : MonoBehaviour
{
    private void Start()
    {
        InvokeRepeating("changec", 5f, 0.5f);
    }
    private void changec()
    {


          
            if (AumentarBarra.progAct >= 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        


    }
}
