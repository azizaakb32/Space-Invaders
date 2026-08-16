using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Sripts
{
    public class EnemyManager : MonoBehaviour
    {
        public float speed = 2f;
        public float fireRate = 1f;
        public EnemySpawner enemiesParent;

   

        void Start()
        {
            StartCoroutine(ShootRandomEnemy());
        }

        private void Update()
        {
            MoveForward();
        }


        void MoveForward()
        {
            enemiesParent.gameObject.transform.position += -Vector3.forward * (speed * Time.deltaTime);
        
        }

        IEnumerator ShootRandomEnemy()
        {
            while (true)
            {
                yield return new WaitForSeconds(fireRate);

                List<Transform> enemies = new List<Transform>();
                foreach (Transform enemy in enemiesParent.gameObject.transform)
                {
                    if (enemy.gameObject.activeInHierarchy)
                    {
                        enemies.Add(enemy);
                    }
                }

                if (enemies.Count > 0)
                {
                    Transform randomEnemy = enemies[Random.Range(0, enemies.Count)];
                    EnemyShooter enemyScript = randomEnemy.GetComponent<EnemyShooter>();
                    if (enemyScript != null)
                    {
                        enemyScript.Shoot();
                    }
                }
            }
        }
    }
}


