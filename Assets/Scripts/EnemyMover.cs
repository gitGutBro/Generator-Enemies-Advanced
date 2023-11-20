using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _targetPosition;

    public void SetTargetPosition(Transform targetPosition)
        => _targetPosition = targetPosition;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _targetPosition.position, _speed * Time.deltaTime);

        if (transform.position == _targetPosition.position)
            Destroy(gameObject);
    }
}