using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comojugar : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject image;
    void Start()
    {
            image.SetActive(false);
    }

 

    public void Trigger()
    {
        
        if(image.activeInHierarchy == false )
        {
            image.SetActive(true);
        }
        else
        {
             image.SetActive(false);
        }

    }
}
