using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Roket : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ziplamaGücü;
    public bool oldümü;   
    public ParticleSystem iz;
    public GameManager gm;
    public AudioSource music;
    
    
    void Start()
    {
        iz.Stop();
        Time.timeScale = 0;
        
    }   
    void Update()
    {      
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * ziplamaGücü;
            iz.Play();
            
            
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            iz.Stop();
        }      
        tekrarBaslat();
        oyunuBaslat();
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Score")
        {
            gm.Score();
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag== "Engel")
        {
            oldümü = true;
            Time.timeScale = 0;
          
        }
    }
    public void tekrarBaslat()
    {
        if(oldümü==true && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
    public void oyunuBaslat()
    {
        if(oldümü==false && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
        }
    }
   
    
}
