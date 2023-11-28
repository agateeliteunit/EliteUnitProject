using UnityEngine;

namespace EnemyAI
{
	// The FSM state scriptable object definition, containing actions and transitions.
	[CreateAssetMenu(menuName = "Enemy AI/State")]
	public class State : ScriptableObject
	{
		[Tooltip("The actions to perform when on the state.")]
		public Action[] actions;
		[Tooltip("The transitions to check when on the state.")]
		public Transition[] transitions;
		[Tooltip("The state category color (blue: clear, yellow: warning, red: engage).")]
		public Color sceneGizmoColor = Color.grey;

		// Perform the state corresponding actions.
		public void DoActions(StateController controller)
		{
			foreach (Action action in actions)
			{
				action.Act(controller);
			}
		}

		// Trigger the state action once when the state is becomes the current one.
		public void OnEnableActions(StateController controller)
		{
			foreach (Action action in actions)
			{
				// Trigger on enable for all actions once, when the state is activated.
				action.OnEnableAction(controller);
			}

			for (int i = transitions.Length - 1; i >= 0; i--)
			{
				// Trigger on enable for all decisions once, when the state is activated.
				transitions[i].decision.OnEnableDecision(controller);
			}
		}

		// Check the state corresponding transitions to other FSM states.
		public void CheckTransitions(StateController controller)
		{
			// First decisions has precedence over the last ones.
			foreach (Transition transition in transitions)
			{
				bool decision = transition.decision.Decide(controller);
				if (decision)
				{
					// Go to true state.
					controller.TransitionToState(transition.trueState, transition.decision);
				}
				else
				{
					// Go to false state.
					controller.TransitionToState(transition.falseState, transition.decision);
				}
				// If a transition was performed to another state, trigger on enable for all actions of new state.
				if (controller.currentState != this)
				{
					controller.currentState.OnEnableActions(controller);
					// No need to check remaining transitions.
					break;
				}
			}
		}
	}
}
