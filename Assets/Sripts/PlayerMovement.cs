using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; 
namespace Sripts
{
   public class PlayerMovement : MonoBehaviour
   {
   
      public float speed = 5f;
      public GameObject bullet;
      public Transform startPoint;
      public float fireRate = 2f;
      private float _nextFire;
      private int _health = 3;
      public TextMeshProUGUI healthText;
   
      void Start()
      {
         UpdateHealthUI();
      }


      void Update()
      {
         Move();
         if (Time.time > _nextFire)
         {
            Shoot();
            _nextFire = Time.time + fireRate;
         }
      }

      public void Move()
      {
         float horizontal = Input.GetAxis("Horizontal");
         float vertical = Input.GetAxis("Vertical");
         Vector3 movement = new Vector3(vertical, 0, -horizontal);
         transform.Translate(movement * (speed * Time.deltaTime));
      }

      void Shoot()
      {
         Instantiate(bullet, startPoint.position, bullet.gameObject.transform.rotation);
      }
      void OnTriggerEnter(Collider other)
      {
         if (other.CompareTag("EnemyBullet"))
         {
            _health--;
            UpdateHealthUI();
            Destroy(other.gameObject);
            if (_health <= 0)
            {
               SceneManager.LoadScene("GameOver");
               Destroy(gameObject);
            }
         }
      }
      void UpdateHealthUI()
      {
         if (healthText != null)
         {
            healthText.text = "Health: " + _health;
         }
      }
   
   }
}
