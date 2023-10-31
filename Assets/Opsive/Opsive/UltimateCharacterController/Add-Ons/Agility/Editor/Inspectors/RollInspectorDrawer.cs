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
	/// Draws a custom inspector for the Roll Ability.
	/// </summary>
	[InspectorDrawer(typeof(Roll))]
	public class RollInspectorDrawer : AbilityInspectorDrawer
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

			var baseStateMachine1660321602 = animatorController.layers[0].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1660321602.stateMachines.Length; ++j) {
					if (baseStateMachine1660321602.stateMachines[j].stateMachine.name == "Roll") {
						baseStateMachine1660321602.RemoveStateMachine(baseStateMachine1660321602.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var aimRollStrafeLeftAnimationClip60422Path = AssetDatabase.GUIDToAssetPath("ebc53bbaf0a0c1a4cb304d6fcf6d59e0"); 
			var aimRollStrafeLeftAnimationClip60422 = AnimatorBuilder.GetAnimationClip(aimRollStrafeLeftAnimationClip60422Path, "AimRollStrafeLeft");
			var rollStrafeLeftAnimationClip60426Path = AssetDatabase.GUIDToAssetPath("b8637c33bea0507438d6ac9899a42eba"); 
			var rollStrafeLeftAnimationClip60426 = AnimatorBuilder.GetAnimationClip(rollStrafeLeftAnimationClip60426Path, "RollStrafeLeft");
			var rollStrafeRightAnimationClip60430Path = AssetDatabase.GUIDToAssetPath("b8637c33bea0507438d6ac9899a42eba"); 
			var rollStrafeRightAnimationClip60430 = AnimatorBuilder.GetAnimationClip(rollStrafeRightAnimationClip60430Path, "RollStrafeRight");
			var rollAnimationClip60434Path = AssetDatabase.GUIDToAssetPath("80a3c683dd5529f45a234b67ef06e9f9"); 
			var rollAnimationClip60434 = AnimatorBuilder.GetAnimationClip(rollAnimationClip60434Path, "Roll");
			var rollWalkAnimationClip60438Path = AssetDatabase.GUIDToAssetPath("b8637c33bea0507438d6ac9899a42eba"); 
			var rollWalkAnimationClip60438 = AnimatorBuilder.GetAnimationClip(rollWalkAnimationClip60438Path, "RollWalk");
			var rollRunAnimationClip60442Path = AssetDatabase.GUIDToAssetPath("a6ca56273daad044499776330617bbe0"); 
			var rollRunAnimationClip60442 = AnimatorBuilder.GetAnimationClip(rollRunAnimationClip60442Path, "RollRun");
			var aimRollStrafeRightAnimationClip60446Path = AssetDatabase.GUIDToAssetPath("2086f17275bfe1a428abc9e4fd79b9d0"); 
			var aimRollStrafeRightAnimationClip60446 = AnimatorBuilder.GetAnimationClip(aimRollStrafeRightAnimationClip60446Path, "AimRollStrafeRight");
			var rollFallingAnimationClip60450Path = AssetDatabase.GUIDToAssetPath("f58548f03b2a12d4784d3d02009eac46"); 
			var rollFallingAnimationClip60450 = AnimatorBuilder.GetAnimationClip(rollFallingAnimationClip60450Path, "RollFalling");

			// State Machine.
			var rollAnimatorStateMachine58242 = baseStateMachine1660321602.AddStateMachine("Roll", new Vector3(624f, 156f, 0f));

			// States.
			var aimRollLeftAnimatorState59142 = rollAnimatorStateMachine58242.AddState("Aim Roll Left", new Vector3(384f, -132f, 0f));
			aimRollLeftAnimatorState59142.motion = aimRollStrafeLeftAnimationClip60422;
			aimRollLeftAnimatorState59142.cycleOffset = 0f;
			aimRollLeftAnimatorState59142.cycleOffsetParameterActive = false;
			aimRollLeftAnimatorState59142.iKOnFeet = false;
			aimRollLeftAnimatorState59142.mirror = false;
			aimRollLeftAnimatorState59142.mirrorParameterActive = false;
			aimRollLeftAnimatorState59142.speed = 2.75f;
			aimRollLeftAnimatorState59142.speedParameterActive = false;
			aimRollLeftAnimatorState59142.writeDefaultValues = true;

			var rollLeftAnimatorState59144 = rollAnimatorStateMachine58242.AddState("Roll Left", new Vector3(384f, -192f, 0f));
			rollLeftAnimatorState59144.motion = rollStrafeLeftAnimationClip60426;
			rollLeftAnimatorState59144.cycleOffset = 0f;
			rollLeftAnimatorState59144.cycleOffsetParameterActive = false;
			rollLeftAnimatorState59144.iKOnFeet = false;
			rollLeftAnimatorState59144.mirror = false;
			rollLeftAnimatorState59144.mirrorParameterActive = false;
			rollLeftAnimatorState59144.speed = 2.75f;
			rollLeftAnimatorState59144.speedParameterActive = false;
			rollLeftAnimatorState59144.writeDefaultValues = true;

			var rollRightAnimatorState59146 = rollAnimatorStateMachine58242.AddState("Roll Right", new Vector3(384f, -72f, 0f));
			rollRightAnimatorState59146.motion = rollStrafeRightAnimationClip60430;
			rollRightAnimatorState59146.cycleOffset = 0f;
			rollRightAnimatorState59146.cycleOffsetParameterActive = false;
			rollRightAnimatorState59146.iKOnFeet = false;
			rollRightAnimatorState59146.mirror = false;
			rollRightAnimatorState59146.mirrorParameterActive = false;
			rollRightAnimatorState59146.speed = 2.75f;
			rollRightAnimatorState59146.speedParameterActive = false;
			rollRightAnimatorState59146.writeDefaultValues = true;

			var rollAnimatorState59148 = rollAnimatorStateMachine58242.AddState("Roll", new Vector3(384f, 48f, 0f));
			rollAnimatorState59148.motion = rollAnimationClip60434;
			rollAnimatorState59148.cycleOffset = 0f;
			rollAnimatorState59148.cycleOffsetParameterActive = false;
			rollAnimatorState59148.iKOnFeet = false;
			rollAnimatorState59148.mirror = false;
			rollAnimatorState59148.mirrorParameterActive = false;
			rollAnimatorState59148.speed = 2.75f;
			rollAnimatorState59148.speedParameterActive = false;
			rollAnimatorState59148.writeDefaultValues = true;

			var rollWalkAnimatorState59150 = rollAnimatorStateMachine58242.AddState("Roll Walk", new Vector3(384f, 108f, 0f));
			rollWalkAnimatorState59150.motion = rollWalkAnimationClip60438;
			rollWalkAnimatorState59150.cycleOffset = 0f;
			rollWalkAnimatorState59150.cycleOffsetParameterActive = false;
			rollWalkAnimatorState59150.iKOnFeet = false;
			rollWalkAnimatorState59150.mirror = false;
			rollWalkAnimatorState59150.mirrorParameterActive = false;
			rollWalkAnimatorState59150.speed = 2.75f;
			rollWalkAnimatorState59150.speedParameterActive = false;
			rollWalkAnimatorState59150.writeDefaultValues = true;

			var rollRunAnimatorState59152 = rollAnimatorStateMachine58242.AddState("Roll Run", new Vector3(384f, 168f, 0f));
			rollRunAnimatorState59152.motion = rollRunAnimationClip60442;
			rollRunAnimatorState59152.cycleOffset = 0f;
			rollRunAnimatorState59152.cycleOffsetParameterActive = false;
			rollRunAnimatorState59152.iKOnFeet = false;
			rollRunAnimatorState59152.mirror = false;
			rollRunAnimatorState59152.mirrorParameterActive = false;
			rollRunAnimatorState59152.speed = 2.75f;
			rollRunAnimatorState59152.speedParameterActive = false;
			rollRunAnimatorState59152.writeDefaultValues = true;

			var aimRollRightAnimatorState59154 = rollAnimatorStateMachine58242.AddState("Aim Roll Right", new Vector3(384f, -12f, 0f));
			aimRollRightAnimatorState59154.motion = aimRollStrafeRightAnimationClip60446;
			aimRollRightAnimatorState59154.cycleOffset = 0f;
			aimRollRightAnimatorState59154.cycleOffsetParameterActive = false;
			aimRollRightAnimatorState59154.iKOnFeet = false;
			aimRollRightAnimatorState59154.mirror = false;
			aimRollRightAnimatorState59154.mirrorParameterActive = false;
			aimRollRightAnimatorState59154.speed = 2.75f;
			aimRollRightAnimatorState59154.speedParameterActive = false;
			aimRollRightAnimatorState59154.writeDefaultValues = true;

			var fallingRollAnimatorState59156 = rollAnimatorStateMachine58242.AddState("Falling Roll", new Vector3(384f, 228f, 0f));
			fallingRollAnimatorState59156.motion = rollFallingAnimationClip60450;
			fallingRollAnimatorState59156.cycleOffset = 0f;
			fallingRollAnimatorState59156.cycleOffsetParameterActive = false;
			fallingRollAnimatorState59156.iKOnFeet = false;
			fallingRollAnimatorState59156.mirror = false;
			fallingRollAnimatorState59156.mirrorParameterActive = false;
			fallingRollAnimatorState59156.speed = 2.75f;
			fallingRollAnimatorState59156.speedParameterActive = false;
			fallingRollAnimatorState59156.writeDefaultValues = true;

			// State Machine Defaults.
			rollAnimatorStateMachine58242.anyStatePosition = new Vector3(50f, 20f, 0f);
			rollAnimatorStateMachine58242.defaultState = rollAnimatorState59148;
			rollAnimatorStateMachine58242.entryPosition = new Vector3(60f, -36f, 0f);
			rollAnimatorStateMachine58242.exitPosition = new Vector3(756f, 24f, 0f);
			rollAnimatorStateMachine58242.parentStateMachinePosition = new Vector3(732f, -48f, 0f);

			// State Transitions.
			var animatorStateTransition60420 = aimRollLeftAnimatorState59142.AddExitTransition();
			animatorStateTransition60420.canTransitionToSelf = true;
			animatorStateTransition60420.duration = 0.15f;
			animatorStateTransition60420.exitTime = 0.9158775f;
			animatorStateTransition60420.hasExitTime = false;
			animatorStateTransition60420.hasFixedDuration = true;
			animatorStateTransition60420.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60420.offset = 0f;
			animatorStateTransition60420.orderedInterruption = true;
			animatorStateTransition60420.isExit = true;
			animatorStateTransition60420.mute = false;
			animatorStateTransition60420.solo = false;
			animatorStateTransition60420.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition60424 = rollLeftAnimatorState59144.AddExitTransition();
			animatorStateTransition60424.canTransitionToSelf = true;
			animatorStateTransition60424.duration = 0.15f;
			animatorStateTransition60424.exitTime = 0.9158775f;
			animatorStateTransition60424.hasExitTime = false;
			animatorStateTransition60424.hasFixedDuration = true;
			animatorStateTransition60424.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60424.offset = 0f;
			animatorStateTransition60424.orderedInterruption = true;
			animatorStateTransition60424.isExit = true;
			animatorStateTransition60424.mute = false;
			animatorStateTransition60424.solo = false;
			animatorStateTransition60424.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition60428 = rollRightAnimatorState59146.AddExitTransition();
			animatorStateTransition60428.canTransitionToSelf = true;
			animatorStateTransition60428.duration = 0.15f;
			animatorStateTransition60428.exitTime = 0.9158775f;
			animatorStateTransition60428.hasExitTime = false;
			animatorStateTransition60428.hasFixedDuration = true;
			animatorStateTransition60428.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60428.offset = 0f;
			animatorStateTransition60428.orderedInterruption = true;
			animatorStateTransition60428.isExit = true;
			animatorStateTransition60428.mute = false;
			animatorStateTransition60428.solo = false;
			animatorStateTransition60428.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition60432 = rollAnimatorState59148.AddExitTransition();
			animatorStateTransition60432.canTransitionToSelf = true;
			animatorStateTransition60432.duration = 0.15f;
			animatorStateTransition60432.exitTime = 0.9158775f;
			animatorStateTransition60432.hasExitTime = false;
			animatorStateTransition60432.hasFixedDuration = true;
			animatorStateTransition60432.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60432.offset = 0f;
			animatorStateTransition60432.orderedInterruption = true;
			animatorStateTransition60432.isExit = true;
			animatorStateTransition60432.mute = false;
			animatorStateTransition60432.solo = false;
			animatorStateTransition60432.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition60436 = rollWalkAnimatorState59150.AddExitTransition();
			animatorStateTransition60436.canTransitionToSelf = true;
			animatorStateTransition60436.duration = 0.15f;
			animatorStateTransition60436.exitTime = 0.9158775f;
			animatorStateTransition60436.hasExitTime = false;
			animatorStateTransition60436.hasFixedDuration = true;
			animatorStateTransition60436.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60436.offset = 0f;
			animatorStateTransition60436.orderedInterruption = true;
			animatorStateTransition60436.isExit = true;
			animatorStateTransition60436.mute = false;
			animatorStateTransition60436.solo = false;
			animatorStateTransition60436.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition60440 = rollRunAnimatorState59152.AddExitTransition();
			animatorStateTransition60440.canTransitionToSelf = true;
			animatorStateTransition60440.duration = 0.15f;
			animatorStateTransition60440.exitTime = 0.9158775f;
			animatorStateTransition60440.hasExitTime = false;
			animatorStateTransition60440.hasFixedDuration = true;
			animatorStateTransition60440.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60440.offset = 0f;
			animatorStateTransition60440.orderedInterruption = true;
			animatorStateTransition60440.isExit = true;
			animatorStateTransition60440.mute = false;
			animatorStateTransition60440.solo = false;
			animatorStateTransition60440.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition60444 = aimRollRightAnimatorState59154.AddExitTransition();
			animatorStateTransition60444.canTransitionToSelf = true;
			animatorStateTransition60444.duration = 0.15f;
			animatorStateTransition60444.exitTime = 0.9158775f;
			animatorStateTransition60444.hasExitTime = false;
			animatorStateTransition60444.hasFixedDuration = true;
			animatorStateTransition60444.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60444.offset = 0f;
			animatorStateTransition60444.orderedInterruption = true;
			animatorStateTransition60444.isExit = true;
			animatorStateTransition60444.mute = false;
			animatorStateTransition60444.solo = false;
			animatorStateTransition60444.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition60448 = fallingRollAnimatorState59156.AddExitTransition();
			animatorStateTransition60448.canTransitionToSelf = true;
			animatorStateTransition60448.duration = 0.15f;
			animatorStateTransition60448.exitTime = 0.9158775f;
			animatorStateTransition60448.hasExitTime = false;
			animatorStateTransition60448.hasFixedDuration = true;
			animatorStateTransition60448.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60448.offset = 0f;
			animatorStateTransition60448.orderedInterruption = true;
			animatorStateTransition60448.isExit = true;
			animatorStateTransition60448.mute = false;
			animatorStateTransition60448.solo = false;
			animatorStateTransition60448.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");


			// State Machine Transitions.
			var animatorStateTransition58816 = baseStateMachine1660321602.AddAnyStateTransition(aimRollLeftAnimatorState59142);
			animatorStateTransition58816.canTransitionToSelf = false;
			animatorStateTransition58816.duration = 0.05f;
			animatorStateTransition58816.exitTime = 0.75f;
			animatorStateTransition58816.hasExitTime = false;
			animatorStateTransition58816.hasFixedDuration = true;
			animatorStateTransition58816.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58816.offset = 0.1f;
			animatorStateTransition58816.orderedInterruption = true;
			animatorStateTransition58816.isExit = false;
			animatorStateTransition58816.mute = false;
			animatorStateTransition58816.solo = false;
			animatorStateTransition58816.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58816.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition58816.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			animatorStateTransition58816.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");

			var animatorStateTransition58818 = baseStateMachine1660321602.AddAnyStateTransition(rollLeftAnimatorState59144);
			animatorStateTransition58818.canTransitionToSelf = false;
			animatorStateTransition58818.duration = 0.05f;
			animatorStateTransition58818.exitTime = 0.75f;
			animatorStateTransition58818.hasExitTime = false;
			animatorStateTransition58818.hasFixedDuration = true;
			animatorStateTransition58818.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58818.offset = 0.1f;
			animatorStateTransition58818.orderedInterruption = true;
			animatorStateTransition58818.isExit = false;
			animatorStateTransition58818.mute = false;
			animatorStateTransition58818.solo = false;
			animatorStateTransition58818.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58818.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition58818.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			animatorStateTransition58818.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");

			var animatorStateTransition58820 = baseStateMachine1660321602.AddAnyStateTransition(rollRightAnimatorState59146);
			animatorStateTransition58820.canTransitionToSelf = false;
			animatorStateTransition58820.duration = 0.05f;
			animatorStateTransition58820.exitTime = 0.75f;
			animatorStateTransition58820.hasExitTime = false;
			animatorStateTransition58820.hasFixedDuration = true;
			animatorStateTransition58820.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58820.offset = 0.1f;
			animatorStateTransition58820.orderedInterruption = true;
			animatorStateTransition58820.isExit = false;
			animatorStateTransition58820.mute = false;
			animatorStateTransition58820.solo = false;
			animatorStateTransition58820.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58820.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition58820.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition58820.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");

			var animatorStateTransition58822 = baseStateMachine1660321602.AddAnyStateTransition(rollAnimatorState59148);
			animatorStateTransition58822.canTransitionToSelf = false;
			animatorStateTransition58822.duration = 0.05f;
			animatorStateTransition58822.exitTime = 0.75f;
			animatorStateTransition58822.hasExitTime = false;
			animatorStateTransition58822.hasFixedDuration = true;
			animatorStateTransition58822.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58822.offset = 0.1f;
			animatorStateTransition58822.orderedInterruption = true;
			animatorStateTransition58822.isExit = false;
			animatorStateTransition58822.mute = false;
			animatorStateTransition58822.solo = false;
			animatorStateTransition58822.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58822.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition58822.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition58822.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var animatorStateTransition58824 = baseStateMachine1660321602.AddAnyStateTransition(rollWalkAnimatorState59150);
			animatorStateTransition58824.canTransitionToSelf = false;
			animatorStateTransition58824.duration = 0.05f;
			animatorStateTransition58824.exitTime = 0.75f;
			animatorStateTransition58824.hasExitTime = false;
			animatorStateTransition58824.hasFixedDuration = true;
			animatorStateTransition58824.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58824.offset = 0.1f;
			animatorStateTransition58824.orderedInterruption = true;
			animatorStateTransition58824.isExit = false;
			animatorStateTransition58824.mute = false;
			animatorStateTransition58824.solo = false;
			animatorStateTransition58824.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58824.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition58824.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition58824.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition58824.AddCondition(AnimatorConditionMode.Greater, 0.5f, "Speed");
			animatorStateTransition58824.AddCondition(AnimatorConditionMode.Less, 1.5f, "Speed");

			var animatorStateTransition58826 = baseStateMachine1660321602.AddAnyStateTransition(rollRunAnimatorState59152);
			animatorStateTransition58826.canTransitionToSelf = false;
			animatorStateTransition58826.duration = 0.05f;
			animatorStateTransition58826.exitTime = 0.75f;
			animatorStateTransition58826.hasExitTime = false;
			animatorStateTransition58826.hasFixedDuration = true;
			animatorStateTransition58826.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58826.offset = 0.1f;
			animatorStateTransition58826.orderedInterruption = true;
			animatorStateTransition58826.isExit = false;
			animatorStateTransition58826.mute = false;
			animatorStateTransition58826.solo = false;
			animatorStateTransition58826.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58826.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition58826.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition58826.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition58826.AddCondition(AnimatorConditionMode.Greater, 1f, "Speed");

			var animatorStateTransition58828 = baseStateMachine1660321602.AddAnyStateTransition(aimRollRightAnimatorState59154);
			animatorStateTransition58828.canTransitionToSelf = false;
			animatorStateTransition58828.duration = 0.05f;
			animatorStateTransition58828.exitTime = 0.75f;
			animatorStateTransition58828.hasExitTime = false;
			animatorStateTransition58828.hasFixedDuration = true;
			animatorStateTransition58828.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58828.offset = 0.1f;
			animatorStateTransition58828.orderedInterruption = true;
			animatorStateTransition58828.isExit = false;
			animatorStateTransition58828.mute = false;
			animatorStateTransition58828.solo = false;
			animatorStateTransition58828.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58828.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition58828.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition58828.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");

			var animatorStateTransition58830 = baseStateMachine1660321602.AddAnyStateTransition(fallingRollAnimatorState59156);
			animatorStateTransition58830.canTransitionToSelf = false;
			animatorStateTransition58830.duration = 0.05f;
			animatorStateTransition58830.exitTime = 0.75f;
			animatorStateTransition58830.hasExitTime = false;
			animatorStateTransition58830.hasFixedDuration = true;
			animatorStateTransition58830.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58830.offset = 0.1f;
			animatorStateTransition58830.orderedInterruption = true;
			animatorStateTransition58830.isExit = false;
			animatorStateTransition58830.mute = false;
			animatorStateTransition58830.solo = false;
			animatorStateTransition58830.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58830.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition58830.AddCondition(AnimatorConditionMode.Equals, 3f, "AbilityIntData");

			if (animatorController.layers.Length <= 5) {
				Debug.LogWarning("Warning: The animator controller does not contain the same number of layers as the demo animator. All of the animations cannot be added.");
				return;
			}

			var baseStateMachine1705994360 = animatorController.layers[5].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1705994360.stateMachines.Length; ++j) {
					if (baseStateMachine1705994360.stateMachines[j].stateMachine.name == "Roll") {
						baseStateMachine1705994360.RemoveStateMachine(baseStateMachine1705994360.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var assaultRifleRollIdleAnimationClip62940Path = AssetDatabase.GUIDToAssetPath("39544c3509240c542b07576a5af1c13c"); 
			var assaultRifleRollIdleAnimationClip62940 = AnimatorBuilder.GetAnimationClip(assaultRifleRollIdleAnimationClip62940Path, "AssaultRifleRollIdle");
			var pistolRollIdleAnimationClip62944Path = AssetDatabase.GUIDToAssetPath("09e38275d81602b489835c6374477408"); 
			var pistolRollIdleAnimationClip62944 = AnimatorBuilder.GetAnimationClip(pistolRollIdleAnimationClip62944Path, "PistolRollIdle");
			var dualPistolRollIdleAnimationClip62948Path = AssetDatabase.GUIDToAssetPath("d828fedde99b6024a8e7e26e17e45386"); 
			var dualPistolRollIdleAnimationClip62948 = AnimatorBuilder.GetAnimationClip(dualPistolRollIdleAnimationClip62948Path, "DualPistolRollIdle");
			var rocketLauncherRollIdleAnimationClip62952Path = AssetDatabase.GUIDToAssetPath("4b2e64e4268ee634a8f5ef226eea2fa7"); 
			var rocketLauncherRollIdleAnimationClip62952 = AnimatorBuilder.GetAnimationClip(rocketLauncherRollIdleAnimationClip62952Path, "RocketLauncherRollIdle");
			var shotgunRollIdleAnimationClip62956Path = AssetDatabase.GUIDToAssetPath("ecea2486194b00448941b70a63f54011"); 
			var shotgunRollIdleAnimationClip62956 = AnimatorBuilder.GetAnimationClip(shotgunRollIdleAnimationClip62956Path, "ShotgunRollIdle");
			var sniperRifleRollIdleAnimationClip62960Path = AssetDatabase.GUIDToAssetPath("39b068db4042ab343a202f0407939fed"); 
			var sniperRifleRollIdleAnimationClip62960 = AnimatorBuilder.GetAnimationClip(sniperRifleRollIdleAnimationClip62960Path, "SniperRifleRollIdle");
			var shieldRollIdleAnimationClip62964Path = AssetDatabase.GUIDToAssetPath("a0f52d3dc5cea6046b13848f8edd2f5c"); 
			var shieldRollIdleAnimationClip62964 = AnimatorBuilder.GetAnimationClip(shieldRollIdleAnimationClip62964Path, "ShieldRollIdle");
			var bowRollIdleAnimationClip62968Path = AssetDatabase.GUIDToAssetPath("a073f0ad43f21244aaca022aef7f88ee"); 
			var bowRollIdleAnimationClip62968 = AnimatorBuilder.GetAnimationClip(bowRollIdleAnimationClip62968Path, "BowRollIdle");

			// State Machine.
			var rollAnimatorStateMachine62648 = baseStateMachine1705994360.AddStateMachine("Roll", new Vector3(852f, 108f, 0f));

			// States.
			var assaultRifleAnimatorState62802 = rollAnimatorStateMachine62648.AddState("Assault Rifle", new Vector3(384f, -48f, 0f));
			assaultRifleAnimatorState62802.motion = assaultRifleRollIdleAnimationClip62940;
			assaultRifleAnimatorState62802.cycleOffset = 0f;
			assaultRifleAnimatorState62802.cycleOffsetParameterActive = false;
			assaultRifleAnimatorState62802.iKOnFeet = false;
			assaultRifleAnimatorState62802.mirror = false;
			assaultRifleAnimatorState62802.mirrorParameterActive = false;
			assaultRifleAnimatorState62802.speed = 1f;
			assaultRifleAnimatorState62802.speedParameterActive = false;
			assaultRifleAnimatorState62802.writeDefaultValues = true;

			var pistolAnimatorState62800 = rollAnimatorStateMachine62648.AddState("Pistol", new Vector3(384f, 132f, 0f));
			pistolAnimatorState62800.motion = pistolRollIdleAnimationClip62944;
			pistolAnimatorState62800.cycleOffset = 0f;
			pistolAnimatorState62800.cycleOffsetParameterActive = false;
			pistolAnimatorState62800.iKOnFeet = false;
			pistolAnimatorState62800.mirror = false;
			pistolAnimatorState62800.mirrorParameterActive = false;
			pistolAnimatorState62800.speed = 1f;
			pistolAnimatorState62800.speedParameterActive = false;
			pistolAnimatorState62800.writeDefaultValues = true;

			var dualPistolAnimatorState62798 = rollAnimatorStateMachine62648.AddState("Dual Pistol", new Vector3(384f, 72f, 0f));
			dualPistolAnimatorState62798.motion = dualPistolRollIdleAnimationClip62948;
			dualPistolAnimatorState62798.cycleOffset = 0f;
			dualPistolAnimatorState62798.cycleOffsetParameterActive = false;
			dualPistolAnimatorState62798.iKOnFeet = false;
			dualPistolAnimatorState62798.mirror = false;
			dualPistolAnimatorState62798.mirrorParameterActive = false;
			dualPistolAnimatorState62798.speed = 1f;
			dualPistolAnimatorState62798.speedParameterActive = false;
			dualPistolAnimatorState62798.writeDefaultValues = true;

			var rocketLauncherAnimatorState62810 = rollAnimatorStateMachine62648.AddState("Rocket Launcher", new Vector3(384f, 192f, 0f));
			rocketLauncherAnimatorState62810.motion = rocketLauncherRollIdleAnimationClip62952;
			rocketLauncherAnimatorState62810.cycleOffset = 0f;
			rocketLauncherAnimatorState62810.cycleOffsetParameterActive = false;
			rocketLauncherAnimatorState62810.iKOnFeet = false;
			rocketLauncherAnimatorState62810.mirror = false;
			rocketLauncherAnimatorState62810.mirrorParameterActive = false;
			rocketLauncherAnimatorState62810.speed = 1f;
			rocketLauncherAnimatorState62810.speedParameterActive = false;
			rocketLauncherAnimatorState62810.writeDefaultValues = true;

			var shotgunAnimatorState62808 = rollAnimatorStateMachine62648.AddState("Shotgun", new Vector3(384f, 312f, 0f));
			shotgunAnimatorState62808.motion = shotgunRollIdleAnimationClip62956;
			shotgunAnimatorState62808.cycleOffset = 0f;
			shotgunAnimatorState62808.cycleOffsetParameterActive = false;
			shotgunAnimatorState62808.iKOnFeet = false;
			shotgunAnimatorState62808.mirror = false;
			shotgunAnimatorState62808.mirrorParameterActive = false;
			shotgunAnimatorState62808.speed = 1f;
			shotgunAnimatorState62808.speedParameterActive = false;
			shotgunAnimatorState62808.writeDefaultValues = true;

			var sniperRifleAnimatorState62806 = rollAnimatorStateMachine62648.AddState("Sniper Rifle", new Vector3(384f, 372f, 0f));
			sniperRifleAnimatorState62806.motion = sniperRifleRollIdleAnimationClip62960;
			sniperRifleAnimatorState62806.cycleOffset = 0f;
			sniperRifleAnimatorState62806.cycleOffsetParameterActive = false;
			sniperRifleAnimatorState62806.iKOnFeet = false;
			sniperRifleAnimatorState62806.mirror = false;
			sniperRifleAnimatorState62806.mirrorParameterActive = false;
			sniperRifleAnimatorState62806.speed = 1f;
			sniperRifleAnimatorState62806.speedParameterActive = false;
			sniperRifleAnimatorState62806.writeDefaultValues = true;

			var shieldAnimatorState62796 = rollAnimatorStateMachine62648.AddState("Shield", new Vector3(384f, 252f, 0f));
			shieldAnimatorState62796.motion = shieldRollIdleAnimationClip62964;
			shieldAnimatorState62796.cycleOffset = 0f;
			shieldAnimatorState62796.cycleOffsetParameterActive = false;
			shieldAnimatorState62796.iKOnFeet = false;
			shieldAnimatorState62796.mirror = false;
			shieldAnimatorState62796.mirrorParameterActive = false;
			shieldAnimatorState62796.speed = 1f;
			shieldAnimatorState62796.speedParameterActive = false;
			shieldAnimatorState62796.writeDefaultValues = true;

			var bowAnimatorState62804 = rollAnimatorStateMachine62648.AddState("Bow", new Vector3(384f, 12f, 0f));
			bowAnimatorState62804.motion = bowRollIdleAnimationClip62968;
			bowAnimatorState62804.cycleOffset = 0f;
			bowAnimatorState62804.cycleOffsetParameterActive = false;
			bowAnimatorState62804.iKOnFeet = false;
			bowAnimatorState62804.mirror = false;
			bowAnimatorState62804.mirrorParameterActive = false;
			bowAnimatorState62804.speed = 1f;
			bowAnimatorState62804.speedParameterActive = false;
			bowAnimatorState62804.writeDefaultValues = true;

			// State Machine Defaults.
			rollAnimatorStateMachine62648.anyStatePosition = new Vector3(36f, 156f, 0f);
			rollAnimatorStateMachine62648.defaultState = assaultRifleAnimatorState62802;
			rollAnimatorStateMachine62648.entryPosition = new Vector3(36f, 96f, 0f);
			rollAnimatorStateMachine62648.exitPosition = new Vector3(768f, 168f, 0f);
			rollAnimatorStateMachine62648.parentStateMachinePosition = new Vector3(744f, 84f, 0f);

			// State Transitions.
			var animatorStateTransition62938 = assaultRifleAnimatorState62802.AddExitTransition();
			animatorStateTransition62938.canTransitionToSelf = true;
			animatorStateTransition62938.duration = 0.15f;
			animatorStateTransition62938.exitTime = 0f;
			animatorStateTransition62938.hasExitTime = false;
			animatorStateTransition62938.hasFixedDuration = true;
			animatorStateTransition62938.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62938.offset = 0f;
			animatorStateTransition62938.orderedInterruption = true;
			animatorStateTransition62938.isExit = true;
			animatorStateTransition62938.mute = false;
			animatorStateTransition62938.solo = false;
			animatorStateTransition62938.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition62942 = pistolAnimatorState62800.AddExitTransition();
			animatorStateTransition62942.canTransitionToSelf = true;
			animatorStateTransition62942.duration = 0.15f;
			animatorStateTransition62942.exitTime = 0f;
			animatorStateTransition62942.hasExitTime = false;
			animatorStateTransition62942.hasFixedDuration = true;
			animatorStateTransition62942.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62942.offset = 0f;
			animatorStateTransition62942.orderedInterruption = true;
			animatorStateTransition62942.isExit = true;
			animatorStateTransition62942.mute = false;
			animatorStateTransition62942.solo = false;
			animatorStateTransition62942.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition62946 = dualPistolAnimatorState62798.AddExitTransition();
			animatorStateTransition62946.canTransitionToSelf = true;
			animatorStateTransition62946.duration = 0.15f;
			animatorStateTransition62946.exitTime = 0f;
			animatorStateTransition62946.hasExitTime = false;
			animatorStateTransition62946.hasFixedDuration = true;
			animatorStateTransition62946.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62946.offset = 0f;
			animatorStateTransition62946.orderedInterruption = true;
			animatorStateTransition62946.isExit = true;
			animatorStateTransition62946.mute = false;
			animatorStateTransition62946.solo = false;
			animatorStateTransition62946.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition62950 = rocketLauncherAnimatorState62810.AddExitTransition();
			animatorStateTransition62950.canTransitionToSelf = true;
			animatorStateTransition62950.duration = 0.15f;
			animatorStateTransition62950.exitTime = 0f;
			animatorStateTransition62950.hasExitTime = false;
			animatorStateTransition62950.hasFixedDuration = true;
			animatorStateTransition62950.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62950.offset = 0f;
			animatorStateTransition62950.orderedInterruption = true;
			animatorStateTransition62950.isExit = true;
			animatorStateTransition62950.mute = false;
			animatorStateTransition62950.solo = false;
			animatorStateTransition62950.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition62954 = shotgunAnimatorState62808.AddExitTransition();
			animatorStateTransition62954.canTransitionToSelf = true;
			animatorStateTransition62954.duration = 0.15f;
			animatorStateTransition62954.exitTime = 0f;
			animatorStateTransition62954.hasExitTime = false;
			animatorStateTransition62954.hasFixedDuration = true;
			animatorStateTransition62954.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62954.offset = 0f;
			animatorStateTransition62954.orderedInterruption = true;
			animatorStateTransition62954.isExit = true;
			animatorStateTransition62954.mute = false;
			animatorStateTransition62954.solo = false;
			animatorStateTransition62954.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition62958 = sniperRifleAnimatorState62806.AddExitTransition();
			animatorStateTransition62958.canTransitionToSelf = true;
			animatorStateTransition62958.duration = 0.15f;
			animatorStateTransition62958.exitTime = 0f;
			animatorStateTransition62958.hasExitTime = false;
			animatorStateTransition62958.hasFixedDuration = true;
			animatorStateTransition62958.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62958.offset = 0f;
			animatorStateTransition62958.orderedInterruption = true;
			animatorStateTransition62958.isExit = true;
			animatorStateTransition62958.mute = false;
			animatorStateTransition62958.solo = false;
			animatorStateTransition62958.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition62962 = shieldAnimatorState62796.AddExitTransition();
			animatorStateTransition62962.canTransitionToSelf = true;
			animatorStateTransition62962.duration = 0.15f;
			animatorStateTransition62962.exitTime = 0f;
			animatorStateTransition62962.hasExitTime = false;
			animatorStateTransition62962.hasFixedDuration = true;
			animatorStateTransition62962.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62962.offset = 0f;
			animatorStateTransition62962.orderedInterruption = true;
			animatorStateTransition62962.isExit = true;
			animatorStateTransition62962.mute = false;
			animatorStateTransition62962.solo = false;
			animatorStateTransition62962.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition62966 = bowAnimatorState62804.AddExitTransition();
			animatorStateTransition62966.canTransitionToSelf = true;
			animatorStateTransition62966.duration = 0.15f;
			animatorStateTransition62966.exitTime = 0f;
			animatorStateTransition62966.hasExitTime = false;
			animatorStateTransition62966.hasFixedDuration = true;
			animatorStateTransition62966.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62966.offset = 0f;
			animatorStateTransition62966.orderedInterruption = true;
			animatorStateTransition62966.isExit = true;
			animatorStateTransition62966.mute = false;
			animatorStateTransition62966.solo = false;
			animatorStateTransition62966.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");


			// State Machine Transitions.
			var animatorStateTransition62716 = baseStateMachine1705994360.AddAnyStateTransition(shieldAnimatorState62796);
			animatorStateTransition62716.canTransitionToSelf = false;
			animatorStateTransition62716.duration = 0.05f;
			animatorStateTransition62716.exitTime = 0.75f;
			animatorStateTransition62716.hasExitTime = false;
			animatorStateTransition62716.hasFixedDuration = true;
			animatorStateTransition62716.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62716.offset = 0f;
			animatorStateTransition62716.orderedInterruption = true;
			animatorStateTransition62716.isExit = false;
			animatorStateTransition62716.mute = false;
			animatorStateTransition62716.solo = false;
			animatorStateTransition62716.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition62716.AddCondition(AnimatorConditionMode.Equals, 25f, "Slot1ItemID");

			var animatorStateTransition62718 = baseStateMachine1705994360.AddAnyStateTransition(dualPistolAnimatorState62798);
			animatorStateTransition62718.canTransitionToSelf = false;
			animatorStateTransition62718.duration = 0.05f;
			animatorStateTransition62718.exitTime = 0.75f;
			animatorStateTransition62718.hasExitTime = false;
			animatorStateTransition62718.hasFixedDuration = true;
			animatorStateTransition62718.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62718.offset = 0f;
			animatorStateTransition62718.orderedInterruption = true;
			animatorStateTransition62718.isExit = false;
			animatorStateTransition62718.mute = false;
			animatorStateTransition62718.solo = false;
			animatorStateTransition62718.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition62718.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			animatorStateTransition62718.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot1ItemID");

			var animatorStateTransition62720 = baseStateMachine1705994360.AddAnyStateTransition(pistolAnimatorState62800);
			animatorStateTransition62720.canTransitionToSelf = false;
			animatorStateTransition62720.duration = 0.05f;
			animatorStateTransition62720.exitTime = 0.75f;
			animatorStateTransition62720.hasExitTime = false;
			animatorStateTransition62720.hasFixedDuration = true;
			animatorStateTransition62720.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62720.offset = 0f;
			animatorStateTransition62720.orderedInterruption = true;
			animatorStateTransition62720.isExit = false;
			animatorStateTransition62720.mute = false;
			animatorStateTransition62720.solo = false;
			animatorStateTransition62720.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition62720.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			animatorStateTransition62720.AddCondition(AnimatorConditionMode.NotEqual, 2f, "Slot1ItemID");

			var animatorStateTransition62722 = baseStateMachine1705994360.AddAnyStateTransition(assaultRifleAnimatorState62802);
			animatorStateTransition62722.canTransitionToSelf = false;
			animatorStateTransition62722.duration = 0.05f;
			animatorStateTransition62722.exitTime = 0.75f;
			animatorStateTransition62722.hasExitTime = false;
			animatorStateTransition62722.hasFixedDuration = true;
			animatorStateTransition62722.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62722.offset = 0f;
			animatorStateTransition62722.orderedInterruption = true;
			animatorStateTransition62722.isExit = false;
			animatorStateTransition62722.mute = false;
			animatorStateTransition62722.solo = false;
			animatorStateTransition62722.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition62722.AddCondition(AnimatorConditionMode.Equals, 1f, "Slot0ItemID");

			var animatorStateTransition62724 = baseStateMachine1705994360.AddAnyStateTransition(bowAnimatorState62804);
			animatorStateTransition62724.canTransitionToSelf = false;
			animatorStateTransition62724.duration = 0.05f;
			animatorStateTransition62724.exitTime = 0.75f;
			animatorStateTransition62724.hasExitTime = false;
			animatorStateTransition62724.hasFixedDuration = true;
			animatorStateTransition62724.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62724.offset = 0f;
			animatorStateTransition62724.orderedInterruption = true;
			animatorStateTransition62724.isExit = false;
			animatorStateTransition62724.mute = false;
			animatorStateTransition62724.solo = false;
			animatorStateTransition62724.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition62724.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot1ItemID");

			var animatorStateTransition62726 = baseStateMachine1705994360.AddAnyStateTransition(sniperRifleAnimatorState62806);
			animatorStateTransition62726.canTransitionToSelf = false;
			animatorStateTransition62726.duration = 0.05f;
			animatorStateTransition62726.exitTime = 0.75f;
			animatorStateTransition62726.hasExitTime = false;
			animatorStateTransition62726.hasFixedDuration = true;
			animatorStateTransition62726.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62726.offset = 0f;
			animatorStateTransition62726.orderedInterruption = true;
			animatorStateTransition62726.isExit = false;
			animatorStateTransition62726.mute = false;
			animatorStateTransition62726.solo = false;
			animatorStateTransition62726.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition62726.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemID");

			var animatorStateTransition62728 = baseStateMachine1705994360.AddAnyStateTransition(shotgunAnimatorState62808);
			animatorStateTransition62728.canTransitionToSelf = false;
			animatorStateTransition62728.duration = 0.05f;
			animatorStateTransition62728.exitTime = 0.75f;
			animatorStateTransition62728.hasExitTime = false;
			animatorStateTransition62728.hasFixedDuration = true;
			animatorStateTransition62728.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62728.offset = 0f;
			animatorStateTransition62728.orderedInterruption = true;
			animatorStateTransition62728.isExit = false;
			animatorStateTransition62728.mute = false;
			animatorStateTransition62728.solo = false;
			animatorStateTransition62728.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition62728.AddCondition(AnimatorConditionMode.Equals, 3f, "Slot0ItemID");

			var animatorStateTransition62730 = baseStateMachine1705994360.AddAnyStateTransition(rocketLauncherAnimatorState62810);
			animatorStateTransition62730.canTransitionToSelf = false;
			animatorStateTransition62730.duration = 0.05f;
			animatorStateTransition62730.exitTime = 0.75f;
			animatorStateTransition62730.hasExitTime = false;
			animatorStateTransition62730.hasFixedDuration = true;
			animatorStateTransition62730.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62730.offset = 0f;
			animatorStateTransition62730.orderedInterruption = true;
			animatorStateTransition62730.isExit = false;
			animatorStateTransition62730.mute = false;
			animatorStateTransition62730.solo = false;
			animatorStateTransition62730.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition62730.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemID");

			if (animatorController.layers.Length <= 6) {
				Debug.LogWarning("Warning: The animator controller does not contain the same number of layers as the demo animator. All of the animations cannot be added.");
				return;
			}

			var baseStateMachine1729063656 = animatorController.layers[6].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1729063656.stateMachines.Length; ++j) {
					if (baseStateMachine1729063656.stateMachines[j].stateMachine.name == "Roll") {
						baseStateMachine1729063656.RemoveStateMachine(baseStateMachine1729063656.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var swordRollIdleAnimationClip63420Path = AssetDatabase.GUIDToAssetPath("0e24b81f894df92458c8e8a5588622de"); 
			var swordRollIdleAnimationClip63420 = AnimatorBuilder.GetAnimationClip(swordRollIdleAnimationClip63420Path, "SwordRollIdle");
			var katanaRollIdleAnimationClip63424Path = AssetDatabase.GUIDToAssetPath("e9734da6e3b579041b65e31fa14305f9"); 
			var katanaRollIdleAnimationClip63424 = AnimatorBuilder.GetAnimationClip(katanaRollIdleAnimationClip63424Path, "KatanaRollIdle");
			var knifeRollIdleAnimationClip63430Path = AssetDatabase.GUIDToAssetPath("c7bccd5ba3087d24ab9b21627c71d781"); 
			var knifeRollIdleAnimationClip63430 = AnimatorBuilder.GetAnimationClip(knifeRollIdleAnimationClip63430Path, "KnifeRollIdle");

			// State Machine.
			var rollAnimatorStateMachine63016 = baseStateMachine1729063656.AddStateMachine("Roll", new Vector3(852f, 60f, 0f));

			// States.
			var assaultRifleAnimatorState63220 = rollAnimatorStateMachine63016.AddState("Assault Rifle", new Vector3(384f, -228f, 0f));
			assaultRifleAnimatorState63220.motion = assaultRifleRollIdleAnimationClip62940;
			assaultRifleAnimatorState63220.cycleOffset = 0f;
			assaultRifleAnimatorState63220.cycleOffsetParameterActive = false;
			assaultRifleAnimatorState63220.iKOnFeet = false;
			assaultRifleAnimatorState63220.mirror = false;
			assaultRifleAnimatorState63220.mirrorParameterActive = false;
			assaultRifleAnimatorState63220.speed = 1f;
			assaultRifleAnimatorState63220.speedParameterActive = false;
			assaultRifleAnimatorState63220.writeDefaultValues = true;

			var sniperRifleAnimatorState63222 = rollAnimatorStateMachine63016.AddState("Sniper Rifle", new Vector3(384f, 252f, 0f));
			sniperRifleAnimatorState63222.motion = sniperRifleRollIdleAnimationClip62960;
			sniperRifleAnimatorState63222.cycleOffset = 0f;
			sniperRifleAnimatorState63222.cycleOffsetParameterActive = false;
			sniperRifleAnimatorState63222.iKOnFeet = false;
			sniperRifleAnimatorState63222.mirror = false;
			sniperRifleAnimatorState63222.mirrorParameterActive = false;
			sniperRifleAnimatorState63222.speed = 1f;
			sniperRifleAnimatorState63222.speedParameterActive = false;
			sniperRifleAnimatorState63222.writeDefaultValues = true;

			var shotgunAnimatorState63214 = rollAnimatorStateMachine63016.AddState("Shotgun", new Vector3(384f, 192f, 0f));
			shotgunAnimatorState63214.motion = shotgunRollIdleAnimationClip62956;
			shotgunAnimatorState63214.cycleOffset = 0f;
			shotgunAnimatorState63214.cycleOffsetParameterActive = false;
			shotgunAnimatorState63214.iKOnFeet = false;
			shotgunAnimatorState63214.mirror = false;
			shotgunAnimatorState63214.mirrorParameterActive = false;
			shotgunAnimatorState63214.speed = 1f;
			shotgunAnimatorState63214.speedParameterActive = false;
			shotgunAnimatorState63214.writeDefaultValues = true;

			var rocketLauncherAnimatorState63218 = rollAnimatorStateMachine63016.AddState("Rocket Launcher", new Vector3(384f, 132f, 0f));
			rocketLauncherAnimatorState63218.motion = rocketLauncherRollIdleAnimationClip62952;
			rocketLauncherAnimatorState63218.cycleOffset = 0f;
			rocketLauncherAnimatorState63218.cycleOffsetParameterActive = false;
			rocketLauncherAnimatorState63218.iKOnFeet = false;
			rocketLauncherAnimatorState63218.mirror = false;
			rocketLauncherAnimatorState63218.mirrorParameterActive = false;
			rocketLauncherAnimatorState63218.speed = 1f;
			rocketLauncherAnimatorState63218.speedParameterActive = false;
			rocketLauncherAnimatorState63218.writeDefaultValues = true;

			var dualPistolAnimatorState63212 = rollAnimatorStateMachine63016.AddState("Dual Pistol", new Vector3(384f, -108f, 0f));
			dualPistolAnimatorState63212.motion = dualPistolRollIdleAnimationClip62948;
			dualPistolAnimatorState63212.cycleOffset = 0f;
			dualPistolAnimatorState63212.cycleOffsetParameterActive = false;
			dualPistolAnimatorState63212.iKOnFeet = false;
			dualPistolAnimatorState63212.mirror = false;
			dualPistolAnimatorState63212.mirrorParameterActive = false;
			dualPistolAnimatorState63212.speed = 1f;
			dualPistolAnimatorState63212.speedParameterActive = false;
			dualPistolAnimatorState63212.writeDefaultValues = true;

			var pistolAnimatorState63216 = rollAnimatorStateMachine63016.AddState("Pistol", new Vector3(384f, 72f, 0f));
			pistolAnimatorState63216.motion = pistolRollIdleAnimationClip62944;
			pistolAnimatorState63216.cycleOffset = 0f;
			pistolAnimatorState63216.cycleOffsetParameterActive = false;
			pistolAnimatorState63216.iKOnFeet = false;
			pistolAnimatorState63216.mirror = false;
			pistolAnimatorState63216.mirrorParameterActive = false;
			pistolAnimatorState63216.speed = 1f;
			pistolAnimatorState63216.speedParameterActive = false;
			pistolAnimatorState63216.writeDefaultValues = true;

			var swordAnimatorState63204 = rollAnimatorStateMachine63016.AddState("Sword", new Vector3(384f, 312f, 0f));
			swordAnimatorState63204.motion = swordRollIdleAnimationClip63420;
			swordAnimatorState63204.cycleOffset = 0f;
			swordAnimatorState63204.cycleOffsetParameterActive = false;
			swordAnimatorState63204.iKOnFeet = false;
			swordAnimatorState63204.mirror = false;
			swordAnimatorState63204.mirrorParameterActive = false;
			swordAnimatorState63204.speed = 1f;
			swordAnimatorState63204.speedParameterActive = false;
			swordAnimatorState63204.writeDefaultValues = true;

			var katanaAnimatorState63208 = rollAnimatorStateMachine63016.AddState("Katana", new Vector3(384f, -48f, 0f));
			katanaAnimatorState63208.motion = katanaRollIdleAnimationClip63424;
			katanaAnimatorState63208.cycleOffset = 0f;
			katanaAnimatorState63208.cycleOffsetParameterActive = false;
			katanaAnimatorState63208.iKOnFeet = false;
			katanaAnimatorState63208.mirror = false;
			katanaAnimatorState63208.mirrorParameterActive = false;
			katanaAnimatorState63208.speed = 1f;
			katanaAnimatorState63208.speedParameterActive = false;
			katanaAnimatorState63208.writeDefaultValues = true;

			var bowAnimatorState63210 = rollAnimatorStateMachine63016.AddState("Bow", new Vector3(384f, -168f, 0f));
			bowAnimatorState63210.motion = bowRollIdleAnimationClip62968;
			bowAnimatorState63210.cycleOffset = 0f;
			bowAnimatorState63210.cycleOffsetParameterActive = false;
			bowAnimatorState63210.iKOnFeet = false;
			bowAnimatorState63210.mirror = false;
			bowAnimatorState63210.mirrorParameterActive = false;
			bowAnimatorState63210.speed = 1f;
			bowAnimatorState63210.speedParameterActive = false;
			bowAnimatorState63210.writeDefaultValues = true;

			var knifeAnimatorState63206 = rollAnimatorStateMachine63016.AddState("Knife", new Vector3(384f, 12f, 0f));
			knifeAnimatorState63206.motion = knifeRollIdleAnimationClip63430;
			knifeAnimatorState63206.cycleOffset = 0f;
			knifeAnimatorState63206.cycleOffsetParameterActive = false;
			knifeAnimatorState63206.iKOnFeet = false;
			knifeAnimatorState63206.mirror = false;
			knifeAnimatorState63206.mirrorParameterActive = false;
			knifeAnimatorState63206.speed = 1f;
			knifeAnimatorState63206.speedParameterActive = false;
			knifeAnimatorState63206.writeDefaultValues = true;

			// State Machine Defaults.
			rollAnimatorStateMachine63016.anyStatePosition = new Vector3(48f, 48f, 0f);
			rollAnimatorStateMachine63016.defaultState = assaultRifleAnimatorState63220;
			rollAnimatorStateMachine63016.entryPosition = new Vector3(48f, 0f, 0f);
			rollAnimatorStateMachine63016.exitPosition = new Vector3(768f, 36f, 0f);
			rollAnimatorStateMachine63016.parentStateMachinePosition = new Vector3(744f, -48f, 0f);

			// State Transitions.
			var animatorStateTransition63406 = assaultRifleAnimatorState63220.AddExitTransition();
			animatorStateTransition63406.canTransitionToSelf = true;
			animatorStateTransition63406.duration = 0.15f;
			animatorStateTransition63406.exitTime = 0f;
			animatorStateTransition63406.hasExitTime = false;
			animatorStateTransition63406.hasFixedDuration = true;
			animatorStateTransition63406.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63406.offset = 0f;
			animatorStateTransition63406.orderedInterruption = true;
			animatorStateTransition63406.isExit = true;
			animatorStateTransition63406.mute = false;
			animatorStateTransition63406.solo = false;
			animatorStateTransition63406.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition63408 = sniperRifleAnimatorState63222.AddExitTransition();
			animatorStateTransition63408.canTransitionToSelf = true;
			animatorStateTransition63408.duration = 0.15f;
			animatorStateTransition63408.exitTime = 0f;
			animatorStateTransition63408.hasExitTime = false;
			animatorStateTransition63408.hasFixedDuration = true;
			animatorStateTransition63408.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63408.offset = 0f;
			animatorStateTransition63408.orderedInterruption = true;
			animatorStateTransition63408.isExit = true;
			animatorStateTransition63408.mute = false;
			animatorStateTransition63408.solo = false;
			animatorStateTransition63408.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition63410 = shotgunAnimatorState63214.AddExitTransition();
			animatorStateTransition63410.canTransitionToSelf = true;
			animatorStateTransition63410.duration = 0.15f;
			animatorStateTransition63410.exitTime = 0f;
			animatorStateTransition63410.hasExitTime = false;
			animatorStateTransition63410.hasFixedDuration = true;
			animatorStateTransition63410.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63410.offset = 0f;
			animatorStateTransition63410.orderedInterruption = true;
			animatorStateTransition63410.isExit = true;
			animatorStateTransition63410.mute = false;
			animatorStateTransition63410.solo = false;
			animatorStateTransition63410.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition63412 = rocketLauncherAnimatorState63218.AddExitTransition();
			animatorStateTransition63412.canTransitionToSelf = true;
			animatorStateTransition63412.duration = 0.15f;
			animatorStateTransition63412.exitTime = 0f;
			animatorStateTransition63412.hasExitTime = false;
			animatorStateTransition63412.hasFixedDuration = true;
			animatorStateTransition63412.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63412.offset = 0f;
			animatorStateTransition63412.orderedInterruption = true;
			animatorStateTransition63412.isExit = true;
			animatorStateTransition63412.mute = false;
			animatorStateTransition63412.solo = false;
			animatorStateTransition63412.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition63414 = dualPistolAnimatorState63212.AddExitTransition();
			animatorStateTransition63414.canTransitionToSelf = true;
			animatorStateTransition63414.duration = 0.15f;
			animatorStateTransition63414.exitTime = 0f;
			animatorStateTransition63414.hasExitTime = false;
			animatorStateTransition63414.hasFixedDuration = true;
			animatorStateTransition63414.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63414.offset = 0f;
			animatorStateTransition63414.orderedInterruption = true;
			animatorStateTransition63414.isExit = true;
			animatorStateTransition63414.mute = false;
			animatorStateTransition63414.solo = false;
			animatorStateTransition63414.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition63416 = pistolAnimatorState63216.AddExitTransition();
			animatorStateTransition63416.canTransitionToSelf = true;
			animatorStateTransition63416.duration = 0.15f;
			animatorStateTransition63416.exitTime = 0f;
			animatorStateTransition63416.hasExitTime = false;
			animatorStateTransition63416.hasFixedDuration = true;
			animatorStateTransition63416.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63416.offset = 0f;
			animatorStateTransition63416.orderedInterruption = true;
			animatorStateTransition63416.isExit = true;
			animatorStateTransition63416.mute = false;
			animatorStateTransition63416.solo = false;
			animatorStateTransition63416.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition63418 = swordAnimatorState63204.AddExitTransition();
			animatorStateTransition63418.canTransitionToSelf = true;
			animatorStateTransition63418.duration = 0.15f;
			animatorStateTransition63418.exitTime = 0f;
			animatorStateTransition63418.hasExitTime = false;
			animatorStateTransition63418.hasFixedDuration = true;
			animatorStateTransition63418.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63418.offset = 0f;
			animatorStateTransition63418.orderedInterruption = false;
			animatorStateTransition63418.isExit = true;
			animatorStateTransition63418.mute = false;
			animatorStateTransition63418.solo = false;
			animatorStateTransition63418.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition63422 = katanaAnimatorState63208.AddExitTransition();
			animatorStateTransition63422.canTransitionToSelf = true;
			animatorStateTransition63422.duration = 15f;
			animatorStateTransition63422.exitTime = 0f;
			animatorStateTransition63422.hasExitTime = false;
			animatorStateTransition63422.hasFixedDuration = true;
			animatorStateTransition63422.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63422.offset = 0f;
			animatorStateTransition63422.orderedInterruption = true;
			animatorStateTransition63422.isExit = true;
			animatorStateTransition63422.mute = false;
			animatorStateTransition63422.solo = false;
			animatorStateTransition63422.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition63426 = bowAnimatorState63210.AddExitTransition();
			animatorStateTransition63426.canTransitionToSelf = true;
			animatorStateTransition63426.duration = 0.15f;
			animatorStateTransition63426.exitTime = 0f;
			animatorStateTransition63426.hasExitTime = false;
			animatorStateTransition63426.hasFixedDuration = true;
			animatorStateTransition63426.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63426.offset = 0f;
			animatorStateTransition63426.orderedInterruption = true;
			animatorStateTransition63426.isExit = true;
			animatorStateTransition63426.mute = false;
			animatorStateTransition63426.solo = false;
			animatorStateTransition63426.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition63428 = knifeAnimatorState63206.AddExitTransition();
			animatorStateTransition63428.canTransitionToSelf = true;
			animatorStateTransition63428.duration = 0.15f;
			animatorStateTransition63428.exitTime = 0f;
			animatorStateTransition63428.hasExitTime = false;
			animatorStateTransition63428.hasFixedDuration = true;
			animatorStateTransition63428.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63428.offset = 0f;
			animatorStateTransition63428.orderedInterruption = true;
			animatorStateTransition63428.isExit = true;
			animatorStateTransition63428.mute = false;
			animatorStateTransition63428.solo = false;
			animatorStateTransition63428.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");


			// State Machine Transitions.
			var animatorStateTransition63092 = baseStateMachine1729063656.AddAnyStateTransition(swordAnimatorState63204);
			animatorStateTransition63092.canTransitionToSelf = false;
			animatorStateTransition63092.duration = 0.05f;
			animatorStateTransition63092.exitTime = 0.75f;
			animatorStateTransition63092.hasExitTime = false;
			animatorStateTransition63092.hasFixedDuration = true;
			animatorStateTransition63092.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63092.offset = 0f;
			animatorStateTransition63092.orderedInterruption = true;
			animatorStateTransition63092.isExit = false;
			animatorStateTransition63092.mute = false;
			animatorStateTransition63092.solo = false;
			animatorStateTransition63092.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition63092.AddCondition(AnimatorConditionMode.Equals, 22f, "Slot0ItemID");

			var animatorStateTransition63094 = baseStateMachine1729063656.AddAnyStateTransition(knifeAnimatorState63206);
			animatorStateTransition63094.canTransitionToSelf = false;
			animatorStateTransition63094.duration = 0.05f;
			animatorStateTransition63094.exitTime = 0.75f;
			animatorStateTransition63094.hasExitTime = false;
			animatorStateTransition63094.hasFixedDuration = true;
			animatorStateTransition63094.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63094.offset = 0f;
			animatorStateTransition63094.orderedInterruption = true;
			animatorStateTransition63094.isExit = false;
			animatorStateTransition63094.mute = false;
			animatorStateTransition63094.solo = false;
			animatorStateTransition63094.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition63094.AddCondition(AnimatorConditionMode.Equals, 23f, "Slot0ItemID");

			var animatorStateTransition63096 = baseStateMachine1729063656.AddAnyStateTransition(katanaAnimatorState63208);
			animatorStateTransition63096.canTransitionToSelf = false;
			animatorStateTransition63096.duration = 0.05f;
			animatorStateTransition63096.exitTime = 0.75f;
			animatorStateTransition63096.hasExitTime = false;
			animatorStateTransition63096.hasFixedDuration = true;
			animatorStateTransition63096.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63096.offset = 0f;
			animatorStateTransition63096.orderedInterruption = true;
			animatorStateTransition63096.isExit = false;
			animatorStateTransition63096.mute = false;
			animatorStateTransition63096.solo = false;
			animatorStateTransition63096.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition63096.AddCondition(AnimatorConditionMode.Equals, 24f, "Slot0ItemID");

			var animatorStateTransition63098 = baseStateMachine1729063656.AddAnyStateTransition(bowAnimatorState63210);
			animatorStateTransition63098.canTransitionToSelf = false;
			animatorStateTransition63098.duration = 0.05f;
			animatorStateTransition63098.exitTime = 0.75f;
			animatorStateTransition63098.hasExitTime = false;
			animatorStateTransition63098.hasFixedDuration = true;
			animatorStateTransition63098.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63098.offset = 0f;
			animatorStateTransition63098.orderedInterruption = true;
			animatorStateTransition63098.isExit = false;
			animatorStateTransition63098.mute = false;
			animatorStateTransition63098.solo = false;
			animatorStateTransition63098.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition63098.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot1ItemID");

			var animatorStateTransition63100 = baseStateMachine1729063656.AddAnyStateTransition(dualPistolAnimatorState63212);
			animatorStateTransition63100.canTransitionToSelf = false;
			animatorStateTransition63100.duration = 0.05f;
			animatorStateTransition63100.exitTime = 0.75f;
			animatorStateTransition63100.hasExitTime = false;
			animatorStateTransition63100.hasFixedDuration = true;
			animatorStateTransition63100.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63100.offset = 0f;
			animatorStateTransition63100.orderedInterruption = true;
			animatorStateTransition63100.isExit = false;
			animatorStateTransition63100.mute = false;
			animatorStateTransition63100.solo = false;
			animatorStateTransition63100.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition63100.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			animatorStateTransition63100.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot1ItemID");

			var animatorStateTransition63102 = baseStateMachine1729063656.AddAnyStateTransition(shotgunAnimatorState63214);
			animatorStateTransition63102.canTransitionToSelf = false;
			animatorStateTransition63102.duration = 0.05f;
			animatorStateTransition63102.exitTime = 0.75f;
			animatorStateTransition63102.hasExitTime = false;
			animatorStateTransition63102.hasFixedDuration = true;
			animatorStateTransition63102.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63102.offset = 0f;
			animatorStateTransition63102.orderedInterruption = true;
			animatorStateTransition63102.isExit = false;
			animatorStateTransition63102.mute = false;
			animatorStateTransition63102.solo = false;
			animatorStateTransition63102.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition63102.AddCondition(AnimatorConditionMode.Equals, 3f, "Slot0ItemID");

			var animatorStateTransition63104 = baseStateMachine1729063656.AddAnyStateTransition(pistolAnimatorState63216);
			animatorStateTransition63104.canTransitionToSelf = false;
			animatorStateTransition63104.duration = 0.05f;
			animatorStateTransition63104.exitTime = 0.75f;
			animatorStateTransition63104.hasExitTime = false;
			animatorStateTransition63104.hasFixedDuration = true;
			animatorStateTransition63104.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63104.offset = 0f;
			animatorStateTransition63104.orderedInterruption = true;
			animatorStateTransition63104.isExit = false;
			animatorStateTransition63104.mute = false;
			animatorStateTransition63104.solo = false;
			animatorStateTransition63104.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition63104.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			animatorStateTransition63104.AddCondition(AnimatorConditionMode.NotEqual, 2f, "Slot1ItemID");

			var animatorStateTransition63106 = baseStateMachine1729063656.AddAnyStateTransition(rocketLauncherAnimatorState63218);
			animatorStateTransition63106.canTransitionToSelf = false;
			animatorStateTransition63106.duration = 0.05f;
			animatorStateTransition63106.exitTime = 0.75f;
			animatorStateTransition63106.hasExitTime = false;
			animatorStateTransition63106.hasFixedDuration = true;
			animatorStateTransition63106.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63106.offset = 0f;
			animatorStateTransition63106.orderedInterruption = true;
			animatorStateTransition63106.isExit = false;
			animatorStateTransition63106.mute = false;
			animatorStateTransition63106.solo = false;
			animatorStateTransition63106.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition63106.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemID");

			var animatorStateTransition63108 = baseStateMachine1729063656.AddAnyStateTransition(assaultRifleAnimatorState63220);
			animatorStateTransition63108.canTransitionToSelf = false;
			animatorStateTransition63108.duration = 0.05f;
			animatorStateTransition63108.exitTime = 0.75f;
			animatorStateTransition63108.hasExitTime = false;
			animatorStateTransition63108.hasFixedDuration = true;
			animatorStateTransition63108.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63108.offset = 0f;
			animatorStateTransition63108.orderedInterruption = true;
			animatorStateTransition63108.isExit = false;
			animatorStateTransition63108.mute = false;
			animatorStateTransition63108.solo = false;
			animatorStateTransition63108.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition63108.AddCondition(AnimatorConditionMode.Equals, 1f, "Slot0ItemID");

			var animatorStateTransition63110 = baseStateMachine1729063656.AddAnyStateTransition(sniperRifleAnimatorState63222);
			animatorStateTransition63110.canTransitionToSelf = false;
			animatorStateTransition63110.duration = 0.05f;
			animatorStateTransition63110.exitTime = 0.75f;
			animatorStateTransition63110.hasExitTime = false;
			animatorStateTransition63110.hasFixedDuration = true;
			animatorStateTransition63110.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63110.offset = 0f;
			animatorStateTransition63110.orderedInterruption = true;
			animatorStateTransition63110.isExit = false;
			animatorStateTransition63110.mute = false;
			animatorStateTransition63110.solo = false;
			animatorStateTransition63110.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition63110.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemID");
		}
	}
}
