using Services;
using UnityEngine;

namespace GamePlay
{
    public class BestScoreSaver : MonoBehaviour
    {
        [SerializeField] private ScoreCounter _scoreCounter;
        private int _lastRecord;
        
        private void Awake()
        {
            _lastRecord = SaveGameDataService.Model.BestScore;
            _scoreCounter.OnScoreChanged += SaveRecord;
        }

        private void SaveRecord(int value)
        {
            if (_lastRecord < value)
                SaveGameDataService.SaveBestScore(value);
        }

        private void OnDestroy()
        {
            _scoreCounter.OnScoreChanged -= SaveRecord;
        }
    }
}