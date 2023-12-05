using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Datas.ScriptableObjects;
using Assets.Scripts.Implementations;
using Assets.Scripts.Interfaces;

namespace Assets.Scripts.Concretes.Singletons.Managers
{
    public class WordSelectionManager : SelectionManager<WordSelectionManager, Word>
    {
        IDataManage<PlayerGameData> playerDataManager;
        public override void SelectObject()
        {
            playerDataManager = new PlayerDataManage();
            PlayerGameData playerData = playerDataManager.Load();
            SelectObject(playerData.currentWordIndex + 1);
            if (SelectedIndex == database.Count)
            {
                SelectObject(0);
            }
            SelectedObject = database.SelectObject(SelectedIndex);
        }
    }
}
