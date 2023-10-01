using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popusound : MonoBehaviour
{
    private AudioSource Notif;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("NOTIF"))
        {
            Notif = GameObject.FindGameObjectWithTag("NOTIF").GetComponent<AudioSource>();
            Notif.Play();
        }
    }
}
