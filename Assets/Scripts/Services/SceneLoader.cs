using UnityEngine.SceneManagement;

namespace Services
{
    public static class SceneLoader
    {
        private const string 
            _mainMenuID = "Menu",
            _gameSceneID = "Gameplay";

        public static void LoadGameplay()
        {
            SceneManager.LoadScene(_gameSceneID);
        }
        
        public static void LoadMainMenu()
        {
            SceneManager.LoadScene(_mainMenuID);
        }
    }
}