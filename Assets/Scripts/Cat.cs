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

    public void FightDogs(Dog other)
    {
        float win = Random.Range(0f, 1f);

        if (win <= .5f) Debug.Log($"Win {other.name} from dogs!");
        else Debug.Log($"Win {this.name} from cats!");
    }
}