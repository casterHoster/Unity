using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Target _target;

    private void Update()
    {
        transform.Translate(_target.transform.position * Time.deltaTime);
    }

    public Target GetTarget(Target target)
    {
        return _target = target;
    }
}