using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CambioPantalla : MonoBehaviour
{
    public GameObject paginaweb;
    public TMP_Dropdown dropxd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dropxd.value == 1)
        {
            paginaweb.SetActive(true);
        }
    }
}
