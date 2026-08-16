using UnityEngine;

namespace Sripts
{
    public class Blue : EnemyBase
    {
        [SerializeField] private EnemyHealth enemyHealth;
        private void Start()
        {
            health = 1;
            reward = 5;
            if (enemyHealth)
            enemyHealth.Initialize();
        }
    }
}
