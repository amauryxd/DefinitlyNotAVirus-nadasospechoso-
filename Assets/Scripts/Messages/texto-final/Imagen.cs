using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Imagen : MonoBehaviour
{
    public int acc;
    public Button btn1, btn2, btn3;

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
            btn1.interactable = false;
            btn2.interactable = false;
            btn3.interactable = false;
        }
        else
        {
             image.SetActive(false);
        }

    }
}
