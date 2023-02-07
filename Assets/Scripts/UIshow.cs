using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIshow : MonoBehaviour
{
    private GameObject Y;
    private GameObject B;
    private GameObject A;
    private GameObject X;


    // Start is called before the first frame update
    void Start()
    {
        Y = GameObject.Find("YB");
        B = GameObject.Find("BB");
        A = GameObject.Find("AB");
        X = GameObject.Find("XB");   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2")) 
		{	
            B.SetActive(false);  
            Invoke("Active",0.5f);
		}
        if (Input.GetButtonDown("Fire3"))
		{	
           X.SetActive(false); 
           Invoke("Active",0.3f); 
		} 
        if (Input.GetButtonDown("Fire1"))
		{	
            A.SetActive(false);    
		}
        if (Input.GetButtonUp("Fire1"))
		{	
            A.SetActive(true);    
		}
        if (Input.GetButtonDown("Jump"))
		{	
            Y.SetActive(false); 
            Invoke("Active",0.3f); 
		}
         
    }
    void Active()
    {
        B.SetActive(true);  
        X.SetActive(true);    
        Y.SetActive(true);     
    }

}