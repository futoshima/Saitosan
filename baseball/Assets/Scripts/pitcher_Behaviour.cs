using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitcher_Behaviour : MonoBehaviour
{

   // public limitMove LimitMove;

    public float speed=2;

    float vx=0;

    int limit = 1;
    float max_X;
    float min_X;

    public string playername;
    public float limit_X = 50;


    Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {

        rbody = GetComponent<Rigidbody2D>();
        Vector3 tmp = GameObject.Find(playername).transform.position;

        max_X = tmp.x + limit_X;
        min_X = tmp.x - limit_X;

    }

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        if (Input.GetKey("left"))
        {
            vx = -speed;
        }
        if (Input.GetKey("right"))
        {
            vx = speed;
        }
    }
    void FixedUpdate()
    {
        Vector3 tmp = GameObject.Find(playername).transform.position;

        limit = 1;
        //Vector3 tmp = GameObject.Find(playername).transform.position;

        if (tmp.x > max_X)
        {
            limit = 3;
            //rbody.velocity = new Vector2(0, 0);
        }

        if (tmp.x < min_X)
        {
            limit = 2;
            //rbody.velocity = new Vector2(0, 0);
        }


        /* int lim = 1;
         lim = LimitMove.limit;
         // Debug.Log(lim);*/
        if (limit == 1)
        {
            this.transform.Translate(vx / 50, 0, 0);
        }
        else if (limit == 2)
        {
            this.transform.position=new Vector3(min_X,tmp.y, tmp.z);
            limit = 1;
        }
        else if (limit == 3)
        {
            this.transform.position = new Vector3(max_X, tmp.y, tmp.z);
            limit = 1;
        }



    }
}
