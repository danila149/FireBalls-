using System;
using UnityEngine;

public class SpawnDefence
{
    private WalkController _defensePrefab;
    public SpawnDefence()
    {
        _defensePrefab = Resources.Load<WalkController>("Prefabs/Defense");
    }

    public void Spawn(Transform _spawnPosition)
    {
        for (int i = 0; i < 1; i++)
        {
            WalkController pancakeInstanse = UnityEngine.Object.Instantiate(_defensePrefab, _spawnPosition);
            pancakeInstanse.transform.position = new Vector3(0, i * _defensePrefab.transform.localScale.y * 2, 0) + _spawnPosition.position;
        }

    }


}


