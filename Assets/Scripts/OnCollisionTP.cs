using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionTP : MonoBehaviour
{
    public Rigidbody TP1;
    public Rigidbody TP2;
    public Rigidbody TP3;
    public Rigidbody TP4;
    public Rigidbody TP5;
    public Rigidbody TP6;
    public Rigidbody TP7;
    public Rigidbody TP8;
    public Rigidbody TP9;
    public Rigidbody TP10;
    public Rigidbody TP11;
    public Rigidbody TP12;
    public Rigidbody TP13;
    public Rigidbody TP14;
    public Rigidbody TP15;
   

    void Start()
    {
        TP1 = GetComponent<Rigidbody>();
        TP2 = GetComponent<Rigidbody>();
        TP3 = GetComponent<Rigidbody>();
        TP4 = GetComponent<Rigidbody>();
        TP5 = GetComponent<Rigidbody>();
        TP6 = GetComponent<Rigidbody>();
        TP7 = GetComponent<Rigidbody>();
        TP8 = GetComponent<Rigidbody>();
        TP9 = GetComponent<Rigidbody>();
        TP10 = GetComponent<Rigidbody>();
        TP11 = GetComponent<Rigidbody>();
        TP12 = GetComponent<Rigidbody>();
        TP13 = GetComponent<Rigidbody>();
        TP14 = GetComponent<Rigidbody>();
        TP15 = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision TP)
    {
        if(TP.gameObject.tag == "Interactable")
        {
            
            TP1.useGravity = true;
            TP2.useGravity = true;
            TP3.useGravity = true;
            TP4.useGravity = true;
            TP5.useGravity = true;
            TP6.useGravity = true;
            TP7.useGravity = true;
            TP8.useGravity = true;
            TP9.useGravity = true;
            TP10.useGravity = true;
            TP11.useGravity = true;
            TP12.useGravity = true;
            TP13.useGravity = true;
            TP14.useGravity = true;
            TP15.useGravity = true;
            
        }
    }
}
