using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float tem_rotate = 0;//現在の回転角.
    public float rotate = -60;//回転角の初期位置.
    public float max_rotate = 60;//回転角の最大値.
    public float add_rotate;

    // Start is called before the first frame update
    void Start()
    {
        add_rotate = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void FixedUpdate()
    {//常に固定間隔で呼ばれる.

        //移動.
        if (Input.GetKey(KeyCode.RightArrow))
        {//右に移動.
            this.transform.position+=new Vector3(2.0f * Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {//左に移動.
            this.transform.position += new Vector3(-2.0f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {//上に移動.
            this.transform.position += new Vector3(0, 2.0f * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {//下に移動.
            this.transform.position += new Vector3(0, -2.0f * Time.deltaTime, 0);
        }

        Vector3 Rotation = this.gameObject.transform.eulerAngles;

        //回転.
        if (Input.GetKey(KeyCode.D))
        {
            add_rotate = 10.0f;
            if (Rotation.z>=325)
            {
                add_rotate = 0.0f;
            }
        }
        else
        {
            add_rotate = -10.0f;
            if (Rotation.z <= 45)
            {
                add_rotate = 0.0f;
            }
        }

        this.transform.Rotate(0.0f,0.0f, add_rotate);
    }

    private void Batswing()
    {
        
    }
}
