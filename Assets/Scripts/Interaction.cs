using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interaction : MonoBehaviour
{
    public TMP_Text thistext;

    public GameObject cube;
    public int integer = 1;
    public float decimalNumber = 1.0f;
    public bool yes = true;
    public bool no = false;

    public void DoThisIfButtonPress(float degrees) 
    {
        cube.transform.Rotate(0,degrees,0);
        thistext.text = "numba = " + Random.Range(0,100);
    }


    // Start is called before the first frame update
    void Start()
    {
        thistext.text = "billy";
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            DoThisIfButtonPress(5.0f);
        }

        float dt = Time.deltaTime;
        //cube.transform.Rotate(0,decimalNumber * dt,0);
        if(Input.GetKey(KeyCode.A))
        {
            cube.transform.Translate(-decimalNumber * dt,0,0);   
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            cube.transform.Translate(0,integer,0);   
        }
    }
}
