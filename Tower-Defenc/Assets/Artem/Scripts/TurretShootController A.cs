using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TurretShootControllerA : MonoBehaviour
{
    [SerializeField] private Transform turretGun;
    private void Start()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {

            turretGun.localRotation = Quaternion.LookRotation(other.transform.position, other.transform.position);
        }
    }
}
