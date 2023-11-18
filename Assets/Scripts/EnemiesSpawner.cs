using System.Collections;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemyTemplate;
    [SerializeField] private Vector2 _targetPosition;
    [SerializeField] private float _timeInSeconds;

    private void Start()
        => StartCoroutine(SpawnEnemy());

    private IEnumerator SpawnEnemy()
    {
        WaitForSeconds wait = new(_timeInSeconds);

        while (true)
        {
            EnemyMover enemy = Instantiate(_enemyTemplate, transform.position, Quaternion.identity);
            enemy.SetTargetPosition(_targetPosition);
            yield return wait;
        }
    }
}