using TMPro;
using UnityEngine;

namespace GamePlay
{
    public class CurrentScoreView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _value;
        [SerializeField] private ScoreCounter _scoreCounter;
        private const string _defaultValue = "0";

        private void Awake()
        {
            _scoreCounter.OnScoreChanged += UpdateView;
            GameEvents.ResetGame += ClearProgress;
        }

        private void ClearProgress()
        {
            _value.text = _defaultValue;
        }

        private void UpdateView(int value)
        {
            _value.text = value.ToString();
        }

        private void OnDestroy()
        {
            _scoreCounter.OnScoreChanged -= UpdateView;
            GameEvents.ResetGame -= ClearProgress;
        }
    }
}