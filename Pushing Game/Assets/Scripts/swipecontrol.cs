using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeSystem : MonoBehaviour
{
    //Acees this to get output
    public TouchSystem Touch;

    //nothing in here ischange
    private Vector2 startTouchPostion;
    private Vector2 curentPostion;
    private Vector2 endtouchPostion;
    private bool stopTouch = false;

    //chnage it if nessarty
    public float swipeRange = 50;
    public float taprange = 10;

    public void Update()
    {
        Swipe();
    }


    public void Swipe()
    {
        //when player touch the screen
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPostion = Input.GetTouch(0).position;
        }
        //when player move there fingre
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            curentPostion = Input.GetTouch(0).position;
            Vector2 distace = curentPostion - startTouchPostion;
            if (!stopTouch)
            {

                if (distace.y < -swipeRange)
                {
                    stopTouch = true;
                    Touch = TouchSystem.SwipeDown;
                }
                else if (distace.y > swipeRange)
                {
                    stopTouch = true;
                    Touch = TouchSystem.SwipeUp;
                }
                else if (distace.x < -swipeRange)
                {
                    stopTouch = true;
                    Touch = TouchSystem.SwipeLeft;
                }
                else if (distace.x > swipeRange)
                {
                    stopTouch = true;
                    Touch = TouchSystem.SwipeRight;
                }
            }
        }
        //when player end there movement
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            stopTouch = false;
            endtouchPostion = Input.GetTouch(0).position;
            Vector2 distace = endtouchPostion - startTouchPostion;
            if (Mathf.Abs(distace.y) < taprange)
            {
                Touch = TouchSystem.Tap;
            }
        }
    }
}
public enum TouchSystem { SwipeLeft, SwipeRight, SwipeUp, SwipeDown, Tap }
