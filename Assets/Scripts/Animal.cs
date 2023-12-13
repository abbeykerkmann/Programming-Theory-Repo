using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    // ENCAPSULATION
    private float speed = 10.0f;
    public float Speed
    {
        get { return speed; }
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("Speed cannot be negative!");
            }
            else
            {
                speed = value;
            }
        }
    }

    public virtual void Run()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void Update()
    {
        Run();
    }

    // ABSTRACTION
    public abstract void Speak();
}
