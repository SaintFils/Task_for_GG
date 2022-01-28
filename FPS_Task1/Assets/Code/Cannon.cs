using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private Bullet bulletPref;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Transform targetPoint;

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
        bullet.transform.LookAt(targetPoint);
        
    }
}
