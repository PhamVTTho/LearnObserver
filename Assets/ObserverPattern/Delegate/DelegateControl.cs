using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateControl : MonoBehaviour
{
    //define the delegate
    public delegate void DelegateExample(); //simple
    public delegate int IReturnAnInt(); //return value
    public delegate void IHaveInputs(int number, string text);//parameter
    public delegate void MulticastDelegate();//Multicast Delegate

    //instance of the delegate
    public DelegateExample delegateExample;
    public IReturnAnInt returnAnInt;
    public IHaveInputs haveInputs;
    public MulticastDelegate multicastDelegate;

    // static instance
    public static DelegateExample myStaticDelegate;
    public static IReturnAnInt myStaticReturnValue;

    //
    int numberReturn = 0;

    private void OnEnable()
    {
        //subscribes funtion to the delegate
        numberReturn = 0;
        delegateExample = TestDelegate;
        returnAnInt = FunctionReurnInt;
        haveInputs = FunctionWithoutInput;
        //
        multicastDelegate += Func001;
        multicastDelegate += Func002;
        //
        myStaticDelegate += TestDelegate;
    }

    private void OnDisable()
    {
        multicastDelegate -= Func001;
        multicastDelegate -= Func002;
        //myStaticDelegate -= TestDelegate;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //check if there is a subscriber, if there is we invoke
            //delegateExample?.Invoke();
            //haveInputs?.Invoke(0, "test");
            //multicastDelegate.Invoke();
            myStaticDelegate?.Invoke();
        }
    }

    public void TestDelegate()
    {
        Debug.Log("TestDelegate() Called");
    }

    //Delegate Parameters & Return Values
    int FunctionReurnInt()
    {
        numberReturn++;
        return numberReturn;
    }

    void FunctionWithoutInput(int number, string text)
    {
        Debug.Log("Got number: " + number + " and text: " + text);
    }

    ////Multicast Delegate
    void Func001()
    {
        Debug.Log("Func001");
    }

    void Func002()
    {
        Debug.Log("Func002");
    }

}
