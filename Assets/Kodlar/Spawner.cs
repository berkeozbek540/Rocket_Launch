using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Roket roket;
    public GameObject Engeller;
    public float yükseklik;

    

    private void Start()
    {
        StartCoroutine(Spawn());
    }
    public IEnumerator Spawn()
    {
        while (roket.oldümü==false)
        {           
            Instantiate(Engeller, new Vector3(3, Random.Range(-yükseklik, yükseklik),0f),Quaternion.identity);
            yield return new WaitForSeconds(1.8f);
            
        }
        
    }
}
