using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticEventSubscriber : MonoBehaviour
{
    private void OnEnable()
    {
        EventExample.myEvent += MyFuntion;
    }

    private void OnDisable()
    {
        EventExample.myEvent -= MyFuntion;
    }

    void MyFuntion()
    {
        Debug.LogError("my funtion");
    }
}
