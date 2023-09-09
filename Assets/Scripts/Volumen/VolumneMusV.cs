using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumneMusV : MonoBehaviour
{
    public AudioMixer volmenMusV;

    public void VolSFX(float sliderV)
    {
        if (sliderV != 0)
        {
            volmenMusV.SetFloat("Musv", Mathf.Log10(sliderV) * 20);
        }
        else
        {
            volmenMusV.SetFloat("Musv", -60);
        }
    }
}
