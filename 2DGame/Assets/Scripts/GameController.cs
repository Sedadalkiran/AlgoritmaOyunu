using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Obje;
    public IsTrue kod;

    [SerializeField]
    public GameObject CText;
    public GameObject FailText;
    // Start is called before the first frame update
    void Start()
    {
        kod = Obje.GetComponent<IsTrue>();
        CText.SetActive(false);
        FailText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (kod.finish==true)
        {
            CText.SetActive(true);
        }

        if (kod.kaybettin == true)
        {
            FailText.SetActive(true);

        }
        
    }
}
