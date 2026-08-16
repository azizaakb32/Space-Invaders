using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sripts
{
    public class SceneLoader : MonoBehaviour
    {
        public GameObject pauseMenu;
    
        public void StartGame()
        {
        
            SceneManager.LoadScene( "Scenes/Levels");
        }

    
        public void Quit()
        {
            Debug.Log("Quit");  
        }
        public void BackToMainMenu()
        {
        
            SceneManager.LoadScene( "Scenes/MainMenu");
        }
    
        public void ReStartGame()
        {

            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene( sceneIndex );
            
            Time.timeScale = 1;
            Debug.Log("Restart");
        
        }
    
        public void PauseButton()
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }

        public void Resume()
        {
            Time.timeScale = 1;
        }
        public void Level1()
        {
        
            SceneManager.LoadScene( "Scenes/Level1");
        }
        public void Level2()
        {
        
            SceneManager.LoadScene( "Scenes/Level2");
        }
        public void Level3()
        {
        
            SceneManager.LoadScene( "Scenes/Level3");
        }
        public void Level4()
        {
        
            SceneManager.LoadScene( "Scenes/Level4");
        }
        public void Level5()
        {
        
            SceneManager.LoadScene( "Scenes/Level5");
        }
        public void Level6()
        {
        
            SceneManager.LoadScene( "Scenes/Level6");
        }
    
    }
}
