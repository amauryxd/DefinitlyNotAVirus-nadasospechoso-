using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy : MonoBehaviour
{
    [SerializeField]
    GameObject Popup;
    public void des()
    {
        Destroy(Popup);
    }
}
