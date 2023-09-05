using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AumentarBarra : MonoBehaviour
{
    public float barraFinal=1;
    public static float progAct=0;
    public float velAumento;
    public Slider slider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progAct = Mathf.Lerp(progAct, barraFinal, Time.deltaTime * velAumento);

        ActBarra();
    }

    public void ActBarra()
    {
        slider.value = progAct;
    }
}
