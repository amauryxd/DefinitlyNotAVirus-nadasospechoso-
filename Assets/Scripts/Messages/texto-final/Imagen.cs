using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Imagen : MonoBehaviour
{
    public int acc;
    
    public GameObject image;
    void Start()
    {
            image.SetActive(false);
    }

 

    public void Trigger()
    {
        acc++;
        if(image.activeInHierarchy == false && acc >= 4) 
        {
            image.SetActive(true);
        }
        else
        {
             image.SetActive(false);
        }

    }
}
