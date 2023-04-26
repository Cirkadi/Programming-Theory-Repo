using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : Formas
{
    public Text ThisIs;
    protected override void WhatIsThis()
    {
        ThisIs.text = "This is a cube. The cube of Abstraction.";
    }
}
