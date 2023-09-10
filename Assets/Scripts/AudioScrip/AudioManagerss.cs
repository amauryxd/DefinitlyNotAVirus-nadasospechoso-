using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManagerss : MonoBehaviour
{
    private AudioSource Gota;
    private AudioSource Notif;
    bool notifb = false;
    private AudioSource clickis;
    private string scenea;

    public GameObject son1, son2, son3, son4, sus, finxd;
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Start()
    {
        InvokeRepeating("gotaPlay", 20, 18);
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
        
        /*
         * Esto lo puse para separar pq no veo
         * 
         * 
         * 
         * 
         * */

        scenea = SceneManager.GetActiveScene().name;

        switch (scenea)
        {
            case "Game":
                break;
            case "Game2":
                son1.SetActive(true);
                son2.SetActive(true);
                break;
            case "Game3":
                son1.SetActive(false);
                son1.SetActive(false);
                son3.SetActive(true);
                son4.SetActive(true);
                break;
            case "Game4":
                son3.SetActive(false);
                son4.SetActive(false);
                sus.SetActive(true);
                break;
            case "GameOver":
                sus.SetActive(false);
                finxd.SetActive(true);
                break;
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
