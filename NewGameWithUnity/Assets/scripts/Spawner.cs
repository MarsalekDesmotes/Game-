using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public astro_hareket BirdScript;
    public GameObject Borular;
    public float xEkseni;
    public float time;
    public float yEkseni;
    public bool isDead;
    private void Start()
    {
        StartCoroutine(SpawnObject(time));
        
    }
   
   
    public IEnumerator SpawnObject(float time)
    {
        while(!BirdScript.isDead){
             
            Instantiate(Borular, new Vector3(yEkseni+=10, Random.Range(-xEkseni, xEkseni), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
            
        }
    }
}

