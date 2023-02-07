using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class Attack : MonoBehaviour
{
    public Animator animator;
    private Animator anim;// キャラにアタッチされるアニメーターへの参照
    public GameObject rlangmo;
    int Attacking = 0;
    public TwoBoneIKConstraint rightHandConstraint;
    // Start is called before the first frame update
    void Start()
    {
        rlangmo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        SetTwoHandWeight();
    }
    public void AttackingEvent(int attack)
    {
        if(attack == 0)
        {
            Attacking = 0;
            rlangmo.SetActive(true);
        }
        if(attack == 1)
        {
            Attacking = 1;
            rlangmo.SetActive(false);
        }
    } 
    void SetTwoHandWeight()
    {
        rightHandConstraint.weight = animator.GetFloat("Right Hand Weight");
    }
}
