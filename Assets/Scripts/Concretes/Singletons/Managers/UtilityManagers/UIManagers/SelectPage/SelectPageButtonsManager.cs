using Assets.Scripts.Concretes.Singletons.StateMachines;
using Assets.Scripts.Enums;

namespace Assets.Scripts.Concretes.Singletons.Managers
{
    public class SelectPageButtonsManager : ButtonsManager<SelectPageButtonsManager>
    {
        protected override void Init()
        {
            _buttons[(int)ESelectPageButton.ConfirmButton].onClick.AddListener(() => Confirm());
        }
        private void Confirm()
        {
            SelectionPageStateMachine.Instance.HandleConfirmState();
        }
    }
}
