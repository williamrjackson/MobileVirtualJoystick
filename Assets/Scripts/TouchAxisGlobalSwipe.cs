using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class TouchAxisGlobalSwipe : MonoBehaviour
{
    [SerializeField]
    TouchAxisCtrl swipe = null;
    public UnityEvent OnSwipeUp;
    public UnityEvent OnSwipeDown;
    public UnityEvent OnSwipeLeft;
    public UnityEvent OnSwipeRight;

    void Start()
    {
        swipe.OnSwipe += OnSwipe;
    }

    private void OnSwipe(TouchAxisCtrl.Direction direction)
    {
        switch (direction)
        {
            case TouchAxisCtrl.Direction.Up:
                if (OnSwipeUp != null)
                {
                    OnSwipeUp.Invoke();
                }
                break;
            case TouchAxisCtrl.Direction.Down:
                if (OnSwipeDown != null)
                {
                    OnSwipeDown.Invoke();
                }
                break;
            case TouchAxisCtrl.Direction.Right:
                if (OnSwipeRight != null)
                {
                    OnSwipeRight.Invoke();
                }
                break;
            default:
                if (OnSwipeLeft != null)
                {
                    OnSwipeLeft.Invoke();
                }
                break;
        }
    }
}
