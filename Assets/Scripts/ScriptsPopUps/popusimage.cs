using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popusimage : MonoBehaviour
{
    public GameObject[] popusimg;
    public GameObject[] popusimg2;
    public GameObject[] popusimg3;
    public Sprite[] splist;
    public Image fotos;
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Popupimg"))
        {
            popusimg = GameObject.FindGameObjectsWithTag("Popupimg");
            foreach (GameObject popuimg in popusimg)
            {
                fotos = popuimg.GetComponent<Image>();
                    fotos.sprite = splist[0];
            }
        }
        if (GameObject.FindGameObjectWithTag("Popupimg2"))
        {
            popusimg2 = GameObject.FindGameObjectsWithTag("Popupimg2");
            foreach (GameObject popuimg2 in popusimg2)
            {
                fotos = popuimg2.GetComponent<Image>();
                    fotos.sprite = splist[1];

            }
        }
        if (GameObject.FindGameObjectWithTag("Popupimg3"))
        {
            popusimg3 = GameObject.FindGameObjectsWithTag("Popupimg3");
            foreach (GameObject popuimg3 in popusimg3)
            {
                fotos = popuimg3.GetComponent<Image>();

                    fotos.sprite = splist[2];

            }
        }
    }
}
