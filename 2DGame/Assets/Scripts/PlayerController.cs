using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;

    [SerializeField]
    Transform[] waypoints;
    [SerializeField]
    float moveSpeed = 2f;
    int wayPointIndex = 0;
    public GameObject bb;
    private IsTrue ee;
    





    void Start()
    {
        anim = GetComponent<Animator>();

        ee = bb.GetComponent<IsTrue>();
        transform.position = waypoints[wayPointIndex].transform.position;
       

    }

  
    void Update()
    {
        if ((Vector2)transform.position==(Vector2)waypoints[0].transform.position )
        {
            anim.SetBool("sag",true);
            anim.SetBool("sol", false);
            anim.SetBool("asagi", false);
            anim.SetBool("yukari", false);

        }
        if ((Vector2)transform.position == (Vector2)waypoints[1].transform.position)
        {
            anim.SetBool("sag", false);
            anim.SetBool("sol", false);
            anim.SetBool("asagi", true);
            anim.SetBool("yukari", false);

        }
        if ((Vector2)transform.position == (Vector2)waypoints[2].transform.position)
        {
            anim.SetBool("sag", true );
            anim.SetBool("sol", false);
            anim.SetBool("asagi", false);
            anim.SetBool("yukari",false);

        }

       

        if (wayPointIndex == waypoints.Length)
        {
            wayPointIndex = 0;
            Application.Quit();
        }
        if (ee.finish == true)
        {
            Move();
            if (wayPointIndex == waypoints.Length)
            {
                
                Application.Quit();
                wayPointIndex = 0;

            }


        }
      

    }

        void Move()
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[wayPointIndex].transform.position, moveSpeed * Time.deltaTime);
            if (transform.position == waypoints[wayPointIndex].transform.position)
            {
                wayPointIndex += 1;
            }

        }

    

}
  



