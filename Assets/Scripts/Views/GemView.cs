using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemView : MonoBehaviour
{
    public Action onGrowndChek;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Pulka")
        {
            onGrowndChek?.Invoke();
            Destroy(gameObject);
        }
    }
}
