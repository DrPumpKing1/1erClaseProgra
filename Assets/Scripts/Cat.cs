using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Pet
{
    public Cat(string name) : base(name)
    {
        
    }

    protected override void MakeSound()
    {
        Debug.Log("Meow");
    }
}
