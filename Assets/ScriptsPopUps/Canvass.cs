using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvass : MonoBehaviour
{
    public GameObject popus;
    public GameObject uwucavas;
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Popup"))
        {
            popus = GameObject.FindGameObjectWithTag("Popup");
            popus.transform.SetParent(uwucavas.transform);
        }
    }
}
