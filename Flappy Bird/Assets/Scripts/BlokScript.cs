using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlokScript : MonoBehaviour
{
    public float hiz;  // bloklarin kusa gelme hizi

    public void Start()
    {
        Destroy(gameObject, 9); // bloklar 9 sn sonra silinsin asiri yukleme yapmasin
    }
    void FixedUpdate()
    {
        transform.position+=Vector3.left*hiz*Time.deltaTime;  
    }
}
