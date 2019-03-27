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
            //各パラメータの初期か.
            runner.running = false;
            runner.back = false;
            if (this.gameObject.name == "Home") runner.on_base = 0;
            if (this.gameObject.name == "Base") runner.on_base = 1;
            if (this.gameObject.name == "Base (1)") runner.on_base = 2;
            if (this.gameObject.name == "Base (2)") runner.on_base = 3;
            //ベースに接触したら走るのをやめる.
            if (runner.on_base!=0)runner.run = false;    //プレイヤーが最初ホームにいる時を除く.
            //if (runner.on_base == 4) runner.on_base = 0;
        }
    }
}
