using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector2 _targetPosition;

    public void SetTargetPosition(Vector2 targetPosition)
        => _targetPosition = targetPosition;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);

        if ((Vector2)transform.position == _targetPosition)
            Destroy(gameObject);
    }
}