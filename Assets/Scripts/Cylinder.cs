using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//INHERITANCE
public class Cylinder : Formas
{
    public Text ThisIs;
    //POLYMORPHISM
    protected override void WhatIsThis()
    {
        ThisIs.text = "This is a cylinder. The cylinder of Inheritance.";
    }
}
