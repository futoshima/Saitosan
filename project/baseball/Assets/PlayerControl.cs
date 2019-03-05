using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float rotate = 0;
    // Start is called before the first frame update
    void Start()
    {
        
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

        //回転.
        if (Input.GetKey(KeyCode.D))
        {
            // this.transform.Rotate(0.0f, 50.0f * Time.deltaTime,0.0f);.
            rotate = 200.0f * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        this.transform.Rotate(0.0f, rotate, 0.0f);
    }
}
