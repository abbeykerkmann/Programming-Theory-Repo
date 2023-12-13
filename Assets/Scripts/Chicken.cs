using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Chicken : Animal
{
    void Update()
    {
        Run();
        if (Input.GetKeyDown(KeyCode.C))
        {
            Speak();
        }
    }

    // POLYMORPHISM
    public override void Speak()
    {
        Debug.Log("Chicken says Cluck!");
    }
}
