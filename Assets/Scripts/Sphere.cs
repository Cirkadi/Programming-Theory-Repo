using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : Formas
{
    public Text ThisIs;
    protected override void WhatIsThis()
    {
        ThisIs.text = "This is a sphere. The sphere of Polymorphism.";
    }
}

