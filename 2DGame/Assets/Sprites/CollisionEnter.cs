using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnter : MonoBehaviour
{
    public int a = 2;
    
    public GameObject bb;
    private IsTrue ee;
   
    // Start is called before the first frame update
    void Start()
    {
        ee = bb.GetComponent<IsTrue>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //void OnCollisionEnter2D(Collision2D tobje)
    //{
    //    //if (tobje.gameObject.tag =="1")
    //    //{
    //    //    print(a);
    //    //    artir();
    //    //}
    //    Debug.Log("Oldu");
    //}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "1")
        {
            artir();
        }
        Debug.Log(col.gameObject.name);

    }
    void artir()
    {
        ee.deger = ee.deger + 1;
    }
}
