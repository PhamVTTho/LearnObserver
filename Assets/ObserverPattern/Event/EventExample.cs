using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventExample : MonoBehaviour
{
    public delegate void MyDelegate();//normal delegate
    public static event MyDelegate myEvent;//static Instance

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myEvent?.Invoke();
        }
    }

}
