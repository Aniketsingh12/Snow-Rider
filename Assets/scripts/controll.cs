using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controll : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float torque = 5f;
    [SerializeField] float basespeed = 20f;
    [SerializeField] float speedboost = 30f;
    Rigidbody2D rbdb;
    SurfaceEffector2D surface;
    bool canmove = true;
    void Start()
    {
        surface = FindObjectOfType<SurfaceEffector2D>();
        rbdb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canmove){
         speedup();
         boost();
        }
        

    }
    public void Stopped()
    {
        canmove= false; 
    }



    void boost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surface.speed = speedboost;
        }
        else
        {
            surface.speed = basespeed;
        }
       
    }

    void speedup()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rbdb.AddTorque(torque);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rbdb.AddTorque(-torque);
        }
    }
}
