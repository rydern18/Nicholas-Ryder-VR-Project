using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionSpider : MonoBehaviour
{
    public Spider _SpiderHider;
    public Spider _SpiderHider2;
    public Spider _SpiderHider3;
    public Spider _SpiderHider4;
    public Spider _SpiderHider5;
    public Spider _SpiderHider6;
    public Spider _SpiderHider7;
    public Spider _SpiderHider8;
    public Spider _SpiderHider9;
    




    public Rigidbody Hammer;

    public static float points = 0;
    void Start()
    {
        Hammer = GetComponent<Rigidbody>();
        
    }
    void Update()
    {
        Hammer.detectCollisions = true;
    }
    void OnCollisionEnter(Collision spider)
    {
        
        if (spider.gameObject.tag == "Spider")
        {
   
            points++;
           
            _SpiderHider.HideSpider();
            _SpiderHider2.HideSpider();
            _SpiderHider3.HideSpider();
            _SpiderHider4.HideSpider();
            _SpiderHider5.HideSpider();
            _SpiderHider6.HideSpider();
            _SpiderHider7.HideSpider();
            _SpiderHider8.HideSpider();
            _SpiderHider9.HideSpider();
        }
    }
    
}
