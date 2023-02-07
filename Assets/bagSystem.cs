using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bagSystem : MonoBehaviour
{
    private GameObject bagUI;
    // Start is called before the first frame update
    void Start()
    {
        bagUI = GameObject.Find("bagUI");
        bagUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
		{	
            bagUI.SetActive(true); 
		}
        if (Input.GetKey(KeyCode.UpArrow))
		{	
            bagUI.SetActive(false); 
		}
    }
}
