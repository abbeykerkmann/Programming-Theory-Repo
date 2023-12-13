using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    void Update()
    {
        Run();
        if(Input.GetKeyDown(KeyCode.B))
        {
            Speak();
        }
    }

    public override void Run()
    {
        Speed = 15.0f;
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
    
    public override void Speak()
    {
        Debug.Log("Dog says Bark!");
    }
}
