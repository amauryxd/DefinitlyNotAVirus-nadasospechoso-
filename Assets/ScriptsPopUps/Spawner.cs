using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public enum Spawnstate {spawning, waiting, counting}
    [System.Serializable]
public class Wave
    {
        public string name;
        public Transform Popu;
        public int count;
        public float rate;

    }
    public Wave[] waves;
    private int nextwave = 0;
    public float timebetweebwaves = 60f;
    public float wavecountdown;
    private float searchcountdown = 1f;
    private Spawnstate state = Spawnstate.counting;
    private void Start()
    {
        wavecountdown = timebetweebwaves;
        
    }
    private void Update()
    {
        if(state == Spawnstate.waiting)
        { 
            if(!popuabierto())
            {

            }
            else
            {
                return;
            }
        }
        if(wavecountdown <= 0)
        {
            if(state != Spawnstate.spawning)
            {
                StartCoroutine(spawnwave(waves[nextwave]));
            }
            else
            {
                wavecountdown -= Time.deltaTime;
            }
        }
        bool popuabierto()
        {
            searchcountdown -= Time.deltaTime;
            if(searchcountdown <= 0f)
            {
                searchcountdown = 1f;
                if (GameObject.FindGameObjectWithTag("Popup") == null)
                {
                    return false;
                }
            }
          
            return true;
        }
    }
    
    IEnumerator spawnwave (Wave wave)
    {
        state = Spawnstate.spawning;
        for(int i = 0; i<wave.count; i++)
        {
            spawnpopup(wave.Popu);
            yield return new WaitForSeconds(1f / wave.rate);
        }
        state = Spawnstate.waiting;
        yield break;
    }
    void spawnpopup (Transform _popus)
    {
        Instantiate(_popus, transform.position, transform.rotation);
    }
}
