using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElminarObjeto : MonoBehaviour
{
    public GameObject elB;
    public void desaparecer() {
        elB.SetActive(false);
        gameObject.SetActive(false);
    }
}
