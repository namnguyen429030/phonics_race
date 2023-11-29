using Assets.Scripts.Abtractions.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers;
using Assets.Scripts.Enums;

namespace Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers
{
    public class DisappointedCrewSpawnManager : SpawnManager<DisappointedCrewSpawnManager>
    {
        public override void SpawnObject()
        {
            base.SpawnObject();
            SoundManager.Instance.PlaySound(ESound.CrowdDisappointing);
        }
    }
}
