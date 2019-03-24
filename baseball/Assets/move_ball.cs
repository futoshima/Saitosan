using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_ball : MonoBehaviour
{
    public float speed = 0;
    float b_vy;
    float b_vx;
    bool Thraw;
    public bool Hit;
    public GameObject gameobject;
    public Transform target;
    Vector3 offset=new Vector3(-3,0,0);

    // Start is called before the first frame update
    void Start()
    {

        //ball 内の  という変数を取得する
        b_vy = gameobject.GetComponent<ThrawBall_ByPitcher>().ball_vy;
        b_vx = gameobject.GetComponent<ThrawBall_ByPitcher>().ball_vx;

        Thraw = gameobject.GetComponent<ThrawBall_ByPitcher>().thraw;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Thraw = gameobject.GetComponent<ThrawBall_ByPitcher>().thraw;
        b_vx = gameobject.GetComponent<ThrawBall_ByPitcher>().ball_vx;
        b_vy = gameobject.GetComponent<ThrawBall_ByPitcher>().ball_vy;

        if(Thraw==false)
        {
            this.transform.position = target.position + offset;

        }
        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "batter")
            {
                b_vy = 0;
                Hit = true;
            }
        }
        this.transform.Translate(b_vx/200, b_vy / 50, 0);
    }
}
