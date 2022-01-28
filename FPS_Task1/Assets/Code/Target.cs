using System;
using UnityEngine;

public class Target : MonoBehaviour
{
    public static event Action onTargetHit;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Bullet>())
        {
            if (onTargetHit != null) onTargetHit.Invoke();
            Destroy(other.gameObject);
        }
    }
}
