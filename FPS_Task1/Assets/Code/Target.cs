using System;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] wayPoints;
    [SerializeField] private float moveSpeed;

    private Transform _currentPoint;
    private int _pointIndex = 0;
    public static event Action OnTargetHit;

    private void Start()
    {
        _currentPoint = wayPoints[_pointIndex];
    }

    private void Update()
    {
        Move();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Bullet>())
        {
            if (OnTargetHit != null) OnTargetHit.Invoke();
            Destroy(other.gameObject);
        }
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _currentPoint.position, moveSpeed*Time.deltaTime);
        if (transform.position == _currentPoint.position)
        {
            _pointIndex++;
            
            if (_pointIndex >= wayPoints.Length)
            {
                _pointIndex = 0;
            }

            _currentPoint = wayPoints[_pointIndex];
        }
    }
}
