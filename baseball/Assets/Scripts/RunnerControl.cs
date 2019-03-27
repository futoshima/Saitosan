using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerControl : MonoBehaviour
{

    public int on_base = 0;//ランナーがどのベースにいるか.
    public float vx = 5.0f;
    public float vy = 5.0f;
    public bool run = false;//trueのとき走る.
    public bool running = false;//ベースを正しく周るため.
    public bool back = false;//trueのとき帰塁.

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(0.0f, 0.0f, 0.0f);//位置を初期化.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            //back = true;//帰塁.
            RMove();
        }
        if (Input.GetKey(KeyCode.A))
        {
            //back = false;
            Move();
        }
        if (run)
        {//走り出す.
            Runner();
        }

        Debug.Log(on_base);
    }

    //ベースに向かって走る.
    public void Runner()
    {
        switch (on_base)
        {
            case 1://1塁へ 右上.
                if(back) transform.Translate(-vx * Time.deltaTime, -vy * Time.deltaTime, 0.0f);
                else transform.Translate(vx * Time.deltaTime, vy * Time.deltaTime, 0.0f);
                break;
            case 2://2塁へ　左上.
                if (back) transform.Translate(vx * Time.deltaTime, -vy * Time.deltaTime, 0.0f);
                else transform.Translate(-vx * Time.deltaTime, vy * Time.deltaTime, 0.0f);

                break;
            case 3:
                //3塁へ　左下.
                if(back) transform.Translate(vx * Time.deltaTime, vy * Time.deltaTime, 0.0f);
                else transform.Translate(-vx * Time.deltaTime, -vy * Time.deltaTime, 0.0f);
                break;
            case 4:
                //ホームへ　右下.
                if(back) transform.Translate(-vx * Time.deltaTime, vy * Time.deltaTime, 0.0f);
                else transform.Translate(vx * Time.deltaTime, -vy * Time.deltaTime, 0.0f);
                break;
        }
    }

    //on_baseの増加 Aキーを押すことで動かしたい 進塁.
    public void Move()
    {//とりあえずは仮.
            if (Input.GetKey(KeyCode.RightArrow))
            {
            back = false;
                if (on_base == 0 && running == false)
                {
                    on_base = 1;//ホームから1塁への移動のみ.
                    run = true;
                    running = true;
                    //Debug.Log("run");
                }
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
            back = false;
            if (on_base == 1 && running == false)
                {
                on_base = 2;
                    run = true;
                    running = true;
                }
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
            back = false;
            if (on_base == 2 && running == false)
                {
                    on_base = 3;
                    run = true;
                    running = true;
                }
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
            back = false;
            if (on_base == 3 && running == false)
                {
                    on_base = 4;
                    run = true;
                    running = true;
                }
            }
    }

    //帰塁.
    public void RMove()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            /*if (on_base == 1 && back)
            {
                back = false;
            }*/
            back = true;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            /*if (on_base == 2 && back)
            {
                back = false;
            }*/
            back = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            /*if (on_base == 3 && back)
            {
                back = false;
            }*/
            back = true;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            /*if (on_base == 4 && back)
            {
                back = false;
            }*/
            back = true;
        }
    }

}
