using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerss : MonoBehaviour
{
    private AudioSource Gota;
    private AudioSource Notif;
    bool notifb = false;
    private AudioSource clickis;
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Start()
    {
        InvokeRepeating("gotaPlay", Random.Range(0, 20), Random.Range(0, 20));
    }

    public void Update()
    {
        if (GameObject.FindGameObjectWithTag("GOTA"))
        {
            Gota = GameObject.FindGameObjectWithTag("GOTA").GetComponent<AudioSource>();
            
        }
        
        if (GameObject.FindGameObjectWithTag("NOTIF"))
        {
            Notif = GameObject.FindGameObjectWithTag("NOTIF").GetComponent<AudioSource>();
            if (GameObject.FindGameObjectWithTag("Popup"))
            {
                if (!notifb)
                {
                    Notif.Play();
                    notifb = true;
                }
                
            }
            else
            {
                notifb = false;
            }
        }   
        
        if (GameObject.FindGameObjectWithTag("CLICK"))
        {
            clickis = GameObject.FindGameObjectWithTag("CLICK").GetComponent<AudioSource>();
            
        }
        
    }

    public void gotaPlay()
    {
        Gota.Play();
    }
    public void clickSound()
    {
        clickis.Play();
    }
    
}
