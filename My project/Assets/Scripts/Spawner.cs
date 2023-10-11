using System.Collections;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _delay;

    private Vector3 _direction;

    private void Awake()
    {
        _direction = Vector3.right;
    }

    private void Start()
    {
        StartCoroutine(Creator());
    }

    private Transform GetRandomPoint(Transform[] points)
    {
        Transform point = points[Random.Range(0, points.Length)];
        return point;  
    }

    private IEnumerator Creator()
    {
        WaitForSeconds delay = new WaitForSeconds(_delay);

        while(true)
        {
            Enemy enemy = Instantiate(_enemy, GetRandomPoint(_points).position, Quaternion.identity);
            enemy.GetDirection(_direction);
            yield return delay; 
        }
    }
}

