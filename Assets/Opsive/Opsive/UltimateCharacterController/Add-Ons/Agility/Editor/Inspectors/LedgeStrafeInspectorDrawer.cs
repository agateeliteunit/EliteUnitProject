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
	/// Draws a custom inspector for the LedgeStrafe Ability.
	/// </summary>
	[InspectorDrawer(typeof(LedgeStrafe))]
	public class LedgeStrafeInspectorDrawer : AbilityInspectorDrawer
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

			var baseStateMachine1709604672 = animatorController.layers[0].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1709604672.stateMachines.Length; ++j) {
					if (baseStateMachine1709604672.stateMachines[j].stateMachine.name == "Ledge Strafe") {
						baseStateMachine1709604672.RemoveStateMachine(baseStateMachine1709604672.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var ledgeStrafeIdleAnimationClip60408Path = AssetDatabase.GUIDToAssetPath("74100d50a4867ba4bbc2e29cb7155f66"); 
			var ledgeStrafeIdleAnimationClip60408 = AnimatorBuilder.GetAnimationClip(ledgeStrafeIdleAnimationClip60408Path, "LedgeStrafeIdle");
			var ledgeStrafeRightAnimationClip60416Path = AssetDatabase.GUIDToAssetPath("1f453c6b5910ecb46a0c7053d5cbc64e"); 
			var ledgeStrafeRightAnimationClip60416 = AnimatorBuilder.GetAnimationClip(ledgeStrafeRightAnimationClip60416Path, "LedgeStrafeRight");
			var ledgeStrafeLeftAnimationClip60418Path = AssetDatabase.GUIDToAssetPath("1f453c6b5910ecb46a0c7053d5cbc64e"); 
			var ledgeStrafeLeftAnimationClip60418 = AnimatorBuilder.GetAnimationClip(ledgeStrafeLeftAnimationClip60418Path, "LedgeStrafeLeft");

			// State Machine.
			var ledgeStrafeAnimatorStateMachine58240 = baseStateMachine1709604672.AddStateMachine("Ledge Strafe", new Vector3(624f, 108f, 0f));

			// States.
			var ledgeIdleAnimatorState59138 = ledgeStrafeAnimatorStateMachine58240.AddState("Ledge Idle", new Vector3(384f, 0f, 0f));
			ledgeIdleAnimatorState59138.motion = ledgeStrafeIdleAnimationClip60408;
			ledgeIdleAnimatorState59138.cycleOffset = 0f;
			ledgeIdleAnimatorState59138.cycleOffsetParameterActive = false;
			ledgeIdleAnimatorState59138.iKOnFeet = true;
			ledgeIdleAnimatorState59138.mirror = false;
			ledgeIdleAnimatorState59138.mirrorParameterActive = false;
			ledgeIdleAnimatorState59138.speed = 1f;
			ledgeIdleAnimatorState59138.speedParameterActive = false;
			ledgeIdleAnimatorState59138.writeDefaultValues = true;

			var ledgeStrafeAnimatorState59140 = ledgeStrafeAnimatorStateMachine58240.AddState("Ledge Strafe", new Vector3(384f, 108f, 0f));
			var ledgeStrafeAnimatorState59140blendTreeBlendTree60414 = new BlendTree();
			AssetDatabase.AddObjectToAsset(ledgeStrafeAnimatorState59140blendTreeBlendTree60414, animatorController);
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414.hideFlags = HideFlags.HideInHierarchy;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414.blendParameter = "HorizontalMovement";
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414.blendParameterY = "HorizontalMovement";
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414.blendType = BlendTreeType.Simple1D;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414.maxThreshold = 1f;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414.minThreshold = -1f;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414.name = "Blend Tree";
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414.useAutomaticThresholds = false;
			var ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child0 =  new ChildMotion();
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child0.motion = ledgeStrafeRightAnimationClip60416;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child0.cycleOffset = 0f;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child0.directBlendParameter = "HorizontalMovement";
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child0.mirror = false;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child0.position = new Vector2(0f, 0f);
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child0.threshold = -1f;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child0.timeScale = 2f;
			var ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child1 =  new ChildMotion();
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child1.motion = ledgeStrafeIdleAnimationClip60408;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child1.cycleOffset = 0f;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child1.directBlendParameter = "HorizontalMovement";
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child1.mirror = false;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child1.position = new Vector2(0f, 0f);
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child1.threshold = 0f;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child1.timeScale = 1f;
			var ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child2 =  new ChildMotion();
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child2.motion = ledgeStrafeLeftAnimationClip60418;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child2.cycleOffset = 0f;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child2.directBlendParameter = "HorizontalMovement";
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child2.mirror = false;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child2.position = new Vector2(0f, 0f);
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child2.threshold = 1f;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child2.timeScale = 2f;
			ledgeStrafeAnimatorState59140blendTreeBlendTree60414.children = new ChildMotion[] {
				ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child0,
				ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child1,
				ledgeStrafeAnimatorState59140blendTreeBlendTree60414Child2
			};
			ledgeStrafeAnimatorState59140.motion = ledgeStrafeAnimatorState59140blendTreeBlendTree60414;
			ledgeStrafeAnimatorState59140.cycleOffset = 0f;
			ledgeStrafeAnimatorState59140.cycleOffsetParameterActive = false;
			ledgeStrafeAnimatorState59140.iKOnFeet = true;
			ledgeStrafeAnimatorState59140.mirror = false;
			ledgeStrafeAnimatorState59140.mirrorParameterActive = false;
			ledgeStrafeAnimatorState59140.speed = 1f;
			ledgeStrafeAnimatorState59140.speedParameterActive = false;
			ledgeStrafeAnimatorState59140.writeDefaultValues = true;

			// State Machine Defaults.
			ledgeStrafeAnimatorStateMachine58240.anyStatePosition = new Vector3(50f, 20f, 0f);
			ledgeStrafeAnimatorStateMachine58240.defaultState = ledgeIdleAnimatorState59138;
			ledgeStrafeAnimatorStateMachine58240.entryPosition = new Vector3(50f, 120f, 0f);
			ledgeStrafeAnimatorStateMachine58240.exitPosition = new Vector3(800f, 120f, 0f);
			ledgeStrafeAnimatorStateMachine58240.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Transitions.
			var animatorStateTransition60404 = ledgeIdleAnimatorState59138.AddExitTransition();
			animatorStateTransition60404.canTransitionToSelf = true;
			animatorStateTransition60404.duration = 0.15f;
			animatorStateTransition60404.exitTime = 0.95f;
			animatorStateTransition60404.hasExitTime = false;
			animatorStateTransition60404.hasFixedDuration = true;
			animatorStateTransition60404.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60404.offset = 0f;
			animatorStateTransition60404.orderedInterruption = true;
			animatorStateTransition60404.isExit = true;
			animatorStateTransition60404.mute = false;
			animatorStateTransition60404.solo = false;
			animatorStateTransition60404.AddCondition(AnimatorConditionMode.NotEqual, 106f, "AbilityIndex");

			var animatorStateTransition60406 = ledgeIdleAnimatorState59138.AddTransition(ledgeStrafeAnimatorState59140);
			animatorStateTransition60406.canTransitionToSelf = true;
			animatorStateTransition60406.duration = 0.1f;
			animatorStateTransition60406.exitTime = 0.95f;
			animatorStateTransition60406.hasExitTime = false;
			animatorStateTransition60406.hasFixedDuration = true;
			animatorStateTransition60406.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60406.offset = 0.1f;
			animatorStateTransition60406.orderedInterruption = true;
			animatorStateTransition60406.isExit = false;
			animatorStateTransition60406.mute = false;
			animatorStateTransition60406.solo = false;
			animatorStateTransition60406.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			animatorStateTransition60406.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			var animatorStateTransition60410 = ledgeStrafeAnimatorState59140.AddExitTransition();
			animatorStateTransition60410.canTransitionToSelf = true;
			animatorStateTransition60410.duration = 0.15f;
			animatorStateTransition60410.exitTime = 0.95f;
			animatorStateTransition60410.hasExitTime = false;
			animatorStateTransition60410.hasFixedDuration = true;
			animatorStateTransition60410.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60410.offset = 0f;
			animatorStateTransition60410.orderedInterruption = true;
			animatorStateTransition60410.isExit = true;
			animatorStateTransition60410.mute = false;
			animatorStateTransition60410.solo = false;
			animatorStateTransition60410.AddCondition(AnimatorConditionMode.NotEqual, 106f, "AbilityIndex");

			var animatorStateTransition60412 = ledgeStrafeAnimatorState59140.AddTransition(ledgeIdleAnimatorState59138);
			animatorStateTransition60412.canTransitionToSelf = true;
			animatorStateTransition60412.duration = 0.25f;
			animatorStateTransition60412.exitTime = 0.91f;
			animatorStateTransition60412.hasExitTime = false;
			animatorStateTransition60412.hasFixedDuration = true;
			animatorStateTransition60412.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60412.offset = 0f;
			animatorStateTransition60412.orderedInterruption = true;
			animatorStateTransition60412.isExit = false;
			animatorStateTransition60412.mute = false;
			animatorStateTransition60412.solo = false;
			animatorStateTransition60412.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			animatorStateTransition60412.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");


			// State Machine Transitions.
			var animatorStateTransition58812 = baseStateMachine1709604672.AddAnyStateTransition(ledgeIdleAnimatorState59138);
			animatorStateTransition58812.canTransitionToSelf = false;
			animatorStateTransition58812.duration = 0.15f;
			animatorStateTransition58812.exitTime = 0.75f;
			animatorStateTransition58812.hasExitTime = false;
			animatorStateTransition58812.hasFixedDuration = true;
			animatorStateTransition58812.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58812.offset = 0f;
			animatorStateTransition58812.orderedInterruption = true;
			animatorStateTransition58812.isExit = false;
			animatorStateTransition58812.mute = false;
			animatorStateTransition58812.solo = false;
			animatorStateTransition58812.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58812.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			animatorStateTransition58812.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var animatorStateTransition58814 = baseStateMachine1709604672.AddAnyStateTransition(ledgeStrafeAnimatorState59140);
			animatorStateTransition58814.canTransitionToSelf = false;
			animatorStateTransition58814.duration = 0.15f;
			animatorStateTransition58814.exitTime = 0.75f;
			animatorStateTransition58814.hasExitTime = false;
			animatorStateTransition58814.hasFixedDuration = true;
			animatorStateTransition58814.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58814.offset = 0f;
			animatorStateTransition58814.orderedInterruption = true;
			animatorStateTransition58814.isExit = false;
			animatorStateTransition58814.mute = false;
			animatorStateTransition58814.solo = false;
			animatorStateTransition58814.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58814.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			animatorStateTransition58814.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			if (animatorController.layers.Length <= 5) {
				Debug.LogWarning("Warning: The animator controller does not contain the same number of layers as the demo animator. All of the animations cannot be added.");
				return;
			}

			var baseStateMachine1808754806 = animatorController.layers[5].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1808754806.stateMachines.Length; ++j) {
					if (baseStateMachine1808754806.stateMachines[j].stateMachine.name == "Ledge Strafe") {
						baseStateMachine1808754806.RemoveStateMachine(baseStateMachine1808754806.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var dualPistolIdleAnimationClip46536Path = AssetDatabase.GUIDToAssetPath("abd3b20228164e44b8fa1597ee6dfe31"); 
			var dualPistolIdleAnimationClip46536 = AnimatorBuilder.GetAnimationClip(dualPistolIdleAnimationClip46536Path, "DualPistolIdle");
			var shieldIdleAnimationClip46600Path = AssetDatabase.GUIDToAssetPath("17718399930c6ea4b9a734dbe54df24f"); 
			var shieldIdleAnimationClip46600 = AnimatorBuilder.GetAnimationClip(shieldIdleAnimationClip46600Path, "ShieldIdle");

			// State Machine.
			var ledgeStrafeAnimatorStateMachine62646 = baseStateMachine1808754806.AddStateMachine("Ledge Strafe", new Vector3(852f, 12f, 0f));

			// States.
			var dualPistolAnimatorState62792 = ledgeStrafeAnimatorStateMachine62646.AddState("Dual Pistol", new Vector3(384f, 12f, 0f));
			dualPistolAnimatorState62792.motion = dualPistolIdleAnimationClip46536;
			dualPistolAnimatorState62792.cycleOffset = 0f;
			dualPistolAnimatorState62792.cycleOffsetParameterActive = false;
			dualPistolAnimatorState62792.iKOnFeet = false;
			dualPistolAnimatorState62792.mirror = false;
			dualPistolAnimatorState62792.mirrorParameterActive = false;
			dualPistolAnimatorState62792.speed = 1f;
			dualPistolAnimatorState62792.speedParameterActive = false;
			dualPistolAnimatorState62792.writeDefaultValues = true;

			var shieldAnimatorState62794 = ledgeStrafeAnimatorStateMachine62646.AddState("Shield", new Vector3(384f, 72f, 0f));
			shieldAnimatorState62794.motion = shieldIdleAnimationClip46600;
			shieldAnimatorState62794.cycleOffset = 0f;
			shieldAnimatorState62794.cycleOffsetParameterActive = false;
			shieldAnimatorState62794.iKOnFeet = false;
			shieldAnimatorState62794.mirror = false;
			shieldAnimatorState62794.mirrorParameterActive = false;
			shieldAnimatorState62794.speed = 1f;
			shieldAnimatorState62794.speedParameterActive = false;
			shieldAnimatorState62794.writeDefaultValues = true;

			// State Machine Defaults.
			ledgeStrafeAnimatorStateMachine62646.anyStatePosition = new Vector3(48f, 48f, 0f);
			ledgeStrafeAnimatorStateMachine62646.defaultState = dualPistolAnimatorState62792;
			ledgeStrafeAnimatorStateMachine62646.entryPosition = new Vector3(48f, 0f, 0f);
			ledgeStrafeAnimatorStateMachine62646.exitPosition = new Vector3(780f, 60f, 0f);
			ledgeStrafeAnimatorStateMachine62646.parentStateMachinePosition = new Vector3(756f, 0f, 0f);

			// State Transitions.
			var animatorStateTransition62934 = dualPistolAnimatorState62792.AddExitTransition();
			animatorStateTransition62934.canTransitionToSelf = true;
			animatorStateTransition62934.duration = 0.1f;
			animatorStateTransition62934.exitTime = 0f;
			animatorStateTransition62934.hasExitTime = false;
			animatorStateTransition62934.hasFixedDuration = true;
			animatorStateTransition62934.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62934.offset = 0f;
			animatorStateTransition62934.orderedInterruption = true;
			animatorStateTransition62934.isExit = true;
			animatorStateTransition62934.mute = false;
			animatorStateTransition62934.solo = false;
			animatorStateTransition62934.AddCondition(AnimatorConditionMode.NotEqual, 106f, "AbilityIndex");

			var animatorStateTransition62936 = shieldAnimatorState62794.AddExitTransition();
			animatorStateTransition62936.canTransitionToSelf = true;
			animatorStateTransition62936.duration = 0.1f;
			animatorStateTransition62936.exitTime = 0f;
			animatorStateTransition62936.hasExitTime = false;
			animatorStateTransition62936.hasFixedDuration = true;
			animatorStateTransition62936.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62936.offset = 0f;
			animatorStateTransition62936.orderedInterruption = true;
			animatorStateTransition62936.isExit = true;
			animatorStateTransition62936.mute = false;
			animatorStateTransition62936.solo = false;
			animatorStateTransition62936.AddCondition(AnimatorConditionMode.NotEqual, 106f, "AbilityIndex");


			// State Machine Transitions.
			var animatorStateTransition62712 = baseStateMachine1808754806.AddAnyStateTransition(dualPistolAnimatorState62792);
			animatorStateTransition62712.canTransitionToSelf = false;
			animatorStateTransition62712.duration = 0.15f;
			animatorStateTransition62712.exitTime = 0.75f;
			animatorStateTransition62712.hasExitTime = false;
			animatorStateTransition62712.hasFixedDuration = true;
			animatorStateTransition62712.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62712.offset = 0f;
			animatorStateTransition62712.orderedInterruption = true;
			animatorStateTransition62712.isExit = false;
			animatorStateTransition62712.mute = false;
			animatorStateTransition62712.solo = false;
			animatorStateTransition62712.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			animatorStateTransition62712.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot1ItemID");

			var animatorStateTransition62714 = baseStateMachine1808754806.AddAnyStateTransition(shieldAnimatorState62794);
			animatorStateTransition62714.canTransitionToSelf = false;
			animatorStateTransition62714.duration = 0.15f;
			animatorStateTransition62714.exitTime = 0.75f;
			animatorStateTransition62714.hasExitTime = false;
			animatorStateTransition62714.hasFixedDuration = true;
			animatorStateTransition62714.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62714.offset = 0f;
			animatorStateTransition62714.orderedInterruption = true;
			animatorStateTransition62714.isExit = false;
			animatorStateTransition62714.mute = false;
			animatorStateTransition62714.solo = false;
			animatorStateTransition62714.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			animatorStateTransition62714.AddCondition(AnimatorConditionMode.Equals, 25f, "Slot0ItemID");

			if (animatorController.layers.Length <= 6) {
				Debug.LogWarning("Warning: The animator controller does not contain the same number of layers as the demo animator. All of the animations cannot be added.");
				return;
			}

			var baseStateMachine1808755430 = animatorController.layers[6].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1808755430.stateMachines.Length; ++j) {
					if (baseStateMachine1808755430.stateMachines[j].stateMachine.name == "Ledge Strafe") {
						baseStateMachine1808755430.RemoveStateMachine(baseStateMachine1808755430.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var swordIdleMovementAnimationClip46820Path = AssetDatabase.GUIDToAssetPath("7491132715cdf964889b5fc2729270e1"); 
			var swordIdleMovementAnimationClip46820 = AnimatorBuilder.GetAnimationClip(swordIdleMovementAnimationClip46820Path, "SwordIdleMovement");
			var knifeIdleMovementAnimationClip46922Path = AssetDatabase.GUIDToAssetPath("fa9162997c077584ebabf8919a1c1518"); 
			var knifeIdleMovementAnimationClip46922 = AnimatorBuilder.GetAnimationClip(knifeIdleMovementAnimationClip46922Path, "KnifeIdleMovement");

			// State Machine.
			var ledgeStrafeAnimatorStateMachine63014 = baseStateMachine1808755430.AddStateMachine("Ledge Strafe", new Vector3(852f, 12f, 0f));

			// States.
			var swordAnimatorState63200 = ledgeStrafeAnimatorStateMachine63014.AddState("Sword", new Vector3(384f, 84f, 0f));
			swordAnimatorState63200.motion = swordIdleMovementAnimationClip46820;
			swordAnimatorState63200.cycleOffset = 0f;
			swordAnimatorState63200.cycleOffsetParameterActive = false;
			swordAnimatorState63200.iKOnFeet = false;
			swordAnimatorState63200.mirror = false;
			swordAnimatorState63200.mirrorParameterActive = false;
			swordAnimatorState63200.speed = 1f;
			swordAnimatorState63200.speedParameterActive = false;
			swordAnimatorState63200.writeDefaultValues = true;

			var knifeAnimatorState63198 = ledgeStrafeAnimatorStateMachine63014.AddState("Knife", new Vector3(384f, 24f, 0f));
			knifeAnimatorState63198.motion = knifeIdleMovementAnimationClip46922;
			knifeAnimatorState63198.cycleOffset = 0f;
			knifeAnimatorState63198.cycleOffsetParameterActive = false;
			knifeAnimatorState63198.iKOnFeet = false;
			knifeAnimatorState63198.mirror = false;
			knifeAnimatorState63198.mirrorParameterActive = false;
			knifeAnimatorState63198.speed = 1f;
			knifeAnimatorState63198.speedParameterActive = false;
			knifeAnimatorState63198.writeDefaultValues = true;

			var dualPistolAnimatorState63202 = ledgeStrafeAnimatorStateMachine63014.AddState("Dual Pistol", new Vector3(384f, -36f, 0f));
			dualPistolAnimatorState63202.motion = dualPistolIdleAnimationClip46536;
			dualPistolAnimatorState63202.cycleOffset = 0f;
			dualPistolAnimatorState63202.cycleOffsetParameterActive = false;
			dualPistolAnimatorState63202.iKOnFeet = false;
			dualPistolAnimatorState63202.mirror = false;
			dualPistolAnimatorState63202.mirrorParameterActive = false;
			dualPistolAnimatorState63202.speed = 1f;
			dualPistolAnimatorState63202.speedParameterActive = false;
			dualPistolAnimatorState63202.writeDefaultValues = true;

			// State Machine Defaults.
			ledgeStrafeAnimatorStateMachine63014.anyStatePosition = new Vector3(50f, 20f, 0f);
			ledgeStrafeAnimatorStateMachine63014.defaultState = swordAnimatorState63200;
			ledgeStrafeAnimatorStateMachine63014.entryPosition = new Vector3(48f, -24f, 0f);
			ledgeStrafeAnimatorStateMachine63014.exitPosition = new Vector3(780f, 24f, 0f);
			ledgeStrafeAnimatorStateMachine63014.parentStateMachinePosition = new Vector3(756f, -48f, 0f);

			// State Transitions.
			var animatorStateTransition63400 = swordAnimatorState63200.AddExitTransition();
			animatorStateTransition63400.canTransitionToSelf = true;
			animatorStateTransition63400.duration = 0.1f;
			animatorStateTransition63400.exitTime = 0f;
			animatorStateTransition63400.hasExitTime = false;
			animatorStateTransition63400.hasFixedDuration = true;
			animatorStateTransition63400.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63400.offset = 0f;
			animatorStateTransition63400.orderedInterruption = false;
			animatorStateTransition63400.isExit = true;
			animatorStateTransition63400.mute = false;
			animatorStateTransition63400.solo = false;
			animatorStateTransition63400.AddCondition(AnimatorConditionMode.NotEqual, 106f, "AbilityIndex");

			var animatorStateTransition63402 = knifeAnimatorState63198.AddExitTransition();
			animatorStateTransition63402.canTransitionToSelf = true;
			animatorStateTransition63402.duration = 0.1f;
			animatorStateTransition63402.exitTime = 0f;
			animatorStateTransition63402.hasExitTime = false;
			animatorStateTransition63402.hasFixedDuration = true;
			animatorStateTransition63402.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63402.offset = 0f;
			animatorStateTransition63402.orderedInterruption = true;
			animatorStateTransition63402.isExit = true;
			animatorStateTransition63402.mute = false;
			animatorStateTransition63402.solo = false;
			animatorStateTransition63402.AddCondition(AnimatorConditionMode.NotEqual, 106f, "AbilityIndex");

			var animatorStateTransition63404 = dualPistolAnimatorState63202.AddExitTransition();
			animatorStateTransition63404.canTransitionToSelf = true;
			animatorStateTransition63404.duration = 0.1f;
			animatorStateTransition63404.exitTime = 0f;
			animatorStateTransition63404.hasExitTime = false;
			animatorStateTransition63404.hasFixedDuration = true;
			animatorStateTransition63404.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63404.offset = 0f;
			animatorStateTransition63404.orderedInterruption = true;
			animatorStateTransition63404.isExit = true;
			animatorStateTransition63404.mute = false;
			animatorStateTransition63404.solo = false;
			animatorStateTransition63404.AddCondition(AnimatorConditionMode.NotEqual, 106f, "AbilityIndex");


			// State Machine Transitions.
			var animatorStateTransition63086 = baseStateMachine1808755430.AddAnyStateTransition(knifeAnimatorState63198);
			animatorStateTransition63086.canTransitionToSelf = false;
			animatorStateTransition63086.duration = 0.15f;
			animatorStateTransition63086.exitTime = 0.75f;
			animatorStateTransition63086.hasExitTime = false;
			animatorStateTransition63086.hasFixedDuration = true;
			animatorStateTransition63086.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63086.offset = 0f;
			animatorStateTransition63086.orderedInterruption = true;
			animatorStateTransition63086.isExit = false;
			animatorStateTransition63086.mute = false;
			animatorStateTransition63086.solo = false;
			animatorStateTransition63086.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			animatorStateTransition63086.AddCondition(AnimatorConditionMode.Equals, 23f, "Slot0ItemID");

			var animatorStateTransition63088 = baseStateMachine1808755430.AddAnyStateTransition(swordAnimatorState63200);
			animatorStateTransition63088.canTransitionToSelf = false;
			animatorStateTransition63088.duration = 0.15f;
			animatorStateTransition63088.exitTime = 0.75f;
			animatorStateTransition63088.hasExitTime = false;
			animatorStateTransition63088.hasFixedDuration = true;
			animatorStateTransition63088.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63088.offset = 0f;
			animatorStateTransition63088.orderedInterruption = true;
			animatorStateTransition63088.isExit = false;
			animatorStateTransition63088.mute = false;
			animatorStateTransition63088.solo = false;
			animatorStateTransition63088.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			animatorStateTransition63088.AddCondition(AnimatorConditionMode.Equals, 22f, "Slot0ItemID");

			var animatorStateTransition63090 = baseStateMachine1808755430.AddAnyStateTransition(dualPistolAnimatorState63202);
			animatorStateTransition63090.canTransitionToSelf = false;
			animatorStateTransition63090.duration = 0.15f;
			animatorStateTransition63090.exitTime = 0.75f;
			animatorStateTransition63090.hasExitTime = false;
			animatorStateTransition63090.hasFixedDuration = true;
			animatorStateTransition63090.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63090.offset = 0f;
			animatorStateTransition63090.orderedInterruption = true;
			animatorStateTransition63090.isExit = false;
			animatorStateTransition63090.mute = false;
			animatorStateTransition63090.solo = false;
			animatorStateTransition63090.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			animatorStateTransition63090.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
		}
	}
}
