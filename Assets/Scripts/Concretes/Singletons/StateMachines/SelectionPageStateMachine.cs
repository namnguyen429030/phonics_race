using Assets.Scripts.Abtractions.Singletons.StateMachines;
using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.States.SelectionPageStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Concretes.Singletons.StateMachines
{
    public class SelectionPageStateMachine : StateMachine<SelectionPageStateMachine, SelectionPageState>
    {
        public int selection;
        public void HandleStartState()
        {
            Destroy(CurrentState.GetComponent<State>());
            CurrentState.AddComponent<StartState>();
        }
        public void HandleSelectState()
        {
            Destroy(CurrentState.GetComponent<State>());
            CurrentState.AddComponent<SelectState>();
        }
        public void HandleConfirmState()
        {
            Destroy(CurrentState.GetComponent<State>());
            CurrentState.AddComponent<ConfirmState>();
        }
        public void HandleEndState()
        {
            Destroy(CurrentState.GetComponent<State>());
            CurrentState.AddComponent<EndState>();
        }
    }
}
