using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class TurretShootControllerA : MonoBehaviour
{
    [SerializeField] private GameObject prefabBullet;
    [SerializeField] private Transform firePoint;
    [SerializeField] private SphereCollider collider;
    [SerializeField] private GameObject turretHead;

    [SerializeField] private float cooldown;
    [SerializeField] private float range;

    private GameObject _target;

    private void Start()
    {
        collider.radius = range;
    }
    IEnumerator OnFire()
    {
        while (prefabBullet != null)
        {            
            firePoint.transform.LookAt(_target.transform.position);           
            GameObject getBullet = Instantiate(prefabBullet, firePoint.position, Quaternion.identity);          

            Rigidbody rb = getBullet.GetComponent<Rigidbody>();
            rb.AddForce(firePoint.forward * 100f, ForceMode.Impulse);

            yield return new WaitForSeconds(cooldown);
        }
    }
    //private void LateUpdate()
    //{
    //    turretHead.transform.LookAt(_target.transform.position);
    //}

    #region GetTarget

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") &&
            _target == null)
        {
            _target = other.gameObject;
            StartCoroutine(OnFire());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") && _target != null)
        {
            _target = null;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") && _target == null)
        {
            _target = other.gameObject;
            StartCoroutine(OnFire());
        }
        if(_target != null)
        {
            turretHead.transform.LookAt(_target.transform.position);
        }
    }
    #endregion

}
