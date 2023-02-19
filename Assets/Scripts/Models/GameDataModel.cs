using System;

namespace Models
{
    [Serializable]
    public class GameDataModel
    {
        public int BestScore;
        public BallSkin BallSkin;
    }

    [Serializable]
    public enum BallSkin
    {
        Blue,
        Red,
        Yellow
    }
}
