using UnityEngine;

namespace Sripts
{
    public class EnemyHealth : MonoBehaviour
    {
        [SerializeField] private EnemyBase enemy;
        private int _health;

        public void Initialize()
        {
            _health = enemy.health;
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;
            if (_health <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Destroy(gameObject);
        }
    }
}