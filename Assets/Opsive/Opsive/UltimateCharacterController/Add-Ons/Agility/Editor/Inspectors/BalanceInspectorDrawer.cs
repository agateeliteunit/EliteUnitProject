/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

namespace Opsive.UltimateCharacterController.AddOns.Agility.Editor.Inspectors.Character.Abilities
{
	using Opsive.Shared.Editor.Inspectors;
	using Opsive.UltimateCharacterController.Editor.Inspectors.Character;
	using Opsive.UltimateCharacterController.Editor.Utility;
	using UnityEditor;
	using UnityEditor.Animations;
	using UnityEngine;

	/// <summary>
	/// Draws a custom inspector for the Balance Ability.
	/// </summary>
	[InspectorDrawer(typeof(Balance))]
	public class BalanceInspectorDrawer : AbilityInspectorDrawer
	{
		// ------------------------------------------- Start Generated Code -------------------------------------------
		// ------- Do NOT make any changes below. Changes will be removed when the animator is generated again. -------
		// ------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// Returns true if the ability can build to the animator.
		/// </summary>
		public override bool CanBuildAnimator { get { return true; } }

		/// <summary>
		/// An editor only method which can add the abilities states/transitions to the animator.
		/// </summary>
		/// <param name="animatorController">The Animator Controller to add the states to.</param>
		/// <param name="firstPersonAnimatorController">The first person Animator Controller to add the states to.</param>
		public override void BuildAnimator(AnimatorController animatorController, AnimatorController firstPersonAnimatorController)
		{
			if (animatorController.layers.Length <= 0) {
				Debug.LogWarning("Warning: The animator controller does not contain the same number of layers as the demo animator. All of the animations cannot be added.");
				return;
			}

			var baseStateMachine1803976636 = animatorController.layers[0].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1803976636.stateMachines.Length; ++j) {
					if (baseStateMachine1803976636.stateMachines[j].stateMachine.name == "Balance") {
						baseStateMachine1803976636.RemoveStateMachine(baseStateMachine1803976636.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var balanceBwdAnimationClip60310Path = AssetDatabase.GUIDToAssetPath("1eb167ae0309ef345acbb8e77a657f82"); 
			var balanceBwdAnimationClip60310 = AnimatorBuilder.GetAnimationClip(balanceBwdAnimationClip60310Path, "BalanceBwd");
			var balanceIdleRightAnimationClip60312Path = AssetDatabase.GUIDToAssetPath("a433ee9521fa9d741b694e52eb438d29"); 
			var balanceIdleRightAnimationClip60312 = AnimatorBuilder.GetAnimationClip(balanceIdleRightAnimationClip60312Path, "BalanceIdleRight");
			var balanceFwdAnimationClip60314Path = AssetDatabase.GUIDToAssetPath("47a0520f151e5c643aa6ef9c68654a51"); 
			var balanceFwdAnimationClip60314 = AnimatorBuilder.GetAnimationClip(balanceFwdAnimationClip60314Path, "BalanceFwd");
			var balanceIdleLeftAnimationClip60320Path = AssetDatabase.GUIDToAssetPath("a433ee9521fa9d741b694e52eb438d29"); 
			var balanceIdleLeftAnimationClip60320 = AnimatorBuilder.GetAnimationClip(balanceIdleLeftAnimationClip60320Path, "BalanceIdleLeft");

			// State Machine.
			var balanceAnimatorStateMachine58236 = baseStateMachine1803976636.AddStateMachine("Balance", new Vector3(624f, 12f, 0f));

			// States.
			var balanceMovementAnimatorState59098 = balanceAnimatorStateMachine58236.AddState("Balance Movement", new Vector3(432f, 96f, 0f));
			var balanceMovementAnimatorState59098blendTreeBlendTree60308 = new BlendTree();
			AssetDatabase.AddObjectToAsset(balanceMovementAnimatorState59098blendTreeBlendTree60308, animatorController);
			balanceMovementAnimatorState59098blendTreeBlendTree60308.hideFlags = HideFlags.HideInHierarchy;
			balanceMovementAnimatorState59098blendTreeBlendTree60308.blendParameter = "ForwardMovement";
			balanceMovementAnimatorState59098blendTreeBlendTree60308.blendParameterY = "ForwardMovement";
			balanceMovementAnimatorState59098blendTreeBlendTree60308.blendType = BlendTreeType.Simple1D;
			balanceMovementAnimatorState59098blendTreeBlendTree60308.maxThreshold = 1f;
			balanceMovementAnimatorState59098blendTreeBlendTree60308.minThreshold = -1f;
			balanceMovementAnimatorState59098blendTreeBlendTree60308.name = "Blend Tree";
			balanceMovementAnimatorState59098blendTreeBlendTree60308.useAutomaticThresholds = false;
			var balanceMovementAnimatorState59098blendTreeBlendTree60308Child0 =  new ChildMotion();
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child0.motion = balanceBwdAnimationClip60310;
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child0.cycleOffset = 0f;
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child0.directBlendParameter = "HorizontalMovement";
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child0.mirror = false;
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child0.position = new Vector2(0f, -1f);
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child0.threshold = -1f;
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child0.timeScale = 1.4f;
			var balanceMovementAnimatorState59098blendTreeBlendTree60308Child1 =  new ChildMotion();
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child1.motion = balanceIdleRightAnimationClip60312;
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child1.cycleOffset = 0f;
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child1.directBlendParameter = "HorizontalMovement";
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child1.mirror = false;
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child1.position = new Vector2(0f, 0f);
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child1.threshold = 0f;
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child1.timeScale = 1f;
			var balanceMovementAnimatorState59098blendTreeBlendTree60308Child2 =  new ChildMotion();
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child2.motion = balanceFwdAnimationClip60314;
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child2.cycleOffset = 0f;
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child2.directBlendParameter = "HorizontalMovement";
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child2.mirror = false;
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child2.position = new Vector2(0f, 1f);
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child2.threshold = 1f;
			balanceMovementAnimatorState59098blendTreeBlendTree60308Child2.timeScale = 1.4f;
			balanceMovementAnimatorState59098blendTreeBlendTree60308.children = new ChildMotion[] {
				balanceMovementAnimatorState59098blendTreeBlendTree60308Child0,
				balanceMovementAnimatorState59098blendTreeBlendTree60308Child1,
				balanceMovementAnimatorState59098blendTreeBlendTree60308Child2
			};
			balanceMovementAnimatorState59098.motion = balanceMovementAnimatorState59098blendTreeBlendTree60308;
			balanceMovementAnimatorState59098.cycleOffset = 0f;
			balanceMovementAnimatorState59098.cycleOffsetParameterActive = false;
			balanceMovementAnimatorState59098.iKOnFeet = true;
			balanceMovementAnimatorState59098.mirror = false;
			balanceMovementAnimatorState59098.mirrorParameterActive = false;
			balanceMovementAnimatorState59098.speed = 1f;
			balanceMovementAnimatorState59098.speedParameterActive = false;
			balanceMovementAnimatorState59098.writeDefaultValues = true;

			var balanceIdleLeftAnimatorState60300 = balanceAnimatorStateMachine58236.AddState("Balance Idle Left", new Vector3(564f, -24f, 0f));
			balanceIdleLeftAnimatorState60300.motion = balanceIdleLeftAnimationClip60320;
			balanceIdleLeftAnimatorState60300.cycleOffset = 0f;
			balanceIdleLeftAnimatorState60300.cycleOffsetParameterActive = false;
			balanceIdleLeftAnimatorState60300.iKOnFeet = true;
			balanceIdleLeftAnimatorState60300.mirror = false;
			balanceIdleLeftAnimatorState60300.mirrorParameterActive = false;
			balanceIdleLeftAnimatorState60300.speed = 1f;
			balanceIdleLeftAnimatorState60300.speedParameterActive = false;
			balanceIdleLeftAnimatorState60300.writeDefaultValues = true;

			var balanceIdleRightAnimatorState59100 = balanceAnimatorStateMachine58236.AddState("Balance Idle Right", new Vector3(312f, -24f, 0f));
			balanceIdleRightAnimatorState59100.motion = balanceIdleRightAnimationClip60312;
			balanceIdleRightAnimatorState59100.cycleOffset = 0f;
			balanceIdleRightAnimatorState59100.cycleOffsetParameterActive = false;
			balanceIdleRightAnimatorState59100.iKOnFeet = true;
			balanceIdleRightAnimatorState59100.mirror = false;
			balanceIdleRightAnimatorState59100.mirrorParameterActive = false;
			balanceIdleRightAnimatorState59100.speed = 1f;
			balanceIdleRightAnimatorState59100.speedParameterActive = false;
			balanceIdleRightAnimatorState59100.writeDefaultValues = true;

			// State Machine Defaults.
			balanceAnimatorStateMachine58236.anyStatePosition = new Vector3(50f, 20f, 0f);
			balanceAnimatorStateMachine58236.defaultState = balanceMovementAnimatorState59098;
			balanceAnimatorStateMachine58236.entryPosition = new Vector3(50f, 120f, 0f);
			balanceAnimatorStateMachine58236.exitPosition = new Vector3(800f, 120f, 0f);
			balanceAnimatorStateMachine58236.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Transitions.
			var animatorStateTransition60302 = balanceMovementAnimatorState59098.AddExitTransition();
			animatorStateTransition60302.canTransitionToSelf = true;
			animatorStateTransition60302.duration = 0.15f;
			animatorStateTransition60302.exitTime = 0.9f;
			animatorStateTransition60302.hasExitTime = false;
			animatorStateTransition60302.hasFixedDuration = true;
			animatorStateTransition60302.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60302.offset = 0f;
			animatorStateTransition60302.orderedInterruption = true;
			animatorStateTransition60302.isExit = true;
			animatorStateTransition60302.mute = false;
			animatorStateTransition60302.solo = false;
			animatorStateTransition60302.AddCondition(AnimatorConditionMode.NotEqual, 107f, "AbilityIndex");

			var animatorStateTransition60304 = balanceMovementAnimatorState59098.AddTransition(balanceIdleRightAnimatorState59100);
			animatorStateTransition60304.canTransitionToSelf = true;
			animatorStateTransition60304.duration = 0.3f;
			animatorStateTransition60304.exitTime = 0.91f;
			animatorStateTransition60304.hasExitTime = false;
			animatorStateTransition60304.hasFixedDuration = true;
			animatorStateTransition60304.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60304.offset = 0f;
			animatorStateTransition60304.orderedInterruption = true;
			animatorStateTransition60304.isExit = false;
			animatorStateTransition60304.mute = false;
			animatorStateTransition60304.solo = false;
			animatorStateTransition60304.AddCondition(AnimatorConditionMode.Equals, 107f, "AbilityIndex");
			animatorStateTransition60304.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition60304.AddCondition(AnimatorConditionMode.Less, 0.499f, "LegIndex");

			var animatorStateTransition60306 = balanceMovementAnimatorState59098.AddTransition(balanceIdleLeftAnimatorState60300);
			animatorStateTransition60306.canTransitionToSelf = true;
			animatorStateTransition60306.duration = 0.3f;
			animatorStateTransition60306.exitTime = 0.91f;
			animatorStateTransition60306.hasExitTime = false;
			animatorStateTransition60306.hasFixedDuration = true;
			animatorStateTransition60306.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60306.offset = 0f;
			animatorStateTransition60306.orderedInterruption = true;
			animatorStateTransition60306.isExit = false;
			animatorStateTransition60306.mute = false;
			animatorStateTransition60306.solo = false;
			animatorStateTransition60306.AddCondition(AnimatorConditionMode.Equals, 107f, "AbilityIndex");
			animatorStateTransition60306.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			animatorStateTransition60306.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var animatorStateTransition60316 = balanceIdleLeftAnimatorState60300.AddExitTransition();
			animatorStateTransition60316.canTransitionToSelf = true;
			animatorStateTransition60316.duration = 0.15f;
			animatorStateTransition60316.exitTime = 0.95f;
			animatorStateTransition60316.hasExitTime = false;
			animatorStateTransition60316.hasFixedDuration = true;
			animatorStateTransition60316.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60316.offset = 0f;
			animatorStateTransition60316.orderedInterruption = true;
			animatorStateTransition60316.isExit = true;
			animatorStateTransition60316.mute = false;
			animatorStateTransition60316.solo = false;
			animatorStateTransition60316.AddCondition(AnimatorConditionMode.NotEqual, 107f, "AbilityIndex");

			var animatorStateTransition60318 = balanceIdleLeftAnimatorState60300.AddTransition(balanceMovementAnimatorState59098);
			animatorStateTransition60318.canTransitionToSelf = true;
			animatorStateTransition60318.duration = 0.2f;
			animatorStateTransition60318.exitTime = 0.95f;
			animatorStateTransition60318.hasExitTime = false;
			animatorStateTransition60318.hasFixedDuration = true;
			animatorStateTransition60318.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60318.offset = 0.6f;
			animatorStateTransition60318.orderedInterruption = true;
			animatorStateTransition60318.isExit = false;
			animatorStateTransition60318.mute = false;
			animatorStateTransition60318.solo = false;
			animatorStateTransition60318.AddCondition(AnimatorConditionMode.Equals, 107f, "AbilityIndex");
			animatorStateTransition60318.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			var animatorStateTransition60322 = balanceIdleRightAnimatorState59100.AddExitTransition();
			animatorStateTransition60322.canTransitionToSelf = true;
			animatorStateTransition60322.duration = 0.15f;
			animatorStateTransition60322.exitTime = 0.95f;
			animatorStateTransition60322.hasExitTime = false;
			animatorStateTransition60322.hasFixedDuration = true;
			animatorStateTransition60322.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60322.offset = 0f;
			animatorStateTransition60322.orderedInterruption = true;
			animatorStateTransition60322.isExit = true;
			animatorStateTransition60322.mute = false;
			animatorStateTransition60322.solo = false;
			animatorStateTransition60322.AddCondition(AnimatorConditionMode.NotEqual, 107f, "AbilityIndex");

			var animatorStateTransition60324 = balanceIdleRightAnimatorState59100.AddTransition(balanceMovementAnimatorState59098);
			animatorStateTransition60324.canTransitionToSelf = true;
			animatorStateTransition60324.duration = 0.2f;
			animatorStateTransition60324.exitTime = 0.95f;
			animatorStateTransition60324.hasExitTime = false;
			animatorStateTransition60324.hasFixedDuration = true;
			animatorStateTransition60324.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60324.offset = 0.1f;
			animatorStateTransition60324.orderedInterruption = true;
			animatorStateTransition60324.isExit = false;
			animatorStateTransition60324.mute = false;
			animatorStateTransition60324.solo = false;
			animatorStateTransition60324.AddCondition(AnimatorConditionMode.Equals, 107f, "AbilityIndex");
			animatorStateTransition60324.AddCondition(AnimatorConditionMode.If, 0f, "Moving");


			// State Machine Transitions.
			var animatorStateTransition58772 = baseStateMachine1803976636.AddAnyStateTransition(balanceMovementAnimatorState59098);
			animatorStateTransition58772.canTransitionToSelf = false;
			animatorStateTransition58772.duration = 0.15f;
			animatorStateTransition58772.exitTime = 0.75f;
			animatorStateTransition58772.hasExitTime = false;
			animatorStateTransition58772.hasFixedDuration = true;
			animatorStateTransition58772.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58772.offset = 0f;
			animatorStateTransition58772.orderedInterruption = true;
			animatorStateTransition58772.isExit = false;
			animatorStateTransition58772.mute = false;
			animatorStateTransition58772.solo = false;
			animatorStateTransition58772.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58772.AddCondition(AnimatorConditionMode.Equals, 107f, "AbilityIndex");
			animatorStateTransition58772.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			var animatorStateTransition58774 = baseStateMachine1803976636.AddAnyStateTransition(balanceIdleRightAnimatorState59100);
			animatorStateTransition58774.canTransitionToSelf = false;
			animatorStateTransition58774.duration = 0.15f;
			animatorStateTransition58774.exitTime = 0.75f;
			animatorStateTransition58774.hasExitTime = false;
			animatorStateTransition58774.hasFixedDuration = true;
			animatorStateTransition58774.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58774.offset = 0f;
			animatorStateTransition58774.orderedInterruption = true;
			animatorStateTransition58774.isExit = false;
			animatorStateTransition58774.mute = false;
			animatorStateTransition58774.solo = false;
			animatorStateTransition58774.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58774.AddCondition(AnimatorConditionMode.Equals, 107f, "AbilityIndex");
			animatorStateTransition58774.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
		}
	}
}
