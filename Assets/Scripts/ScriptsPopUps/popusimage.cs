using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popusimage : MonoBehaviour
{
    public GameObject popusimg;
    public Sprite[] splist;
    public Image fotos;
    bool act = false;
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Popupimg"))
        {
            popusimg = GameObject.FindGameObjectWithTag("Popupimg");
            fotos = popusimg.GetComponent<Image>();           
            if (!act)
            {
                fotos.sprite = splist[Random.Range(0, 3)];
                act = true;
            }
        }
        else
        {
            act = false;
        }
    }
}
