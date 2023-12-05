using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Enums;

namespace Assets.Scripts.Concretes.Singletons.Managers
{
    public class HappyCrewSpawnManager : SpawnManager<HappyCrewSpawnManager>
    {
        public override void SpawnObject()
        {
            base.SpawnObject();
            SoundManager.Instance.PlaySound(ESound.CrowdCheering);
        }
    }
}
