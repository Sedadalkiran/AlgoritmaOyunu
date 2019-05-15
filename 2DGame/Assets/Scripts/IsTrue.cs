using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTrue : MonoBehaviour
{
    public bool kaybettin = false;
    public bool finish = false;
    public int deger=0;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (deger > 3)
        {
            finish = true;
        print(deger);
        }
        if (deger < 4)
        {
            kaybettin = true;
            print("kaybettiniz.");
        }

    }


}
