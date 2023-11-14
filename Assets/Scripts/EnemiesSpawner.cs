using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemyTemplate;
    [SerializeField] private float _timeInSeconds;

    private float _timer;

    private void Start()
        => _timer = _timeInSeconds;

    private void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            Instantiate(_enemyTemplate, transform);
            _timer = _timeInSeconds;
        }
    }
}