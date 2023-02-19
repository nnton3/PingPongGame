using GamePlay;
using Services;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    [SerializeField] private Button 
        _openBtn,
        _closeBtn,
        _closeBackgroundBtn,
        _resetBtn,
        _toMainMenuBtn;
    [SerializeField] private GameObject _window;
    
    private void Awake()
    {
        _openBtn.onClick.AddListener(OpenMenuHandler);
        _closeBtn.onClick.AddListener(CloseMenuHandler);
        _closeBackgroundBtn.onClick.AddListener(CloseMenuHandler);
        _resetBtn.onClick.AddListener(ResetHandler);
        _toMainMenuBtn.onClick.AddListener(SceneLoader.LoadMainMenu);
    }

    private void ResetHandler()
    {
        GameEvents.ResetGame?.Invoke();
        CloseMenuHandler();
    }

    private void OpenMenuHandler()
    {
        _window.SetActive(true);
        Time.timeScale = 0f;
    }
    
    private void CloseMenuHandler()
    {
        _window.SetActive(false);
        Time.timeScale = 1f;
    }
}
