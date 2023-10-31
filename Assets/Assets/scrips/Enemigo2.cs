using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : MonoBehaviour
{
  
    public GameObject bulletPrefab;
    
    public float fireRate = 2f;  
    private float nextFireTime;

    void Start()
    {
        nextFireTime = Time.time + fireRate;
    }

    void Update()
    {
        if (Time.time > nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        GameObject bulletEnemy = Instantiate(bulletPrefab);
    }
}