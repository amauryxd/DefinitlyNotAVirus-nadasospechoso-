using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botonactive : MonoBehaviour
{
    public GameObject go;
    bool botwin=false;
    public Animator anim;
    public void onchange()
    {
        //Debug.Log(go.GetComponent<Comojugar>().image == true);
        botwin = !botwin;
        anim.SetBool("active", botwin);
        if (go.GetComponent<Comojugar>().image == true)
        {
            go.GetComponent<Comojugar>().image.SetActive(false);
        }
    }
}
