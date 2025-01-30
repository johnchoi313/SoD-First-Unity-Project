using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsController : MonoBehaviour
{
    public Transform transformToy;
    public float moveSpeed = 5;
    public float rotateSpeed = 5;

    public Rigidbody physicsToy;
    public float zVelocity = 1;
    public float torque = 1;
    public float jumpForce = 500;

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;

        //Transform demo
        if(Input.GetKey(KeyCode.R)) { transformToy.Translate(0,0,moveSpeed*dt,Space.World); }        
        if(Input.GetKey(KeyCode.F)) { transformToy.Translate(0,0,-moveSpeed*dt,Space.World); }        

        if(Input.GetKey(KeyCode.W)) { transformToy.Translate(0,0,moveSpeed*dt,Space.Self); }        
        if(Input.GetKey(KeyCode.S)) { transformToy.Translate(0,0,-moveSpeed*dt,Space.Self); }        
        
        if(Input.GetKey(KeyCode.A)) { transformToy.Rotate(0,rotateSpeed*dt,0); }        
        if(Input.GetKey(KeyCode.D)) { transformToy.Rotate(0,-rotateSpeed*dt,0); }        

        //Physics demo 
        if(Input.GetKey(KeyCode.Y)) { physicsToy.AddRelativeForce(0,0,zVelocity); }        
        if(Input.GetKey(KeyCode.H)) { physicsToy.AddRelativeForce(0,0,-zVelocity); }        

        if(Input.GetKey(KeyCode.I)) { physicsToy.AddForce(0,0,zVelocity); }        
        if(Input.GetKey(KeyCode.K)) { physicsToy.AddForce(0,0,-zVelocity); }        
        if(Input.GetKey(KeyCode.J)) { physicsToy.AddTorque(0,torque*dt,0); }        
        if(Input.GetKey(KeyCode.L)) { physicsToy.AddTorque(0,-torque*dt,0); }    

        if(Input.GetKeyDown(KeyCode.Space)) { physicsToy.AddForce(0,jumpForce,0); }
    }
}
