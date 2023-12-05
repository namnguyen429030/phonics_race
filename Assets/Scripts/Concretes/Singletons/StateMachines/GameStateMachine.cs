using Assets.Scripts.Abtractions.Singletons;
using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.States.GameStates;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Concretes.Singletons.StateMachines
{
    public class GameStateMachine : StateMachine<GameStateMachine, GameState>
    {
        public PlayerGameData PlayerGameData { get; private set; }
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
        public void HandleTutorialState()
        {
            Destroy(CurrentState.GetComponent<State>());
            CurrentState.AddComponent<TutorialState>();
        }
        public void HandleSpawnPhonicState()
        {
            Destroy(CurrentState.GetComponent<State>());
            CurrentState.AddComponent<PhonicSpawnState>();
        }
        public void HandleGetPhonicState()
        {
            Destroy(CurrentState.GetComponent<State>());
            CurrentState.AddComponent<GetPhonicState>();
        }
        public void HandleMissPhonicState()
        {
            Destroy(CurrentState.GetComponent<State>());
            CurrentState.AddComponent<MissPhonicState>();
        }
        public void HandleGuidingState()
        {
            Destroy(CurrentState.GetComponent<State>());
            CurrentState.AddComponent<GuidingState>();
        }
        public void HandleEndState()
        {
            Destroy(CurrentState.GetComponent<State>());
            CurrentState.AddComponent<EndState>();
        }
    }
}
