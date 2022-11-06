using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlokSpawnerScript : MonoBehaviour
{
    public BirdScript birdScript;
    public GameObject Bloklar;
    public float yukseklik;
    public float zaman;

    private void Start()
    {
        StartCoroutine(SpawnObject(zaman));  //spawnobject i baslatmak icin
    }

    public IEnumerator SpawnObject(float zaman)  // sureyle spawn edebilsin diye
    {
        while (!birdScript.isDead ) //kus olmediyse
        {
            // belirli yukseklikler arasinda random inip ciksin bloklar
            Instantiate(Bloklar, new Vector3(3, Random.Range(-yukseklik, yukseklik), 0), Quaternion.identity);
            yield return new WaitForSeconds(zaman);  //bloklari ayarlanan zamanda 1 spawnlamak icin 
        }
       
    }

}
