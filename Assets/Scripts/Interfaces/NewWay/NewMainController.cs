using Player;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UIElements;

namespace Interfaces.NewWay
{
    public class NewMainController : MonoBehaviour
    {
        public UIDocument _UIDocument;

        private Label _playerName;
        private ProgressBar _progressBar;

        void Start()
        {
            var rootElement = _UIDocument.rootVisualElement;
            var newPlayerData = new PlayerData() { Name = "Linar Code", Rating = 33 };
            
            _playerName = rootElement.Q<Label>();
            _progressBar = rootElement.Q<ProgressBar>();

            _playerName.SetBinding(nameof(Label.text), new DataBinding()
            {
                bindingMode = BindingMode.ToTarget,
                dataSource = newPlayerData,
                dataSourcePath = PropertyPath.FromName(nameof(PlayerData.Name))
            });

            _progressBar.SetBinding(nameof(ProgressBar.value), new DataBinding()
            {
                bindingMode = BindingMode.ToTarget,
                dataSource = newPlayerData,
                dataSourcePath = PropertyPath.FromName(nameof(PlayerData.Rating))
            });

            _progressBar.SetBinding(nameof(ProgressBar.title), new DataBinding()
            {
                bindingMode = BindingMode.ToTarget,
                dataSource = newPlayerData,
                dataSourcePath = PropertyPath.FromName(nameof(PlayerData.Rating))
            });
        }
    }
}