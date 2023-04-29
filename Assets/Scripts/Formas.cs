using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Formas : MonoBehaviour
{
    private Rigidbody formasRB;
    private int secondsToJump = 1;
    public Text greeting;
        
    void Start()
    {
        formasRB = GetComponent<Rigidbody>();
        StartCoroutine(WaitForJump());
    }      

    IEnumerator WaitForJump()
    {
        while (true)
        {
        yield return new WaitForSeconds(secondsToJump);
        // ABSTRACTION
        Move();
        }        
    }

    private void Move()
    {
        formasRB.AddForce(Vector3.up *5, ForceMode.Impulse);
    }

    private void OnMouseDown()
    {
        //ABSTRACTION
        GreetingPlayer();
        WhatIsThis();
    }

    private void GreetingPlayer()
    {
        greeting.text = "Hi, " + PlayerNameHandle.Instance.PlayerName + ".";
    }

    //POLYMORPHISM
    protected abstract void WhatIsThis();
}
