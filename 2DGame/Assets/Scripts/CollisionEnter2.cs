﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnter2 : MonoBehaviour
{
    public int a = 3;
    public GameObject bb;
    private IsTrue ee;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "3")
        {

            ee = bb.GetComponent<IsTrue>();
            ee.deger = ee.deger + 1;
        }
        Debug.Log(col.gameObject.name);

    }
   
}