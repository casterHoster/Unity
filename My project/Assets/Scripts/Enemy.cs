using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Target _target;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }

    public Target GetTarget(Target target)
    {
        return _target = target;
    }
}