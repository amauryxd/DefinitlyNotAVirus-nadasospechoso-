using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : MonoBehaviour
{
    [SerializeField] private GameObject easterEgg;
    [SerializeField] private GameObject wpp;
    [SerializeField] private GameObject text;

    public void EasterEggWpp()
    {
        wpp.SetActive(false);
        easterEgg.SetActive(true);
        text.SetActive(true);
    }

}
