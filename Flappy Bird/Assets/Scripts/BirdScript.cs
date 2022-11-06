using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BirdScript : MonoBehaviour
{
    public float velocity = 1f;
    public Rigidbody2D rb2d;
    public bool isDead;  //kusun ölüp ölmediðini belirtecek
    public GameManager gm;
    public GameObject oyunSonu;
    public void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //ekrana tiklanirsa kusu ziplatmak icin
        {
            rb2d.velocity = Vector2.up * velocity; //havada kusu sicrat
        } 
    }    
    private void OnTriggerEnter2D(Collider2D collision) //bloklar arasindaki tetikleyici
    {
        if (collision.gameObject.name == "SkorSay") //2 blok arasindaki objenin adi
        {
            gm.skorGuncelle();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Death") //kus Death tag li alanlara degerse olecek.(Bloklar ve zemin)
        {
            isDead = true;
            Time.timeScale = 0;       //oyun duraklasin diye
            oyunSonu.SetActive(true); //kus oldugunde oyun sonu ekraný acilsin
        }
    }
}
