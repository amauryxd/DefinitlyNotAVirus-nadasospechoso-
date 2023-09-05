using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarBoton : MonoBehaviour
{

    public GameObject elB;

    void Update()
    {
        
        
       
    }
    public void clikDereho()
    {
        if (Input.GetMouseButtonDown(1))
        {
            elB.SetActive(true);
        }
    }
}
