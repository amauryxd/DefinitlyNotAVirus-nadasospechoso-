using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popusimage : MonoBehaviour
{
    public GameObject popusimg;
    public Sprite[] splist;
    public Image fotos;
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Popupimg"))
        {
            popusimg = GameObject.FindGameObjectWithTag("Popupimg");
            fotos = popusimg.GetComponent<Image>();
            fotos.sprite = splist[Random.Range(1, 4)];
        }
    }
}
