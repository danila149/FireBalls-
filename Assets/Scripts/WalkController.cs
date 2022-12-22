using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkController : MonoBehaviour
{
    [SerializeField] private Transform[] _point;
    [SerializeField] private Transform _def;
    private int _index = 0;

    private void Update()
    {
            Walk();
    }
    
    public void Walk()
    {
            if (_def.position == _point[_index].position && _index < _point.Length - 1)
            {
                _index++;
            }
            if (_index == _point.Length - 1)
            {
                _index = 0;
            }
            if (!(_def.position == _point[_index].position && _index < _point.Length - 1))
            {
            _def.position = Vector3.MoveTowards(_def.position, _point[_index].position, 16 * Time.deltaTime);
            }
        
    }
}
