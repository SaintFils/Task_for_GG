using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailZone : MonoBehaviour
{
    public static event Action OnFailZoneEnter;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Bullet>())
        {
            if (OnFailZoneEnter != null) OnFailZoneEnter.Invoke();
            Destroy(other.gameObject);
        }
    }
}
