using Assets.Scripts.Abtractions.Singletons.Managers.SelectionManagers;
using Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Datas.ScriptableObjects;

namespace Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.SelectionManager
{
    public class CarRaceSelectionManager : SelectionManager<CarRaceSelectionManager, Car>
    {
        protected override void Start()
        {
            int[,] selections = new int[3, 1];
            //int selectedCarIndex = PlayerPrefs.GetInt("selected car");
            int selectedCarIndex = 2;
            int secondIndex = 0;
            int thirdIndex = 1;
            selections[selectedCarIndex, 0] = 1;
            //for(int i = 0; i < 3; i++)
            //{
            //    if(i == selectedCarIndex)
            //    {
            //        continue;
            //    }
            //    if (selections[i, 0] != 1 && secondIndex != -1)
            //    {
            //        secondIndex = i;
            //        selections[i,0] = 1;
            //        continue;
            //    }
            //    if (thirdIndex != -1)
            //    {
            //        thirdIndex = i;
            //        selections[i, 0] = 1;
            //    }
            //}
            //int selectedWordndex = PlayerPrefs.GetInt("played word");
            int selectedWordIndex = 0;
            Word selectedWord = Words.SelectObject(selectedWordIndex);
            PhonicsSpawnManager.Instance.SetWord(selectedWord);
            WordBoxManager.Instance.SetWordBox(selectedWord);
            SoundManager.Instance.SetWord(selectedWord);
            CarsSpawnManager.Instance.SetCars(Vehicles.SelectObject(selectedCarIndex).GetGameObject(), Vehicles.SelectObject(secondIndex).GetGameObject(), Vehicles.SelectObject(thirdIndex).GetGameObject());
        }
    }
}
