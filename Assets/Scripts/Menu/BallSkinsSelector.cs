using Models;
using Services;
using TMPro;
using UnityEngine;

namespace Menu
{
    public class BallSkinsSelector : MonoBehaviour
    {
        [SerializeField] private TMP_Dropdown _skinsDropdown;

        private void Start()
        {
            _skinsDropdown.value = (int)SaveGameDataService.Model.BallSkin;
            _skinsDropdown.onValueChanged.AddListener(OnChangedHandler);
        }

        private void OnChangedHandler(int skinID)
        {
            SaveGameDataService.SaveBallSkin((BallSkin)skinID);
        }
    }
}