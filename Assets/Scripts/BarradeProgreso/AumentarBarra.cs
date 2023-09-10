using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AumentarBarra : MonoBehaviour
{
    public static float progAct;

    public float target = 0;

    public float speed = 0.5f;

    public Slider slider;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        progAct = 0;
    }
    void Start()
    {
        ActBarra(1);
        progAct = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < target) 
        {
            progAct += speed * Time.deltaTime;

            slider.value = progAct;
        }
        
    }

    public void ActBarra(float newProgress)
    {
        target = slider.value + newProgress;
    }
}
