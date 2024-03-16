using System;

namespace Player
{
    [Serializable]
    public class PlayerData
    {
        public event Action<int> OnRatingChanged;
            
        public string Name;
        public int Rating;
    }
}
