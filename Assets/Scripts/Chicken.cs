using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public override void Speak()
    {
        Debug.Log("Chicken says Cluck!");
    }
}
