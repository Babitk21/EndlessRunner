using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.touchCount>0)
        {
            print("touched");
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchPos.z = 0f;
            transform.position = touchPos;
        
        }
        */
        for(int i=0;i<Input.touchCount;i++)
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position);
            Debug.DrawRay(Vector3.zero, touchPos, Color.red);
        }
    }
}
