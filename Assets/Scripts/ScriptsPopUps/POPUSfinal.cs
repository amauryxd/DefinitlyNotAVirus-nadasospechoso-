using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POPUSfinal : MonoBehaviour
{
    public GameObject spawnchido;
    // Update is called once per frame
    void Update()
    {
        if(AumentarBarra.progAct >= 0.9)
        {
            spawnchido.SetActive(true);
        }
    }
}
