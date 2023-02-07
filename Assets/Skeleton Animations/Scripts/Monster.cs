using System.Numerics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
namespace Hamood
{
public class Monster : MonoBehaviour
{
    /// 玩家
    private GameObject Player;
    /// 怪物导航及骨骼
    private NavMeshAgent agent;  
    Animator anim;
    /// 攻击范围
    float Attackarea = 1.2f;
    /// 行走速度
    float walk;
    int Attacking = 0;
    bool Death = true;
    /// 两把雾切初始化
    public GameObject rwuqie;
    // 血量初始化
    int Hptextint;
    // Start is called before the first frame update
    void Start()
    { 
    /// 导航初始化
    agent = this.GetComponent<NavMeshAgent>();
    /// 玩家初始化
    Player = GameObject.FindGameObjectWithTag("Player"); 
    /// 骨骼初始化
    anim = GetComponent<Animator>();
    // 隐藏造成伤害的雾切
    rwuqie.SetActive(false);
    // 血量初始化
    Hptextint = 5; 
    }
    // Update is called once per frame
    void Update()
    {
    /// 行走动画判断
    walk = agent.speed;
    anim.SetFloat ("Speed",walk);
    /// 获取玩家位置并导航
    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical"); 
    if(Death == true)
    {
        agent.SetDestination(Player.transform.position); 
    }else{
        agent.SetDestination(transform.position); 
    }
    
    float Distance = UnityEngine.Vector3.Distance(transform.position,Player.transform.position);
    /// 攻击判断
    if(Distance <= Attackarea)
        {
        anim.SetBool ("Attack",true);
        agent.SetDestination(transform.position);
        }else{
        anim.SetBool ("Attack",false);    
        } 
     
    }
    /// 扣血判断 
    public void AttackEvent(int attack)
    {
        if(attack == 0)
        {
            rwuqie.SetActive(true);
        }
        if(attack == 1)
        {
            rwuqie.SetActive(false);
        }
    } 
    /// 受击判断
    public void OnTriggerExit(Collider collider)
        {
            if(collider.gameObject.tag == "PlayerWeapon")
            {
                Hptextint = Hptextint - 1;///武器伤害为1，怪物血量为10
                anim.SetTrigger ("Gethit");
                if(Hptextint <= 0)
                {
                    Hptextint = 0;
                    anim.SetTrigger ("Attacked");

                    Death = false;
                }  
            } 
        }
    public void Disappear(int xiaoshi)
        {
            if(xiaoshi == 0)
            {
            }
            if(xiaoshi == 1)
            {
                Destroy(this.gameObject,1.0f);
            }
        }

}
}

