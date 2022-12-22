using System;
using UnityEngine;

public class ChekWalker : MonoBehaviour
{

    public static Action<Type> onPulkaChek;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Pulka")
        {
            onPulkaChek?.Invoke(typeof(LoseState));
        }
    }
}