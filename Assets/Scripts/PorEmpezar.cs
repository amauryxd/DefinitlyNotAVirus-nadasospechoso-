using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorEmpezar : MonoBehaviour
{
    public float timepobarra;
    public float timepopopus;
    public GameObject barra;
    public GameObject popus;
    public Animator anim;
    public NextScene next;
    void Start()
    {
        Invoke("barrabarra", timepobarra);
        Invoke("popuspo", timepopopus);
        Invoke("rigoberto", 8f);
    }

    private void barrabarra()
    {
        anim.SetTrigger("Gstart");
        barra.SetActive(true);
    }
    private void popuspo()
    {
        popus.SetActive(true);
    }

    private void rigoberto()
    {

        next.enabled = true;
    }
}
