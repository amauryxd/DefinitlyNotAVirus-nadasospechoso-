using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botonactive : MonoBehaviour
{
    bool botwin=false;
    public Animator anim;
    public void onchange()
    {
        botwin = !botwin;
        anim.SetBool("active", botwin);
    }
}
