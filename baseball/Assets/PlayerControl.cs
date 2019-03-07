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
        //移動.
        if (Input.GetKey(KeyCode.RightArrow))
        {//右に移動.
            this.transform.Translate(Vector3.right * 2.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {//左に移動.
            this.transform.Translate(Vector3.left* 2.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {//上に移動.
            this.transform.Translate(Vector3.up* 2.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {//下に移動.
            this.transform.Translate(Vector3.down* 2.0f * Time.deltaTime);
        }
        
    }

    private void FixedUpdate()
    {//常に固定間隔で呼ばれる.
        Vector3 Rotation = this.gameObject.transform.eulerAngles;

        //回転.
        if (Input.GetKey(KeyCode.D))
        {
            add_rotate = -10.0f;
            if (Rotation.y <= 60)
            {
                add_rotate = 0.0f;
            }
        }
        else
        {
            add_rotate = 10.0f;
            if (Rotation.y >= 300)
            {
                add_rotate = 0.0f;
            }
        }

        this.transform.Rotate(0.0f, add_rotate, 0.0f);
        Debug.Log(Rotation.y);
    }

    private void Batswing()
    {
        
    }
}
