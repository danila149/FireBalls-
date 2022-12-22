using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private Transform _spawnPulkaPosition;

    public Transform SpawnPulkaPosition { get => _spawnPulkaPosition; }

    private void Update()
    {
        ReloadLevel();
    }

    private void ReloadLevel()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

}
