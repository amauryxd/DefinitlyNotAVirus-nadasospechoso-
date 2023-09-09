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
    void Start()
    {
        Invoke("barrabarra", timepobarra);
        Invoke("popuspo", timepopopus);
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
}
