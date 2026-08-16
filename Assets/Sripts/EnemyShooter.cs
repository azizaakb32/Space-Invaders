using UnityEngine;

namespace Sripts
{
    public class EnemyShooter : MonoBehaviour
    {
        public GameObject bulletPrefab; 
        public Transform firePoint; 
        public float bulletSpeed = 5f;
    
        public void Shoot()
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            bullet.transform.position += transform.forward * (bulletSpeed * Time.deltaTime);
        }
   
    }
}


