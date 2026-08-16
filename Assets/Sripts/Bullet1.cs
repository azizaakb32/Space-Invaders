using UnityEngine;

namespace Sripts
{
    public class Bullet1 : MonoBehaviour
    {
        public float lifeTime = 10f;
        [SerializeField] private float speed = 5f;   

        void Start()
        { 
            transform.rotation = Quaternion.Euler(0, 90, 0); 
            Destroy(gameObject, lifeTime); 
        }

        private void Update()
        {
            transform.Translate(transform.forward * (speed * Time.deltaTime));
        }

        void OnTriggerEnter(Collider collision)
        {
            if (collision.CompareTag("Player"))
            {
                Destroy(gameObject); 
            }
        }
    }
}


