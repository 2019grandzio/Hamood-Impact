using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1;
    Animator anim;
    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
      anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
      float x = Input.GetAxis("Horizontal");
      float z = Input.GetAxis("Vertical");  

      move = new Vector3(x,0,z); 

      transform.LookAt(transform.position + new Vector3(x,0,z));
      transform.position += new Vector3(x,0,z) * speed * Time.deltaTime;
      
      if (Input.GetKeyDown(KeyCode.JoystickButton0)) //这里是攻击动作
        {
            anim.SetTrigger("Attack");
        }
      UpdateAnim();
    }

    void UpdateAnim()
    {
       anim.SetFloat("Speed",move.magnitude);

      
    }
}
