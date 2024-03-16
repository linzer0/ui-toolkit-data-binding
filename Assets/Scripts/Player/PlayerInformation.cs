using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "PlayerInformation", menuName = "Data", order = 0)]
    public class PlayerInformation : ScriptableObject
    {
        public string Name;
        public int Rating;
    }
}