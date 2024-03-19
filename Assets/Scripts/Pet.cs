using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet
{
    protected string name { get; private set; }

    public Pet(string name)
    {
        this.name = name;
    }
}
