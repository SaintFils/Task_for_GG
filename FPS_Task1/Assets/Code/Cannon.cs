using System;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private Bullet bulletPref;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Transform targetPoint;
    [SerializeField] private float depth = 10.0f;

    private Vector3 _mousePosition;
    private Vector3 _aim;
    private Camera _mainCamera;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Bullet bullet = Instantiate(bulletPref, shootPoint.position, Quaternion.identity);
        _mousePosition = Input.mousePosition;
        _mousePosition += _mainCamera.transform.forward * depth;
        _aim = _mainCamera.ScreenToWorldPoint(_mousePosition);
        bullet.transform.LookAt(_aim);
    }
}
