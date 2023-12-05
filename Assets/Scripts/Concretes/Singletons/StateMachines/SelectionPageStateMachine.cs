using Assets.Scripts.Abtractions.Singletons;
using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.States.SelectionPageStates;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Concretes.Singletons.StateMachines
{
    public class SelectionPageStateMachine : StateMachine<SelectionPageStateMachine, SelectionPageState>
    {
        void OnEnable()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        void OnDisable()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }
        private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            HandleStartState();
        }
        public void HandleStartState()
        {
            Destroy(CurrentState.GetComponent<State>());
            CurrentState.AddComponent<StartState>();
        }
        public void HandleConfirmState()
        {
            Destroy(CurrentState.GetComponent<State>());
            CurrentState.AddComponent<ConfirmState>();
        }
    }
}
