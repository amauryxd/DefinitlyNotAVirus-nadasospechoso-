using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAroundxd : MonoBehaviour
{
    public float TpEmpezar;
    public float Trepeat;
    public GameObject archivo;
    private void Start()
    {
        InvokeRepeating("movepora", TpEmpezar, Trepeat);
    }

    private void movepora()
    {
        archivo.transform.position = new Vector2(Random.Range(151,1205), Random.Range(184,889));
        archivo.SetActive(true);
    }
}
