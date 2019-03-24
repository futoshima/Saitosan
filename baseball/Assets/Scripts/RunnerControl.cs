using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerControl : MonoBehaviour
{

    public int on_base = 0;//ランナーがどのベースにいるか.
    public float vx = 5.0f;
    public float vy = 5.0f;
    public bool run = false;//trueのとき走る.

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(0.0f, 0.0f, 0.0f);//位置を初期化.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) Move();
        if (run)
        {
            Runner();
        }
    }

    //ベースに向かって走る.
    public void Runner()
    {
        switch (on_base)
        {
            case 1://1塁.
                transform.Translate(vx* Time.deltaTime, vy* Time.deltaTime, 0.0f);
                break;
            case 2://2塁.
                transform.Translate(-vx* Time.deltaTime, vy* Time.deltaTime, 0.0f);
                break;
            case 3://3塁.
                transform.Translate(-vx* Time.deltaTime, -vy* Time.deltaTime, 0.0f);
                break;
            case 4://ホーム.
                transform.Translate(vx* Time.deltaTime, -vy* Time.deltaTime, 0.0f);
                break;
        }
    }

    //on_baseの増加 Aキーを押すことで動かしたい.
    public void Move()
    {//とりあえずは仮.
        if (Input.GetKey(KeyCode.RightArrow))
        {
            on_base = 1;
            run = true;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            on_base = 2;
            run = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            on_base = 3;
            run = true;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            on_base = 4;
            run = true;
        }
    }

    //ベースの上を通過したら.
    public void On_Base()
    {

    }
}
