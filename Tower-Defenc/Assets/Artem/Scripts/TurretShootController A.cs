using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class TurretShootControllerA : MonoBehaviour
{
    [SerializeField] private GameObject prefabBullet;
    [SerializeField] private Transform firePoint;
    [SerializeField] private SphereCollider collider;
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
            GameObject getBullet = Instantiate(prefabBullet, firePoint.position, Quaternion.identity);
            firePoint.transform.LookAt(_target.transform.position);

            Rigidbody rb = getBullet.GetComponent<Rigidbody>();
            rb.AddForce(firePoint.forward * 100f, ForceMode.Impulse);

            yield return new WaitForSeconds(cooldown);
        }
    }

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
    }
    #endregion

}
