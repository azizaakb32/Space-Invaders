using UnityEngine;

namespace Sripts
{
    public class Yellowish : EnemyBase
    {
        [SerializeField] private EnemyHealth enemyHealth;
        public void Start()
        {
            health = 2;
            reward = 10;
            enemyHealth.Initialize();
        }
    }
}
