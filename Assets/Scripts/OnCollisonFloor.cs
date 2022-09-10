using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisonFloor : MonoBehaviour
{
    
    void Start()
    {
        GameController.Started = false;
    }

    
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision Floor)
    {
        if(Floor.gameObject.tag == "TP")
        {
            GameController.Started = true;
        }
    }
}
