using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{

    public float visibleYHeight = 17.22732f;
    public float hiddenYHeight = 17.109f;
    private Vector3 myNewXYZPosition;
    public float speed = 4f;
    public float hideSpiderTimer = 1.5f;

    void Awake()
    {
        HideSpider();

        transform.localPosition = myNewXYZPosition;
    }

    
    void Update()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, myNewXYZPosition, Time.deltaTime * speed);
        
        hideSpiderTimer -= Time.deltaTime;
       
        if(hideSpiderTimer < 0)
        {
            HideSpider();
        }
    }

    public void HideSpider()
    {
        myNewXYZPosition = new Vector3(transform.localPosition.x, hiddenYHeight, transform.localPosition.z);
    }

    public void ShowSpider()
    {
        
        myNewXYZPosition = new Vector3(transform.localPosition.x, visibleYHeight,transform.localPosition.z);

        hideSpiderTimer = 1.5f;

    }
}