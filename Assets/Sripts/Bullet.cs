using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sripts
{
   public class Bullet : MonoBehaviour
   {
      public int damage = 1;
      public float speed = 10f;
   

   
      private void Start()
      {
         transform.rotation = Quaternion.Euler(0, -90, 0);
      }

      private void Update()
      {
         transform.position += transform.right * (speed * Time.deltaTime);
      }

      void OnTriggerEnter(Collider other)
      {
         EnemyHealth enemy = other.GetComponent<EnemyHealth>();
         if (other.CompareTag("Enemy"))
         {
            if (enemy != null)
            {
               enemy.TakeDamage(damage); 
               Destroy(gameObject);
               if (GameObject.FindGameObjectsWithTag("Enemy").Length == 1)
               {
                  SceneManager.LoadScene("Win");
               }
            }
         }
      }
   }
}
