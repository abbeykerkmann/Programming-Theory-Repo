using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Moose : Animal
{
    void Update()
    {
        Run();
        if (Input.GetKeyDown(KeyCode.R))
        {
            Speak();
        }
    }

    // POLYMORPHISM
    public override void Run()
    {
        Speed = 20.0f;
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    // POLYMORPHISM
    public override void Speak()
    {
        Debug.Log("Moose says Roar!");
    }
}
