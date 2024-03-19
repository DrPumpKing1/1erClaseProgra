using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Pet
{
    public Dog(string name) : base(name) 
    {
    
    }
    
    protected override void MakeSound()
    {
        Debug.Log("Guauh");
    }

    public Dog GiveBirth(string name)
    {
        return new Dog(name + ", son of " + this.name);
    }
}
