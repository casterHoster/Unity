using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private Target[] _targets;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _delay;

    private void Start()
    {
        StartCoroutine(Creator());
    }

    private Transform GetRandomPoint(Transform[] points)
    {
        Transform point = points[Random.Range(0, points.Length)];
        return point;  
    }

    private Target GetRandomTarget(Target[] targets)
    {
        Target target = targets[Random.Range(0, targets.Length)];
        return target;
    }

    private IEnumerator Creator()
    {
        WaitForSeconds delay = new WaitForSeconds(_delay);

        while(true)
        {
            Enemy enemy = Instantiate(_enemy, GetRandomPoint(_points).position, Quaternion.identity);
            enemy.GetTarget(GetRandomTarget(_targets));
            yield return delay; 
        }
    }
}

