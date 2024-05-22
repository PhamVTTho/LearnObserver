using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventExample : MonoBehaviour
{
    public delegate void MyDelegate();//normal delegate
    public delegate int DelegateReturnInt();
    public delegate void DelegateParameter(string name);
    //static Instance
    public static event MyDelegate myEvent;
    public static event DelegateReturnInt myStaticReturnValue;
    public static event DelegateParameter myDelegateParameter;

    private void OnEnable()
    {
        //myEvent = Test;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myEvent?.Invoke();
        }
    }

    void Test()
    {

    }

}
