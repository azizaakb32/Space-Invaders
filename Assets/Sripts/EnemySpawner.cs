using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Sripts
{
    public class EnemySpawner : MonoBehaviour
    {
        public GameObject[] enemyPrefabs; 
        public int enemiesPerRow = 5; 
        public float minX = -12f; 
        public float maxX = 12f; 
        public float zSpacing = 5f; 
        public float startZ = 60f; 
        private EnemyManager _enemyManager;

        [Obsolete("Obsolete")]
        void Start()
        {
            _enemyManager = FindObjectOfType<EnemyManager>(); 
            SpawnEnemies();
        }

        void SpawnEnemies()
        {
            for (int row = 0; row < 3; row++)
            {
                float zPosition = startZ - (row * zSpacing); 
                List<float> usedXPositions = new List<float>(); 

                for (int i = 0; i < enemiesPerRow; i++)
                {
                    float xPosition = GenerateUniqueX(usedXPositions, minX, maxX, 2.5f);
                    Vector3 spawnPosition = new Vector3(xPosition, 0f, zPosition);

                    GameObject enemy = Instantiate(
                        enemyPrefabs[Random.Range(0, enemyPrefabs.Length)], 
                        spawnPosition, 
                        Quaternion.identity, 
                        gameObject.transform
                    );

                    if (_enemyManager != null)
                    {
                        _enemyManager.enemiesParent = this; 
                    }
                }
            }
        }

        float GenerateUniqueX(List<float> usedXPositions, float minX, float maxX, float minSpacing)
        {
            float xPos;
            bool isValid;
            int attempts = 0;

            do
            {
                xPos = Random.Range(minX, maxX);
                isValid = true;

                foreach (float usedX in usedXPositions)
                {
                    if (Mathf.Abs(xPos - usedX) < minSpacing) 
                    {
                        isValid = false;
                        break;
                    }
                }

                attempts++;
            } while (!isValid && attempts < 100); 

            usedXPositions.Add(xPos);
            return xPos;
        }
    }
}




