using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popusfinaltimeout : MonoBehaviour
{
    public POPUSfinal popusss;
    void Start()
    {
        Invoke("popusfinal", 8f);
    }

    private void popusfinal()
    {
        popusss.enabled = true;
    }
}
