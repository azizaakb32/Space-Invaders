using UnityEngine;
using UnityEngine.Serialization;

namespace Sripts
{
    public class GreyishEnemy : EnemyBase
    {
        [FormerlySerializedAs("_enemyHealth")] [SerializeField] private EnemyHealth enemyHealth;
        public void Start()
        {
         
            health = 3;
            reward = 5;
            enemyHealth.Initialize();
        }
    }
}
