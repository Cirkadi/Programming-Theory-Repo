using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Formas : MonoBehaviour
{
    private Rigidbody formasRB;
    private int secondsToJump = 1;
    public Text greeting;

    // Start is called before the first frame update
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
        Move();
        }        
    }

    private void Move()
    {
        formasRB.AddForce(Vector3.up *5, ForceMode.Impulse);
    }

    private void OnMouseDown()
    {
        GreetingPlayer();
        WhatIsThis();
    }

    private void GreetingPlayer()
    {
        greeting.text = "Hi, " + PlayerNameHandle.Instance.PlayerName + ".";
    }

    protected abstract void WhatIsThis();
}
