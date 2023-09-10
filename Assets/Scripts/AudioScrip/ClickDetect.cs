using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetect : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2) && (GameObject.FindGameObjectWithTag("AUDIOMIX")))
        {
            AudioManagerss a;
            a = GameObject.FindGameObjectWithTag("AUDIOMIX").GetComponent<AudioManagerss>();
            a.clickSound();
        }
    }
}
