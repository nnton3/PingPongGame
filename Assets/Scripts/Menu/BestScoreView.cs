using GamePlay;
using Services;
using TMPro;
using UnityEngine;

namespace Menu
{
    public class BestScoreView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _bestScore;

        private void Awake()
        {
            GameEvents.ResetGame += UpdateRecord;
        }

        private void Start()
        {
            UpdateRecord();
        }

        private void UpdateRecord()
        {
            _bestScore.text = SaveGameDataService.Model.BestScore.ToString();
        }

        private void OnDestroy()
        {
            GameEvents.ResetGame -= UpdateRecord;
        }
    }
}
