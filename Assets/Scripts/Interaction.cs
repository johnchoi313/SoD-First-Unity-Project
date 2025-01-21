using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject cube;
    public int integer = 1;
    public float decimalNumber = 1.0f;
    public bool yes = true;
    public bool no = false;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        //cube.transform.Rotate(0,decimalNumber * dt,0);
        
        if(Input.GetKey(KeyCode.A))
        {
            cube.transform.Translate(-decimalNumber * dt,0,0);   
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            cube.transform.Translate(0,integer,0);   
        }


    }
}
