﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public delegate void OnUITouchEventDelegate(UITouchEvent ev,PointerEventData eventData, int status);
//IDragHandler 会导致scrollview的滑动失效 所以和UITouchEventWithMove分开使用
public class UITouchEvent: MonoBehaviour, IPointerUpHandler, IPointerDownHandler//, IDragHandler
{
    public const int STATUS_TOUCH_DOWN = 0;
    public const int STATUS_TOUCH_MOVE = 1;
    public const int STATUS_TOUCH_UP = 2;
    bool isTouchDown = false;
    public OnUITouchEventDelegate callBackTouch { get; set; }

    //相当于touchDown
    public void OnPointerDown(PointerEventData eventData)
    {
        if (callBackTouch != null)
        {
            callBackTouch(this,eventData, STATUS_TOUCH_DOWN);
        }

    }
    //相当于touchUp
    public void OnPointerUp(PointerEventData eventData)
    {
        if (callBackTouch != null)
        {
            callBackTouch(this,eventData, STATUS_TOUCH_UP);
        }
    }
 

}
