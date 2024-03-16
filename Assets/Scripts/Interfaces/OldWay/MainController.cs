using Player;
using UnityEngine;
using UnityEngine.UIElements;

namespace Interfaces.OldWay
{
    public class MainController : MonoBehaviour
    {
        public UIDocument _UIDocument;

        private Label _playerName;
        private ProgressBar _progressBar;
        
        void Start()
        {
            var rootElement = _UIDocument.rootVisualElement;
            _playerName = rootElement.Q<Label>();
            _progressBar = rootElement.Q<ProgressBar>();

            var newPlayerData = new PlayerData() { Name = "Linar", Rating = 33 };
            newPlayerData.OnRatingChanged += UpdateRating;

            _playerName.text = newPlayerData.Name;
            _progressBar.value = newPlayerData.Rating;
        }

        private void UpdateRating(int newRating)
        {
            _progressBar.value = newRating;
        }
    }
}