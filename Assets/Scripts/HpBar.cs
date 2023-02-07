using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

namespace Hamood
{
    /// <summary>
    /// 这个脚本用于判断怪物攻击时角色血量与动画是否发生变化
    /// </summary>
    public class HpBar : MonoBehaviour
    {
        public bl_HUDText HUDRoot;//在这里，主要是关联HUDText      
        //血条の参照
        public Slider HP; 
        public TextMeshProUGUI HpText;
        public int Hptextint;
        // 玩家初始化
        private Animator anim;	
        public GameObject target;
        // 金币
        public TextMeshProUGUI jiuCaiHeZi;
        public int Coins;
        // Start is called before the first frame update
        void Start()
        {
            //血条の初始化
            HpText.text = "10000";
            HP.value = 1;
            Hptextint = 10000; 
            /// 玩家初始化
            anim = GetComponent<Animator>();
            anim.SetBool("Death",true); 
            /// 金币初始化
            Coins = 0;
            
        }

        // Update is called once per frame
        void Update()
        {
        }
        /// 怪物攻击事件
        public void OnTriggerExit(Collider collider)
        {
            if(collider.gameObject.tag == "Weapon")
            {
                HP.value = HP.value - 0.1f;
                Hptextint = Hptextint - 1000;
                Coins = Coins + 7;
                HUDRoot.NewText("-" + 1000, transform, Color.white, 1, 20f, 1, 0, bl_Guidance.Down);
                if(Hptextint <= 0)
                {
                    Hptextint = 0;
                    anim.SetBool("Death",false);
                }
                HpText.text = Hptextint.ToString();
                jiuCaiHeZi.text = Coins.ToString();
                anim.SetTrigger("Gethit");
            } 
        }

    }
}
