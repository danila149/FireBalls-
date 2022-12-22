using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPulka
{
    private GameObject _pulka;

    public SpawnerPulka()
    {
        _pulka = Resources.Load<GameObject>("Prefabs/Pulka");
    }
    public void Spawn(PlayerView _playerView, int _power = 20)
    {
            GameObject pulkaInstance = Object.Instantiate(_pulka, _playerView.SpawnPulkaPosition);
            pulkaInstance.transform.position = _playerView.SpawnPulkaPosition.position;
            pulkaInstance.GetComponent<Rigidbody>().AddForce(Vector3.forward * _power, ForceMode.Impulse);
    }
}
