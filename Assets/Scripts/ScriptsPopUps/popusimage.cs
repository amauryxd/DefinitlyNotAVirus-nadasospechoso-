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
    bool act = false;
    bool act2 = false;
    bool act3 = false;
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
        else
        {
            act = false;
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
        else
        {
            act2 = false;
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
        else
        {
            act3 = false;
        }
    }
}
