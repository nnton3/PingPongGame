using Models;
using UnityEngine;

namespace  Services
{
    public static class SaveGameDataService
    {
        public static GameDataModel Model
        {
            get
            {
                if (_model != null) return _model;
                var json = PlayerPrefs.GetString(_saveTag);
                _model = string.IsNullOrEmpty(json) ? new GameDataModel() : JsonUtility.FromJson<GameDataModel>(json);

                return _model;
            }
        }
        private const string _saveTag = "gameDataModel"; 
        private static GameDataModel _model;

        public static void SaveBallSkin(BallSkin skin)
        {
            Model.BallSkin = skin;
            SaveProgress();
        }

        public static void SaveBestScore(int record)
        {
            Model.BestScore = record;
            SaveProgress();
        }

        private static void SaveProgress()
        {
            var json = JsonUtility.ToJson(_model);
            Debug.Log($"save {json}");
            PlayerPrefs.SetString(_saveTag, json);
        }
    }
}
