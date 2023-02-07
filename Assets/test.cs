using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject dude;
    public int showCount = 0;
    public int maxPlayerCount = 2;
    static int count = 0;
    static float lastTime = 0;
    private float timeSpan = 20.0f;///20秒来一只


    //注意这个例子灵活时间来生成对应的预制体。
    // Use this for initialization
    void Start () {
        //得到当前lastTime的相关的时间。（Time.time为目前游戏所进行的时间）
        lastTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //没有达到目标数量的时候，持续循环。
        if (count < maxPlayerCount)
        {
            //当前的时间如果超出所限定的时间范围。那么就生成对象（相当于游戏只要正在运行就继续执行）
            if ((Time.time - lastTime) > timeSpan)
            {
                if (dude != null)
                {
                    Instantiate(dude,this.transform.position, transform.rotation);
                }
                //更新相关的时间以及数量。
                lastTime = Time.time;
                ++count;
                //用于展示当前生产了多少对象
                showCount = count;
            }
        }
    }
   
}
