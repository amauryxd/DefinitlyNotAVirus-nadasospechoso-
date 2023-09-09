using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSFXControle : MonoBehaviour
{
    public AudioMixer volmenSFX;

    public void VolSFX(float sliderV)
    {
        if (sliderV != 0)
        {
            volmenSFX.SetFloat("SFXV", Mathf.Log10(sliderV) * 20);
        }
        else
        {
            volmenSFX.SetFloat("SFXV", -60);
        }
    }
}
