using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera1 : MonoBehaviour
{
    private  Camera mainCamera;
    public float speed = 30;
    public const string LT = "LT";
    public const string RT = "RT";
    // Start is called before the first frame update
    void Start()
    {
       mainCamera = this.GetComponent<Camera>();    
    }

    // Update is called once per frame
    void Update()
    {
       float up = Input.GetAxis("LT");
       float down = Input.GetAxis("RT"); 
       if(mainCamera.fieldOfView<=100f){
            mainCamera.fieldOfView+= up * speed * Time.deltaTime;
       }
       if(mainCamera.fieldOfView>=50f){
            mainCamera.fieldOfView-= down * speed * Time.deltaTime;  
       }
    }
}
