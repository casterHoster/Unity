using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class RandomSpawner : MonoBehaviour
{
    [SerializeField] private Vector3[] _spawnPositions;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private float _spawnTime;

    private float _initialTime;

    private void Start()
    {
        _initialTime = _spawnTime;
    }

    private void Update()
    {
        if (Time.time >= _initialTime)
        {
            GameObject enemy = Instantiate(_enemy, _spawnPositions[UserUnits.GetRandomPosition(_spawnPositions)], Quaternion.identity);
            _initialTime += _spawnTime;
        }
    }

    public Vector3 GetDirrection()
    {
        return Vector3.right;
    }
}

public static class UserUnits
{
    public static int GetRandomPosition(Vector3[] spawnPositions)
    {
        int position = Random.Range(0, spawnPositions.Length);
        return position;  
    }
} 
