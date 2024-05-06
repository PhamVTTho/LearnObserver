using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTest : MonoBehaviour
{
    public DelegateControl.DelegateExample example;

    private void OnEnable()
    {
        DelegateControl.myStaticDelegate += Test001;
    }

    private void OnDisable()
    {
        DelegateControl.myStaticDelegate -= Test001;
    }

    void Test001()
    {
        Debug.Log("Test001 called");
    }
}