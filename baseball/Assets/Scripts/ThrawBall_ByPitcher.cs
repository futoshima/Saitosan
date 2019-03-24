using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrawBall_ByPitcher : MonoBehaviour
{

    public GameObject gameobject;
    public float ball_vy=0;
    public float ball_vx = 0;
    bool hit = false;
    public bool thraw = false;

    void Start()
    {

        hit = gameobject.GetComponent<move_ball>().Hit;
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.D) && hit != true)
        {
            ball_vy = -15;
            thraw = true;
        }

        if(hit)
        {
            ball_vy = 0;
            Debug.Log("hit");
        }

        if (Input.GetKey("right") && hit != true&&thraw)
        {
            ball_vx += 1;
        }
        if (Input.GetKey("left")&&hit!=true&&thraw)
        { 
            ball_vx -= 1;
        }

    }
}
