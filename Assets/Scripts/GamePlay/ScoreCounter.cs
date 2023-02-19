using System;
using UnityEngine;

namespace GamePlay
{
    public class ScoreCounter : MonoBehaviour
    {
        public Action<int> OnScoreChanged;
        private int _score;
        private const string _racketTag = "Racket";

        private void Awake()
        {
            GameEvents.ResetGame += ClearProgress;
        }

        private void ClearProgress() => _score = 0;

        private void OnCollisionEnter(Collision collision)
        {
            if (!collision.gameObject.CompareTag(_racketTag)) return;
            _score++;
            OnScoreChanged?.Invoke(_score);
        }

        private void OnDestroy()
        {
            GameEvents.ResetGame -= ClearProgress;
        }
    }
}
