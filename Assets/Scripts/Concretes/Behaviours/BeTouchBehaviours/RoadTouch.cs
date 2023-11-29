using Assets.Scripts.Abtractions.Behaviours;
using Assets.Scripts.Concretes.Behaviours.MoveBehaviours;
using Assets.Scripts.Concretes.Singletons.Managers.MovingManagers.AnimatedObjectManagers;
using UnityEngine;

namespace Assets.Scripts.Concretes.Behaviours.BeTouchBehaviours
{
    public class RoadTouch : BeTouchBehaviour
    {
        GameObject selectedDummy;
        private void Start()
        {
            selectedDummy = new("Dummy Road");
        }
        public override void OnTouch()
        {
            if (SelectedCarManager.Instance.CanSwitchLane)
            {
                selectedDummy.transform.position = new Vector3(SelectedCarManager.Instance.GetObject().transform.position.x, SelectedCarManager.Instance.GetObject().transform.position.y);
                SelectedCarManager.Instance.GetObject().GetComponent<NonBackgroundMoveBehaviour>().SetDestination(gameObject);
                if (transform.position.y == SecondCarManager.Instance.GetObject().transform.position.y)
                {
                    SecondCarManager.Instance.GetObject().GetComponent<NonBackgroundMoveBehaviour>().SetDestination(selectedDummy);
                }
                else if (transform.position.y == ThirdCarManager.Instance.GetObject().transform.position.y)
                {
                    ThirdCarManager.Instance.GetObject().GetComponent<NonBackgroundMoveBehaviour>().SetDestination(selectedDummy);
                }
            }
        }
    }
}
