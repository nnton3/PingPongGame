using Services;
using UnityEngine;
using UnityEngine.UI;

namespace Menu
{
    public class StartBtnHandler : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(SceneLoader.LoadGameplay);
        }
    }
}
