using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerControl : MonoBehaviour
{

    public bool run = false;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 Firstbase = new Vector3(0.0f, 2.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            run = true;
        }

    }

    private void FixedUpdate()
    {
        if (run) runner();
        
    }

    public void runner()
    {
        this.transform.Translate(Vector3.right * 0.1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        run = false;
        Debug.Log("当たった");
    }
}
