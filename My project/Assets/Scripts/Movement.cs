using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private RandomSpawner _spawner;

    private void Start()
    {
        _spawner.GetComponent<RandomSpawner>();
    }

    private void Update()
    {
        transform.Translate(_spawner.GetDirrection() * _speed * Time.deltaTime);
    }
}