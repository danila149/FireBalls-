using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPancake
{
    private PancakeColisionScipt _pancakePrefab;
    private GemView _gemView;
    private int _pancakeCount;
    public SpawnPancake()
    {
        _pancakePrefab = Resources.Load<PancakeColisionScipt>("Prefabs/Puncake");
        _gemView = Resources.Load<GemView>("Prefabs/Gem");
    }

    public void Spawn(Transform _spawnPosition, Action onPuncakeDestroy= null, Action gemView = null)
    {
        _pancakeCount = UnityEngine.Random.Range(5, 20);
        for (int i = 0; i < _pancakeCount; i++)
        {
            PancakeColisionScipt pancakeInstanse = UnityEngine.Object.Instantiate(_pancakePrefab, _spawnPosition);
            pancakeInstanse.transform.position = new Vector3(0, i * _pancakePrefab.transform.localScale.y * 2, 0) + _spawnPosition.position;
            pancakeInstanse.OnPancekeRemove += onPuncakeDestroy;
        }
        GemView gemInstanse = UnityEngine.Object.Instantiate(_gemView, _spawnPosition);
        gemInstanse.transform.position = new Vector3(0, _pancakeCount * _gemView.transform.localScale.y * 2, 0) + _spawnPosition.position;
        gemInstanse.onGrowndChek += gemView;
    }
}


