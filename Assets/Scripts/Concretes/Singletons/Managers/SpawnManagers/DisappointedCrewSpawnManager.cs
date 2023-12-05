using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Enums;

namespace Assets.Scripts.Concretes.Singletons.Managers
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
