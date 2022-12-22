using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PancakeColisionScipt : MonoBehaviour
{
    public Action OnPancekeRemove;
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.transform.tag == "Pulka")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            OnPancekeRemove?.Invoke();
        }
    }
}
