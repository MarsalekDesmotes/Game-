using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public astro_hareket BirdScript;
    public float fark;   
    public GameObject Borular;
    public float yEkseni;
<<<<<<< HEAD
    public float time;
    public float xEkseni,xEkseni2;
=======
    public bool isDead;
>>>>>>> 2e0525fd09245507c5ebe3e7cbd674b562889c90
    private void Start()
    {
        StartCoroutine(SpawnObject(time));
        
    }
   
   
    public IEnumerator SpawnObject(float time)
    {
        while(!BirdScript.isDead){

            Instantiate(Borular, new Vector3(Random.Range(xEkseni,xEkseni2), Random.Range(-yEkseni, yEkseni), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
            xEkseni +=fark;
            xEkseni2 +=fark;
            
        }
    }
}

