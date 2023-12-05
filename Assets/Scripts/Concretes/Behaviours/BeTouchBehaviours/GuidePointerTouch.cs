using Assets.Scripts.Abtractions.Behaviours;
using Assets.Scripts.Concretes.Singletons.Managers;

namespace Assets.Scripts.Concretes.Behaviours
{
    public class GuidePointerTouch : BeTouchBehaviour
    {
        public override void OnTouch()
        {
            GuidePointerSpawnManager.Instance.isPointerTouch = true;
            SelectedCarManager.Instance.GetObject().GetComponent<NonBackgroundMoveBehaviour>().SetDestination(gameObject);
        }
    }
}
