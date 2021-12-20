using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelHareket : MonoBehaviour
{
    public float hiz;
    public float maxHiz;
    
    
     
    private void Start()
    {
        Destroy(gameObject, 6.5f);
        
    }
    
    void Update()
    {

        transform.position += Vector3.left * hiz * Time.deltaTime;

    }

}
