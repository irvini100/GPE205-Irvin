using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooter : MonoBehaviour
{
public Transform firePoint;
public GameObject bulletPrefab;
public int maxAmmo;
private int currentAmmo;
public float bulletforce = 10;
    // Start is called before the first frame update
    public void Start()
    {
        currentAmmo = maxAmmo;
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
     currentAmmo--;
     GameObject newbullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
     newbullet.GetComponent<Rigidbody>().AddForce(newbullet.transform.forward*bulletforce);
    }
}
