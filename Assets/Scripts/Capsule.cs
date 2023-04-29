using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//INHERITANCE
public class Capsule : Formas
{
    public Text ThisIs;
    //POLYMORPHISM
    protected override void WhatIsThis()
    {
        ThisIs.text = "This is a capsule. The capsule of Encapsulation. *wink*";
    }
}
