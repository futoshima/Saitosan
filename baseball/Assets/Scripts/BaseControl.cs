using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseControl : MonoBehaviour
{
    GameObject Runner;//Runnerが入る変数.

    RunnerControl runner;//RunnerControlが入る変数.

    // Start is called before the first frame update
    void Start()
    {
        Runner = GameObject.Find("Runner");//オブジェクトの名前から取得して変数に獲得.
        runner = Runner.GetComponent<RunnerControl>();//RunnerにあるRunnerControl を取得して変数に格納.
    }

    // Update is called once per frame
    void Update()
    {

    }

    //プレイヤーがベース上に来たら.
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //ベースに接触したら走るのをやめる.
            runner.run = false;
        }
        Debug.Log("run");
    }
}
