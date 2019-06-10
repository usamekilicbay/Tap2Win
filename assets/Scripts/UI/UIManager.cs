using UnityEngine;
using UnityEngine.Events;

namespace ExtraTools {

    public enum CanvasObjects { MainMenu, Settings, InGame , Tutorial}

    public class UIManager : Singleton<UIManager>
    {
        [SerializeField]
        private GameObject mainMenu;

        [SerializeField]
        private GameObject settings;

        [SerializeField]
        private GameObject inGame;

        [SerializeField]
        private GameObject tutorial;

        public void CanvasChanger(CanvasObjects canvasObjects)
        {
            mainMenu.SetActive(canvasObjects == CanvasObjects.MainMenu);

            settings.SetActive(canvasObjects == CanvasObjects.Settings);

            inGame.SetActive(canvasObjects == CanvasObjects.InGame);

            tutorial.SetActive(canvasObjects == CanvasObjects.Tutorial);
        }



    }
}
