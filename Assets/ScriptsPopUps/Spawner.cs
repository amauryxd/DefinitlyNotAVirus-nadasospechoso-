using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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

    public Transform[] spawnPoints;
    public float timebetweebwaves = 5f;
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
            
            if (!popuabierto())
            {
                popuscerrado();
                Debug.Log("wave compleated");
            }
            else
            {
                return;
            }
        }
        if (wavecountdown <= 0)
        {
            if (state != Spawnstate.spawning)
            {
                StartCoroutine(spawnwave(waves[nextwave]));
            }
        }
        else
        {
            wavecountdown -= Time.deltaTime;
        }
        

    }
    
    void popuscerrado()
    {
        
        state = Spawnstate.counting;
        wavecountdown = timebetweebwaves;

        if (nextwave + 1 > waves.Length - 1)
        {
            nextwave = 0;
        }
        else
        {
            nextwave++;
        }
       
    }
    bool popuabierto()
    {
        searchcountdown -= Time.deltaTime;
        if (searchcountdown <= 0f)
        {
           
            searchcountdown = 1f;
            if (GameObject.FindGameObjectWithTag("Popup") == null)
            {
                return false;
            }
        }
     
        return true;
    }

    IEnumerator spawnwave (Wave _wave)
    {
        Debug.Log("spawning wave" + _wave.name);
        state = Spawnstate.spawning;
        for(int i = 0; i< _wave.count; i++)
        {
            spawnpopup(_wave.Popu);
            yield return new WaitForSeconds(1f / _wave.rate);
        }
        state = Spawnstate.waiting;
        yield break;
    }
    void spawnpopup (Transform _popus)
    {
        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(_popus, _sp.position, _sp.rotation);
       
        Debug.Log("spawning enemy");
    }
}
