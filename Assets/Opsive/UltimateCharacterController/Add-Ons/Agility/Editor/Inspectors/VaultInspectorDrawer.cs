/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

namespace Opsive.UltimateCharacterController.AddOns.Agility.Editor.Inspectors.Character.Abilities
{
    using Opsive.Shared.Editor.Inspectors;
	using Opsive.UltimateCharacterController.Editor.Inspectors.Character.Abilities;
	using Opsive.UltimateCharacterController.Editor.Utility;
	using UnityEditor;
	using UnityEditor.Animations;
	using UnityEngine;

	/// <summary>
	/// Draws a custom inspector for the Vault Ability.
	/// </summary>
	[InspectorDrawer(typeof(Vault))]
	public class VaultInspectorDrawer : DetectObjectAbilityBaseInspectorDrawer
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

			var baseStateMachine1672904516 = animatorController.layers[0].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1672904516.stateMachines.Length; ++j) {
					if (baseStateMachine1672904516.stateMachines[j].stateMachine.name == "Vault") {
						baseStateMachine1672904516.RemoveStateMachine(baseStateMachine1672904516.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var vaultAnimationClip60456Path = AssetDatabase.GUIDToAssetPath("0399bfd67aded3d45b9a9478528c1759"); 
			var vaultAnimationClip60456 = AnimatorBuilder.GetAnimationClip(vaultAnimationClip60456Path, "Vault");
			var vaultWalkAnimationClip60458Path = AssetDatabase.GUIDToAssetPath("efb0ea01363a21e41adf6d34dd4ba46c"); 
			var vaultWalkAnimationClip60458 = AnimatorBuilder.GetAnimationClip(vaultWalkAnimationClip60458Path, "VaultWalk");
			var vaultRunAnimationClip60460Path = AssetDatabase.GUIDToAssetPath("258a82687d525724f8c461b7279ae336"); 
			var vaultRunAnimationClip60460 = AnimatorBuilder.GetAnimationClip(vaultRunAnimationClip60460Path, "VaultRun");

			// State Machine.
			var vaultAnimatorStateMachine58244 = baseStateMachine1672904516.AddStateMachine("Vault", new Vector3(624f, 204f, 0f));

			// States.
			var vaultAnimatorState59158 = vaultAnimatorStateMachine58244.AddState("Vault", new Vector3(384f, 36f, 0f));
			var vaultAnimatorState59158blendTreeBlendTree60454 = new BlendTree();
			AssetDatabase.AddObjectToAsset(vaultAnimatorState59158blendTreeBlendTree60454, animatorController);
			vaultAnimatorState59158blendTreeBlendTree60454.hideFlags = HideFlags.HideInHierarchy;
			vaultAnimatorState59158blendTreeBlendTree60454.blendParameter = "AbilityFloatData";
			vaultAnimatorState59158blendTreeBlendTree60454.blendParameterY = "HorizontalMovement";
			vaultAnimatorState59158blendTreeBlendTree60454.blendType = BlendTreeType.Simple1D;
			vaultAnimatorState59158blendTreeBlendTree60454.maxThreshold = 8f;
			vaultAnimatorState59158blendTreeBlendTree60454.minThreshold = 0f;
			vaultAnimatorState59158blendTreeBlendTree60454.name = "Blend Tree";
			vaultAnimatorState59158blendTreeBlendTree60454.useAutomaticThresholds = false;
			var vaultAnimatorState59158blendTreeBlendTree60454Child0 =  new ChildMotion();
			vaultAnimatorState59158blendTreeBlendTree60454Child0.motion = vaultAnimationClip60456;
			vaultAnimatorState59158blendTreeBlendTree60454Child0.cycleOffset = 0f;
			vaultAnimatorState59158blendTreeBlendTree60454Child0.directBlendParameter = "HorizontalMovement";
			vaultAnimatorState59158blendTreeBlendTree60454Child0.mirror = false;
			vaultAnimatorState59158blendTreeBlendTree60454Child0.position = new Vector2(0f, 0f);
			vaultAnimatorState59158blendTreeBlendTree60454Child0.threshold = 0f;
			vaultAnimatorState59158blendTreeBlendTree60454Child0.timeScale = 1.75f;
			var vaultAnimatorState59158blendTreeBlendTree60454Child1 =  new ChildMotion();
			vaultAnimatorState59158blendTreeBlendTree60454Child1.motion = vaultWalkAnimationClip60458;
			vaultAnimatorState59158blendTreeBlendTree60454Child1.cycleOffset = 0f;
			vaultAnimatorState59158blendTreeBlendTree60454Child1.directBlendParameter = "HorizontalMovement";
			vaultAnimatorState59158blendTreeBlendTree60454Child1.mirror = false;
			vaultAnimatorState59158blendTreeBlendTree60454Child1.position = new Vector2(0f, 0f);
			vaultAnimatorState59158blendTreeBlendTree60454Child1.threshold = 4f;
			vaultAnimatorState59158blendTreeBlendTree60454Child1.timeScale = 1.75f;
			var vaultAnimatorState59158blendTreeBlendTree60454Child2 =  new ChildMotion();
			vaultAnimatorState59158blendTreeBlendTree60454Child2.motion = vaultRunAnimationClip60460;
			vaultAnimatorState59158blendTreeBlendTree60454Child2.cycleOffset = 0f;
			vaultAnimatorState59158blendTreeBlendTree60454Child2.directBlendParameter = "HorizontalMovement";
			vaultAnimatorState59158blendTreeBlendTree60454Child2.mirror = false;
			vaultAnimatorState59158blendTreeBlendTree60454Child2.position = new Vector2(0f, 0f);
			vaultAnimatorState59158blendTreeBlendTree60454Child2.threshold = 8f;
			vaultAnimatorState59158blendTreeBlendTree60454Child2.timeScale = 1.75f;
			vaultAnimatorState59158blendTreeBlendTree60454.children = new ChildMotion[] {
				vaultAnimatorState59158blendTreeBlendTree60454Child0,
				vaultAnimatorState59158blendTreeBlendTree60454Child1,
				vaultAnimatorState59158blendTreeBlendTree60454Child2
			};
			vaultAnimatorState59158.motion = vaultAnimatorState59158blendTreeBlendTree60454;
			vaultAnimatorState59158.cycleOffset = 0f;
			vaultAnimatorState59158.cycleOffsetParameterActive = false;
			vaultAnimatorState59158.iKOnFeet = true;
			vaultAnimatorState59158.mirror = false;
			vaultAnimatorState59158.mirrorParameterActive = false;
			vaultAnimatorState59158.speed = 1f;
			vaultAnimatorState59158.speedParameterActive = false;
			vaultAnimatorState59158.writeDefaultValues = true;

			// State Machine Defaults.
			vaultAnimatorStateMachine58244.anyStatePosition = new Vector3(50f, 20f, 0f);
			vaultAnimatorStateMachine58244.defaultState = vaultAnimatorState59158;
			vaultAnimatorStateMachine58244.entryPosition = new Vector3(50f, 120f, 0f);
			vaultAnimatorStateMachine58244.exitPosition = new Vector3(800f, 120f, 0f);
			vaultAnimatorStateMachine58244.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Transitions.
			var animatorStateTransition60452 = vaultAnimatorState59158.AddExitTransition();
			animatorStateTransition60452.canTransitionToSelf = true;
			animatorStateTransition60452.duration = 0.15f;
			animatorStateTransition60452.exitTime = 0.99f;
			animatorStateTransition60452.hasExitTime = false;
			animatorStateTransition60452.hasFixedDuration = true;
			animatorStateTransition60452.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60452.offset = 0f;
			animatorStateTransition60452.orderedInterruption = true;
			animatorStateTransition60452.isExit = true;
			animatorStateTransition60452.mute = false;
			animatorStateTransition60452.solo = false;
			animatorStateTransition60452.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");


			// State Machine Transitions.
			var animatorStateTransition58832 = baseStateMachine1672904516.AddAnyStateTransition(vaultAnimatorState59158);
			animatorStateTransition58832.canTransitionToSelf = false;
			animatorStateTransition58832.duration = 0.1f;
			animatorStateTransition58832.exitTime = 0.75f;
			animatorStateTransition58832.hasExitTime = false;
			animatorStateTransition58832.hasFixedDuration = true;
			animatorStateTransition58832.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58832.offset = 0f;
			animatorStateTransition58832.orderedInterruption = true;
			animatorStateTransition58832.isExit = false;
			animatorStateTransition58832.mute = false;
			animatorStateTransition58832.solo = false;
			animatorStateTransition58832.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58832.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");

			if (animatorController.layers.Length <= 5) {
				Debug.LogWarning("Warning: The animator controller does not contain the same number of layers as the demo animator. All of the animations cannot be added.");
				return;
			}

			var baseStateMachine1656711290 = animatorController.layers[5].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1656711290.stateMachines.Length; ++j) {
					if (baseStateMachine1656711290.stateMachines[j].stateMachine.name == "Vault") {
						baseStateMachine1656711290.RemoveStateMachine(baseStateMachine1656711290.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var assaultRifleVaultAnimationClip62972Path = AssetDatabase.GUIDToAssetPath("194b765e69b16a54c95f816909686574"); 
			var assaultRifleVaultAnimationClip62972 = AnimatorBuilder.GetAnimationClip(assaultRifleVaultAnimationClip62972Path, "AssaultRifleVault");
			var sniperRifleVaultAnimationClip62976Path = AssetDatabase.GUIDToAssetPath("5acbfc759a7379b438891af30302e377"); 
			var sniperRifleVaultAnimationClip62976 = AnimatorBuilder.GetAnimationClip(sniperRifleVaultAnimationClip62976Path, "SniperRifleVault");
			var pistolVaultAnimationClip62980Path = AssetDatabase.GUIDToAssetPath("6be7d0bcdc299f048902da3da3f6db84"); 
			var pistolVaultAnimationClip62980 = AnimatorBuilder.GetAnimationClip(pistolVaultAnimationClip62980Path, "PistolVault");
			var shieldVaultAnimationClip62984Path = AssetDatabase.GUIDToAssetPath("1bccb806fb9e01f40ae2a500cdc3cc6e"); 
			var shieldVaultAnimationClip62984 = AnimatorBuilder.GetAnimationClip(shieldVaultAnimationClip62984Path, "ShieldVault");
			var rocketLauncherVaultAnimationClip62988Path = AssetDatabase.GUIDToAssetPath("b1e8de7271784f84dbb18ac8391720d7"); 
			var rocketLauncherVaultAnimationClip62988 = AnimatorBuilder.GetAnimationClip(rocketLauncherVaultAnimationClip62988Path, "RocketLauncherVault");
			var dualPistolVaultAnimationClip62992Path = AssetDatabase.GUIDToAssetPath("f991d0293f754c442ad09f19059391c1"); 
			var dualPistolVaultAnimationClip62992 = AnimatorBuilder.GetAnimationClip(dualPistolVaultAnimationClip62992Path, "DualPistolVault");
			var shotgunVaultAnimationClip62996Path = AssetDatabase.GUIDToAssetPath("6b5a0abe350de1f46a9931f384ae8667"); 
			var shotgunVaultAnimationClip62996 = AnimatorBuilder.GetAnimationClip(shotgunVaultAnimationClip62996Path, "ShotgunVault");
			var bowVaultAnimationClip63000Path = AssetDatabase.GUIDToAssetPath("5a127a4aefca9f04797502ef9a805037"); 
			var bowVaultAnimationClip63000 = AnimatorBuilder.GetAnimationClip(bowVaultAnimationClip63000Path, "BowVault");

			// State Machine.
			var vaultAnimatorStateMachine62650 = baseStateMachine1656711290.AddStateMachine("Vault", new Vector3(852f, 156f, 0f));

			// States.
			var assaultRifleAnimatorState62818 = vaultAnimatorStateMachine62650.AddState("Assault Rifle", new Vector3(384f, -48f, 0f));
			assaultRifleAnimatorState62818.motion = assaultRifleVaultAnimationClip62972;
			assaultRifleAnimatorState62818.cycleOffset = 0f;
			assaultRifleAnimatorState62818.cycleOffsetParameterActive = false;
			assaultRifleAnimatorState62818.iKOnFeet = false;
			assaultRifleAnimatorState62818.mirror = false;
			assaultRifleAnimatorState62818.mirrorParameterActive = false;
			assaultRifleAnimatorState62818.speed = 1.75f;
			assaultRifleAnimatorState62818.speedParameterActive = false;
			assaultRifleAnimatorState62818.writeDefaultValues = true;

			var sniperRifleAnimatorState62822 = vaultAnimatorStateMachine62650.AddState("Sniper Rifle", new Vector3(384f, 372f, 0f));
			sniperRifleAnimatorState62822.motion = sniperRifleVaultAnimationClip62976;
			sniperRifleAnimatorState62822.cycleOffset = 0f;
			sniperRifleAnimatorState62822.cycleOffsetParameterActive = false;
			sniperRifleAnimatorState62822.iKOnFeet = false;
			sniperRifleAnimatorState62822.mirror = false;
			sniperRifleAnimatorState62822.mirrorParameterActive = false;
			sniperRifleAnimatorState62822.speed = 1.75f;
			sniperRifleAnimatorState62822.speedParameterActive = false;
			sniperRifleAnimatorState62822.writeDefaultValues = true;

			var pistolAnimatorState62816 = vaultAnimatorStateMachine62650.AddState("Pistol", new Vector3(384f, 132f, 0f));
			pistolAnimatorState62816.motion = pistolVaultAnimationClip62980;
			pistolAnimatorState62816.cycleOffset = 0f;
			pistolAnimatorState62816.cycleOffsetParameterActive = false;
			pistolAnimatorState62816.iKOnFeet = false;
			pistolAnimatorState62816.mirror = false;
			pistolAnimatorState62816.mirrorParameterActive = false;
			pistolAnimatorState62816.speed = 1.75f;
			pistolAnimatorState62816.speedParameterActive = false;
			pistolAnimatorState62816.writeDefaultValues = true;

			var shieldAnimatorState62812 = vaultAnimatorStateMachine62650.AddState("Shield", new Vector3(384f, 252f, 0f));
			shieldAnimatorState62812.motion = shieldVaultAnimationClip62984;
			shieldAnimatorState62812.cycleOffset = 0f;
			shieldAnimatorState62812.cycleOffsetParameterActive = false;
			shieldAnimatorState62812.iKOnFeet = false;
			shieldAnimatorState62812.mirror = false;
			shieldAnimatorState62812.mirrorParameterActive = false;
			shieldAnimatorState62812.speed = 1.75f;
			shieldAnimatorState62812.speedParameterActive = false;
			shieldAnimatorState62812.writeDefaultValues = true;

			var rocketLauncherAnimatorState62826 = vaultAnimatorStateMachine62650.AddState("Rocket Launcher", new Vector3(384f, 192f, 0f));
			rocketLauncherAnimatorState62826.motion = rocketLauncherVaultAnimationClip62988;
			rocketLauncherAnimatorState62826.cycleOffset = 0f;
			rocketLauncherAnimatorState62826.cycleOffsetParameterActive = false;
			rocketLauncherAnimatorState62826.iKOnFeet = false;
			rocketLauncherAnimatorState62826.mirror = false;
			rocketLauncherAnimatorState62826.mirrorParameterActive = false;
			rocketLauncherAnimatorState62826.speed = 1.75f;
			rocketLauncherAnimatorState62826.speedParameterActive = false;
			rocketLauncherAnimatorState62826.writeDefaultValues = true;

			var dualPistolAnimatorState62814 = vaultAnimatorStateMachine62650.AddState("Dual Pistol", new Vector3(384f, 72f, 0f));
			dualPistolAnimatorState62814.motion = dualPistolVaultAnimationClip62992;
			dualPistolAnimatorState62814.cycleOffset = 0f;
			dualPistolAnimatorState62814.cycleOffsetParameterActive = false;
			dualPistolAnimatorState62814.iKOnFeet = false;
			dualPistolAnimatorState62814.mirror = false;
			dualPistolAnimatorState62814.mirrorParameterActive = false;
			dualPistolAnimatorState62814.speed = 1.75f;
			dualPistolAnimatorState62814.speedParameterActive = false;
			dualPistolAnimatorState62814.writeDefaultValues = true;

			var shotgunAnimatorState62824 = vaultAnimatorStateMachine62650.AddState("Shotgun", new Vector3(384f, 312f, 0f));
			shotgunAnimatorState62824.motion = shotgunVaultAnimationClip62996;
			shotgunAnimatorState62824.cycleOffset = 0f;
			shotgunAnimatorState62824.cycleOffsetParameterActive = false;
			shotgunAnimatorState62824.iKOnFeet = false;
			shotgunAnimatorState62824.mirror = false;
			shotgunAnimatorState62824.mirrorParameterActive = false;
			shotgunAnimatorState62824.speed = 1.75f;
			shotgunAnimatorState62824.speedParameterActive = false;
			shotgunAnimatorState62824.writeDefaultValues = true;

			var bowAnimatorState62820 = vaultAnimatorStateMachine62650.AddState("Bow", new Vector3(384f, 12f, 0f));
			bowAnimatorState62820.motion = bowVaultAnimationClip63000;
			bowAnimatorState62820.cycleOffset = 0f;
			bowAnimatorState62820.cycleOffsetParameterActive = false;
			bowAnimatorState62820.iKOnFeet = false;
			bowAnimatorState62820.mirror = false;
			bowAnimatorState62820.mirrorParameterActive = false;
			bowAnimatorState62820.speed = 1.75f;
			bowAnimatorState62820.speedParameterActive = false;
			bowAnimatorState62820.writeDefaultValues = true;

			// State Machine Defaults.
			vaultAnimatorStateMachine62650.anyStatePosition = new Vector3(48f, 144f, 0f);
			vaultAnimatorStateMachine62650.defaultState = assaultRifleAnimatorState62818;
			vaultAnimatorStateMachine62650.entryPosition = new Vector3(48f, 96f, 0f);
			vaultAnimatorStateMachine62650.exitPosition = new Vector3(780f, 156f, 0f);
			vaultAnimatorStateMachine62650.parentStateMachinePosition = new Vector3(756f, 72f, 0f);

			// State Transitions.
			var animatorStateTransition62970 = assaultRifleAnimatorState62818.AddExitTransition();
			animatorStateTransition62970.canTransitionToSelf = true;
			animatorStateTransition62970.duration = 0.15f;
			animatorStateTransition62970.exitTime = 0f;
			animatorStateTransition62970.hasExitTime = false;
			animatorStateTransition62970.hasFixedDuration = true;
			animatorStateTransition62970.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62970.offset = 0f;
			animatorStateTransition62970.orderedInterruption = true;
			animatorStateTransition62970.isExit = true;
			animatorStateTransition62970.mute = false;
			animatorStateTransition62970.solo = false;
			animatorStateTransition62970.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition62974 = sniperRifleAnimatorState62822.AddExitTransition();
			animatorStateTransition62974.canTransitionToSelf = true;
			animatorStateTransition62974.duration = 0.15f;
			animatorStateTransition62974.exitTime = 0f;
			animatorStateTransition62974.hasExitTime = false;
			animatorStateTransition62974.hasFixedDuration = true;
			animatorStateTransition62974.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62974.offset = 0f;
			animatorStateTransition62974.orderedInterruption = true;
			animatorStateTransition62974.isExit = true;
			animatorStateTransition62974.mute = false;
			animatorStateTransition62974.solo = false;
			animatorStateTransition62974.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition62978 = pistolAnimatorState62816.AddExitTransition();
			animatorStateTransition62978.canTransitionToSelf = true;
			animatorStateTransition62978.duration = 0.15f;
			animatorStateTransition62978.exitTime = 0f;
			animatorStateTransition62978.hasExitTime = false;
			animatorStateTransition62978.hasFixedDuration = true;
			animatorStateTransition62978.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62978.offset = 0f;
			animatorStateTransition62978.orderedInterruption = true;
			animatorStateTransition62978.isExit = true;
			animatorStateTransition62978.mute = false;
			animatorStateTransition62978.solo = false;
			animatorStateTransition62978.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition62982 = shieldAnimatorState62812.AddExitTransition();
			animatorStateTransition62982.canTransitionToSelf = true;
			animatorStateTransition62982.duration = 0.15f;
			animatorStateTransition62982.exitTime = 0f;
			animatorStateTransition62982.hasExitTime = false;
			animatorStateTransition62982.hasFixedDuration = true;
			animatorStateTransition62982.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62982.offset = 0f;
			animatorStateTransition62982.orderedInterruption = true;
			animatorStateTransition62982.isExit = true;
			animatorStateTransition62982.mute = false;
			animatorStateTransition62982.solo = false;
			animatorStateTransition62982.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition62986 = rocketLauncherAnimatorState62826.AddExitTransition();
			animatorStateTransition62986.canTransitionToSelf = true;
			animatorStateTransition62986.duration = 0.15f;
			animatorStateTransition62986.exitTime = 0f;
			animatorStateTransition62986.hasExitTime = false;
			animatorStateTransition62986.hasFixedDuration = true;
			animatorStateTransition62986.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62986.offset = 0f;
			animatorStateTransition62986.orderedInterruption = true;
			animatorStateTransition62986.isExit = true;
			animatorStateTransition62986.mute = false;
			animatorStateTransition62986.solo = false;
			animatorStateTransition62986.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition62990 = dualPistolAnimatorState62814.AddExitTransition();
			animatorStateTransition62990.canTransitionToSelf = true;
			animatorStateTransition62990.duration = 0.15f;
			animatorStateTransition62990.exitTime = 0f;
			animatorStateTransition62990.hasExitTime = false;
			animatorStateTransition62990.hasFixedDuration = true;
			animatorStateTransition62990.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62990.offset = 0f;
			animatorStateTransition62990.orderedInterruption = true;
			animatorStateTransition62990.isExit = true;
			animatorStateTransition62990.mute = false;
			animatorStateTransition62990.solo = false;
			animatorStateTransition62990.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition62994 = shotgunAnimatorState62824.AddExitTransition();
			animatorStateTransition62994.canTransitionToSelf = true;
			animatorStateTransition62994.duration = 0.15f;
			animatorStateTransition62994.exitTime = 0f;
			animatorStateTransition62994.hasExitTime = false;
			animatorStateTransition62994.hasFixedDuration = true;
			animatorStateTransition62994.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62994.offset = 0f;
			animatorStateTransition62994.orderedInterruption = true;
			animatorStateTransition62994.isExit = true;
			animatorStateTransition62994.mute = false;
			animatorStateTransition62994.solo = false;
			animatorStateTransition62994.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition62998 = bowAnimatorState62820.AddExitTransition();
			animatorStateTransition62998.canTransitionToSelf = true;
			animatorStateTransition62998.duration = 0.15f;
			animatorStateTransition62998.exitTime = 0f;
			animatorStateTransition62998.hasExitTime = false;
			animatorStateTransition62998.hasFixedDuration = true;
			animatorStateTransition62998.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62998.offset = 0f;
			animatorStateTransition62998.orderedInterruption = true;
			animatorStateTransition62998.isExit = true;
			animatorStateTransition62998.mute = false;
			animatorStateTransition62998.solo = false;
			animatorStateTransition62998.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");


			// State Machine Transitions.
			var animatorStateTransition62732 = baseStateMachine1656711290.AddAnyStateTransition(shieldAnimatorState62812);
			animatorStateTransition62732.canTransitionToSelf = false;
			animatorStateTransition62732.duration = 0.1f;
			animatorStateTransition62732.exitTime = 0.75f;
			animatorStateTransition62732.hasExitTime = false;
			animatorStateTransition62732.hasFixedDuration = true;
			animatorStateTransition62732.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62732.offset = 0f;
			animatorStateTransition62732.orderedInterruption = true;
			animatorStateTransition62732.isExit = false;
			animatorStateTransition62732.mute = false;
			animatorStateTransition62732.solo = false;
			animatorStateTransition62732.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition62732.AddCondition(AnimatorConditionMode.Equals, 25f, "Slot1ItemID");

			var animatorStateTransition62734 = baseStateMachine1656711290.AddAnyStateTransition(dualPistolAnimatorState62814);
			animatorStateTransition62734.canTransitionToSelf = false;
			animatorStateTransition62734.duration = 0.1f;
			animatorStateTransition62734.exitTime = 0.75f;
			animatorStateTransition62734.hasExitTime = false;
			animatorStateTransition62734.hasFixedDuration = true;
			animatorStateTransition62734.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62734.offset = 0f;
			animatorStateTransition62734.orderedInterruption = true;
			animatorStateTransition62734.isExit = false;
			animatorStateTransition62734.mute = false;
			animatorStateTransition62734.solo = false;
			animatorStateTransition62734.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition62734.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			animatorStateTransition62734.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot1ItemID");

			var animatorStateTransition62736 = baseStateMachine1656711290.AddAnyStateTransition(pistolAnimatorState62816);
			animatorStateTransition62736.canTransitionToSelf = false;
			animatorStateTransition62736.duration = 0.1f;
			animatorStateTransition62736.exitTime = 0.75f;
			animatorStateTransition62736.hasExitTime = false;
			animatorStateTransition62736.hasFixedDuration = true;
			animatorStateTransition62736.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62736.offset = 0f;
			animatorStateTransition62736.orderedInterruption = true;
			animatorStateTransition62736.isExit = false;
			animatorStateTransition62736.mute = false;
			animatorStateTransition62736.solo = false;
			animatorStateTransition62736.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition62736.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			animatorStateTransition62736.AddCondition(AnimatorConditionMode.NotEqual, 2f, "Slot1ItemID");

			var animatorStateTransition62738 = baseStateMachine1656711290.AddAnyStateTransition(assaultRifleAnimatorState62818);
			animatorStateTransition62738.canTransitionToSelf = false;
			animatorStateTransition62738.duration = 0.1f;
			animatorStateTransition62738.exitTime = 0.75f;
			animatorStateTransition62738.hasExitTime = false;
			animatorStateTransition62738.hasFixedDuration = true;
			animatorStateTransition62738.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62738.offset = 0f;
			animatorStateTransition62738.orderedInterruption = true;
			animatorStateTransition62738.isExit = false;
			animatorStateTransition62738.mute = false;
			animatorStateTransition62738.solo = false;
			animatorStateTransition62738.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition62738.AddCondition(AnimatorConditionMode.Equals, 1f, "Slot0ItemID");

			var animatorStateTransition62740 = baseStateMachine1656711290.AddAnyStateTransition(bowAnimatorState62820);
			animatorStateTransition62740.canTransitionToSelf = false;
			animatorStateTransition62740.duration = 0.1f;
			animatorStateTransition62740.exitTime = 0.75f;
			animatorStateTransition62740.hasExitTime = false;
			animatorStateTransition62740.hasFixedDuration = true;
			animatorStateTransition62740.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62740.offset = 0f;
			animatorStateTransition62740.orderedInterruption = true;
			animatorStateTransition62740.isExit = false;
			animatorStateTransition62740.mute = false;
			animatorStateTransition62740.solo = false;
			animatorStateTransition62740.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition62740.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot1ItemID");

			var animatorStateTransition62742 = baseStateMachine1656711290.AddAnyStateTransition(sniperRifleAnimatorState62822);
			animatorStateTransition62742.canTransitionToSelf = false;
			animatorStateTransition62742.duration = 0.1f;
			animatorStateTransition62742.exitTime = 0.75f;
			animatorStateTransition62742.hasExitTime = false;
			animatorStateTransition62742.hasFixedDuration = true;
			animatorStateTransition62742.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62742.offset = 0f;
			animatorStateTransition62742.orderedInterruption = true;
			animatorStateTransition62742.isExit = false;
			animatorStateTransition62742.mute = false;
			animatorStateTransition62742.solo = false;
			animatorStateTransition62742.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition62742.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemID");

			var animatorStateTransition62744 = baseStateMachine1656711290.AddAnyStateTransition(shotgunAnimatorState62824);
			animatorStateTransition62744.canTransitionToSelf = false;
			animatorStateTransition62744.duration = 0.1f;
			animatorStateTransition62744.exitTime = 0.75f;
			animatorStateTransition62744.hasExitTime = false;
			animatorStateTransition62744.hasFixedDuration = true;
			animatorStateTransition62744.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62744.offset = 0f;
			animatorStateTransition62744.orderedInterruption = true;
			animatorStateTransition62744.isExit = false;
			animatorStateTransition62744.mute = false;
			animatorStateTransition62744.solo = false;
			animatorStateTransition62744.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition62744.AddCondition(AnimatorConditionMode.Equals, 3f, "Slot0ItemID");

			var animatorStateTransition62746 = baseStateMachine1656711290.AddAnyStateTransition(rocketLauncherAnimatorState62826);
			animatorStateTransition62746.canTransitionToSelf = false;
			animatorStateTransition62746.duration = 0.1f;
			animatorStateTransition62746.exitTime = 0.75f;
			animatorStateTransition62746.hasExitTime = false;
			animatorStateTransition62746.hasFixedDuration = true;
			animatorStateTransition62746.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition62746.offset = 0f;
			animatorStateTransition62746.orderedInterruption = true;
			animatorStateTransition62746.isExit = false;
			animatorStateTransition62746.mute = false;
			animatorStateTransition62746.solo = false;
			animatorStateTransition62746.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition62746.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemID");

			if (animatorController.layers.Length <= 6) {
				Debug.LogWarning("Warning: The animator controller does not contain the same number of layers as the demo animator. All of the animations cannot be added.");
				return;
			}

			var baseStateMachine1705994986 = animatorController.layers[6].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1705994986.stateMachines.Length; ++j) {
					if (baseStateMachine1705994986.stateMachines[j].stateMachine.name == "Vault") {
						baseStateMachine1705994986.RemoveStateMachine(baseStateMachine1705994986.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var swordVaultAnimationClip63434Path = AssetDatabase.GUIDToAssetPath("120b0f3e59a781a44b765e2205535382"); 
			var swordVaultAnimationClip63434 = AnimatorBuilder.GetAnimationClip(swordVaultAnimationClip63434Path, "SwordVault");
			var katanaVaultAnimationClip63450Path = AssetDatabase.GUIDToAssetPath("f64e92e464549d343ac586eb3ca9f381"); 
			var katanaVaultAnimationClip63450 = AnimatorBuilder.GetAnimationClip(katanaVaultAnimationClip63450Path, "KatanaVault");
			var knifeVaultAnimationClip63456Path = AssetDatabase.GUIDToAssetPath("2c917cc202a5edc4e8dda8662217d2d5"); 
			var knifeVaultAnimationClip63456 = AnimatorBuilder.GetAnimationClip(knifeVaultAnimationClip63456Path, "KnifeVault");
			var fragGrenadeVaultAnimationClip63460Path = AssetDatabase.GUIDToAssetPath("ed618ef5a99858840b36d7837d93418a"); 
			var fragGrenadeVaultAnimationClip63460 = AnimatorBuilder.GetAnimationClip(fragGrenadeVaultAnimationClip63460Path, "FragGrenadeVault");

			// State Machine.
			var vaultAnimatorStateMachine63018 = baseStateMachine1705994986.AddStateMachine("Vault", new Vector3(852f, 108f, 0f));

			// States.
			var swordAnimatorState63224 = vaultAnimatorStateMachine63018.AddState("Sword", new Vector3(384f, 372f, 0f));
			swordAnimatorState63224.motion = swordVaultAnimationClip63434;
			swordAnimatorState63224.cycleOffset = 0f;
			swordAnimatorState63224.cycleOffsetParameterActive = false;
			swordAnimatorState63224.iKOnFeet = false;
			swordAnimatorState63224.mirror = false;
			swordAnimatorState63224.mirrorParameterActive = false;
			swordAnimatorState63224.speed = 1.75f;
			swordAnimatorState63224.speedParameterActive = false;
			swordAnimatorState63224.writeDefaultValues = true;

			var shotgunAnimatorState63234 = vaultAnimatorStateMachine63018.AddState("Shotgun", new Vector3(384f, 252f, 0f));
			shotgunAnimatorState63234.motion = shotgunVaultAnimationClip62996;
			shotgunAnimatorState63234.cycleOffset = 0f;
			shotgunAnimatorState63234.cycleOffsetParameterActive = false;
			shotgunAnimatorState63234.iKOnFeet = false;
			shotgunAnimatorState63234.mirror = false;
			shotgunAnimatorState63234.mirrorParameterActive = false;
			shotgunAnimatorState63234.speed = 1.75f;
			shotgunAnimatorState63234.speedParameterActive = false;
			shotgunAnimatorState63234.writeDefaultValues = true;

			var pistolAnimatorState63236 = vaultAnimatorStateMachine63018.AddState("Pistol", new Vector3(384f, 132f, 0f));
			pistolAnimatorState63236.motion = pistolVaultAnimationClip62980;
			pistolAnimatorState63236.cycleOffset = 0f;
			pistolAnimatorState63236.cycleOffsetParameterActive = false;
			pistolAnimatorState63236.iKOnFeet = false;
			pistolAnimatorState63236.mirror = false;
			pistolAnimatorState63236.mirrorParameterActive = false;
			pistolAnimatorState63236.speed = 1.75f;
			pistolAnimatorState63236.speedParameterActive = false;
			pistolAnimatorState63236.writeDefaultValues = true;

			var sniperRifleAnimatorState63242 = vaultAnimatorStateMachine63018.AddState("Sniper Rifle", new Vector3(384f, 312f, 0f));
			sniperRifleAnimatorState63242.motion = sniperRifleVaultAnimationClip62976;
			sniperRifleAnimatorState63242.cycleOffset = 0f;
			sniperRifleAnimatorState63242.cycleOffsetParameterActive = false;
			sniperRifleAnimatorState63242.iKOnFeet = false;
			sniperRifleAnimatorState63242.mirror = false;
			sniperRifleAnimatorState63242.mirrorParameterActive = false;
			sniperRifleAnimatorState63242.speed = 1.75f;
			sniperRifleAnimatorState63242.speedParameterActive = false;
			sniperRifleAnimatorState63242.writeDefaultValues = true;

			var dualPistolAnimatorState63232 = vaultAnimatorStateMachine63018.AddState("Dual Pistol", new Vector3(384f, -108f, 0f));
			dualPistolAnimatorState63232.motion = dualPistolVaultAnimationClip62992;
			dualPistolAnimatorState63232.cycleOffset = 0f;
			dualPistolAnimatorState63232.cycleOffsetParameterActive = false;
			dualPistolAnimatorState63232.iKOnFeet = false;
			dualPistolAnimatorState63232.mirror = false;
			dualPistolAnimatorState63232.mirrorParameterActive = false;
			dualPistolAnimatorState63232.speed = 1.75f;
			dualPistolAnimatorState63232.speedParameterActive = false;
			dualPistolAnimatorState63232.writeDefaultValues = true;

			var assaultRifleAnimatorState63240 = vaultAnimatorStateMachine63018.AddState("Assault Rifle", new Vector3(384f, -228f, 0f));
			assaultRifleAnimatorState63240.motion = assaultRifleVaultAnimationClip62972;
			assaultRifleAnimatorState63240.cycleOffset = 0f;
			assaultRifleAnimatorState63240.cycleOffsetParameterActive = false;
			assaultRifleAnimatorState63240.iKOnFeet = false;
			assaultRifleAnimatorState63240.mirror = false;
			assaultRifleAnimatorState63240.mirrorParameterActive = false;
			assaultRifleAnimatorState63240.speed = 1.75f;
			assaultRifleAnimatorState63240.speedParameterActive = false;
			assaultRifleAnimatorState63240.writeDefaultValues = true;

			var rocketLauncherAnimatorState63238 = vaultAnimatorStateMachine63018.AddState("Rocket Launcher", new Vector3(384f, 192f, 0f));
			rocketLauncherAnimatorState63238.motion = rocketLauncherVaultAnimationClip62988;
			rocketLauncherAnimatorState63238.cycleOffset = 0f;
			rocketLauncherAnimatorState63238.cycleOffsetParameterActive = false;
			rocketLauncherAnimatorState63238.iKOnFeet = false;
			rocketLauncherAnimatorState63238.mirror = false;
			rocketLauncherAnimatorState63238.mirrorParameterActive = false;
			rocketLauncherAnimatorState63238.speed = 1.75f;
			rocketLauncherAnimatorState63238.speedParameterActive = false;
			rocketLauncherAnimatorState63238.writeDefaultValues = true;

			var katanaAnimatorState63228 = vaultAnimatorStateMachine63018.AddState("Katana", new Vector3(384f, 12f, 0f));
			katanaAnimatorState63228.motion = katanaVaultAnimationClip63450;
			katanaAnimatorState63228.cycleOffset = 0f;
			katanaAnimatorState63228.cycleOffsetParameterActive = false;
			katanaAnimatorState63228.iKOnFeet = false;
			katanaAnimatorState63228.mirror = false;
			katanaAnimatorState63228.mirrorParameterActive = false;
			katanaAnimatorState63228.speed = 1.75f;
			katanaAnimatorState63228.speedParameterActive = false;
			katanaAnimatorState63228.writeDefaultValues = true;

			var bowAnimatorState63230 = vaultAnimatorStateMachine63018.AddState("Bow", new Vector3(384f, -168f, 0f));
			bowAnimatorState63230.motion = bowVaultAnimationClip63000;
			bowAnimatorState63230.cycleOffset = 0f;
			bowAnimatorState63230.cycleOffsetParameterActive = false;
			bowAnimatorState63230.iKOnFeet = false;
			bowAnimatorState63230.mirror = false;
			bowAnimatorState63230.mirrorParameterActive = false;
			bowAnimatorState63230.speed = 1.75f;
			bowAnimatorState63230.speedParameterActive = false;
			bowAnimatorState63230.writeDefaultValues = true;

			var knifeAnimatorState63226 = vaultAnimatorStateMachine63018.AddState("Knife", new Vector3(384f, 72f, 0f));
			knifeAnimatorState63226.motion = knifeVaultAnimationClip63456;
			knifeAnimatorState63226.cycleOffset = 0f;
			knifeAnimatorState63226.cycleOffsetParameterActive = false;
			knifeAnimatorState63226.iKOnFeet = false;
			knifeAnimatorState63226.mirror = false;
			knifeAnimatorState63226.mirrorParameterActive = false;
			knifeAnimatorState63226.speed = 1.75f;
			knifeAnimatorState63226.speedParameterActive = false;
			knifeAnimatorState63226.writeDefaultValues = true;

			var fragGrenadeAnimatorState63244 = vaultAnimatorStateMachine63018.AddState("Frag Grenade", new Vector3(384f, -48f, 0f));
			fragGrenadeAnimatorState63244.motion = fragGrenadeVaultAnimationClip63460;
			fragGrenadeAnimatorState63244.cycleOffset = 0f;
			fragGrenadeAnimatorState63244.cycleOffsetParameterActive = false;
			fragGrenadeAnimatorState63244.iKOnFeet = false;
			fragGrenadeAnimatorState63244.mirror = false;
			fragGrenadeAnimatorState63244.mirrorParameterActive = false;
			fragGrenadeAnimatorState63244.speed = 1.75f;
			fragGrenadeAnimatorState63244.speedParameterActive = false;
			fragGrenadeAnimatorState63244.writeDefaultValues = true;

			// State Machine Defaults.
			vaultAnimatorStateMachine63018.anyStatePosition = new Vector3(48f, 72f, 0f);
			vaultAnimatorStateMachine63018.defaultState = assaultRifleAnimatorState63240;
			vaultAnimatorStateMachine63018.entryPosition = new Vector3(48f, 24f, 0f);
			vaultAnimatorStateMachine63018.exitPosition = new Vector3(768f, 72f, 0f);
			vaultAnimatorStateMachine63018.parentStateMachinePosition = new Vector3(756f, 0f, 0f);

			// State Transitions.
			var animatorStateTransition63432 = swordAnimatorState63224.AddExitTransition();
			animatorStateTransition63432.canTransitionToSelf = true;
			animatorStateTransition63432.duration = 0.15f;
			animatorStateTransition63432.exitTime = 0f;
			animatorStateTransition63432.hasExitTime = false;
			animatorStateTransition63432.hasFixedDuration = true;
			animatorStateTransition63432.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63432.offset = 0f;
			animatorStateTransition63432.orderedInterruption = true;
			animatorStateTransition63432.isExit = true;
			animatorStateTransition63432.mute = false;
			animatorStateTransition63432.solo = false;
			animatorStateTransition63432.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition63436 = shotgunAnimatorState63234.AddExitTransition();
			animatorStateTransition63436.canTransitionToSelf = true;
			animatorStateTransition63436.duration = 0.15f;
			animatorStateTransition63436.exitTime = 0f;
			animatorStateTransition63436.hasExitTime = false;
			animatorStateTransition63436.hasFixedDuration = true;
			animatorStateTransition63436.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63436.offset = 0f;
			animatorStateTransition63436.orderedInterruption = true;
			animatorStateTransition63436.isExit = true;
			animatorStateTransition63436.mute = false;
			animatorStateTransition63436.solo = false;
			animatorStateTransition63436.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition63438 = pistolAnimatorState63236.AddExitTransition();
			animatorStateTransition63438.canTransitionToSelf = true;
			animatorStateTransition63438.duration = 0.15f;
			animatorStateTransition63438.exitTime = 0f;
			animatorStateTransition63438.hasExitTime = false;
			animatorStateTransition63438.hasFixedDuration = true;
			animatorStateTransition63438.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63438.offset = 0f;
			animatorStateTransition63438.orderedInterruption = true;
			animatorStateTransition63438.isExit = true;
			animatorStateTransition63438.mute = false;
			animatorStateTransition63438.solo = false;
			animatorStateTransition63438.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition63440 = sniperRifleAnimatorState63242.AddExitTransition();
			animatorStateTransition63440.canTransitionToSelf = true;
			animatorStateTransition63440.duration = 0.15f;
			animatorStateTransition63440.exitTime = 0f;
			animatorStateTransition63440.hasExitTime = false;
			animatorStateTransition63440.hasFixedDuration = true;
			animatorStateTransition63440.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63440.offset = 0f;
			animatorStateTransition63440.orderedInterruption = true;
			animatorStateTransition63440.isExit = true;
			animatorStateTransition63440.mute = false;
			animatorStateTransition63440.solo = false;
			animatorStateTransition63440.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition63442 = dualPistolAnimatorState63232.AddExitTransition();
			animatorStateTransition63442.canTransitionToSelf = true;
			animatorStateTransition63442.duration = 0.15f;
			animatorStateTransition63442.exitTime = 0f;
			animatorStateTransition63442.hasExitTime = false;
			animatorStateTransition63442.hasFixedDuration = true;
			animatorStateTransition63442.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63442.offset = 0f;
			animatorStateTransition63442.orderedInterruption = true;
			animatorStateTransition63442.isExit = true;
			animatorStateTransition63442.mute = false;
			animatorStateTransition63442.solo = false;
			animatorStateTransition63442.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition63444 = assaultRifleAnimatorState63240.AddExitTransition();
			animatorStateTransition63444.canTransitionToSelf = true;
			animatorStateTransition63444.duration = 0.15f;
			animatorStateTransition63444.exitTime = 0f;
			animatorStateTransition63444.hasExitTime = false;
			animatorStateTransition63444.hasFixedDuration = true;
			animatorStateTransition63444.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63444.offset = 0f;
			animatorStateTransition63444.orderedInterruption = true;
			animatorStateTransition63444.isExit = true;
			animatorStateTransition63444.mute = false;
			animatorStateTransition63444.solo = false;
			animatorStateTransition63444.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition63446 = rocketLauncherAnimatorState63238.AddExitTransition();
			animatorStateTransition63446.canTransitionToSelf = true;
			animatorStateTransition63446.duration = 0.15f;
			animatorStateTransition63446.exitTime = 0f;
			animatorStateTransition63446.hasExitTime = false;
			animatorStateTransition63446.hasFixedDuration = true;
			animatorStateTransition63446.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63446.offset = 0f;
			animatorStateTransition63446.orderedInterruption = true;
			animatorStateTransition63446.isExit = true;
			animatorStateTransition63446.mute = false;
			animatorStateTransition63446.solo = false;
			animatorStateTransition63446.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition63448 = katanaAnimatorState63228.AddExitTransition();
			animatorStateTransition63448.canTransitionToSelf = true;
			animatorStateTransition63448.duration = 0.15f;
			animatorStateTransition63448.exitTime = 0f;
			animatorStateTransition63448.hasExitTime = false;
			animatorStateTransition63448.hasFixedDuration = true;
			animatorStateTransition63448.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63448.offset = 0f;
			animatorStateTransition63448.orderedInterruption = true;
			animatorStateTransition63448.isExit = true;
			animatorStateTransition63448.mute = false;
			animatorStateTransition63448.solo = false;
			animatorStateTransition63448.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition63452 = bowAnimatorState63230.AddExitTransition();
			animatorStateTransition63452.canTransitionToSelf = true;
			animatorStateTransition63452.duration = 0.15f;
			animatorStateTransition63452.exitTime = 0f;
			animatorStateTransition63452.hasExitTime = false;
			animatorStateTransition63452.hasFixedDuration = true;
			animatorStateTransition63452.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63452.offset = 0f;
			animatorStateTransition63452.orderedInterruption = true;
			animatorStateTransition63452.isExit = true;
			animatorStateTransition63452.mute = false;
			animatorStateTransition63452.solo = false;
			animatorStateTransition63452.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition63454 = knifeAnimatorState63226.AddExitTransition();
			animatorStateTransition63454.canTransitionToSelf = true;
			animatorStateTransition63454.duration = 0.15f;
			animatorStateTransition63454.exitTime = 0f;
			animatorStateTransition63454.hasExitTime = false;
			animatorStateTransition63454.hasFixedDuration = true;
			animatorStateTransition63454.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63454.offset = 0f;
			animatorStateTransition63454.orderedInterruption = true;
			animatorStateTransition63454.isExit = true;
			animatorStateTransition63454.mute = false;
			animatorStateTransition63454.solo = false;
			animatorStateTransition63454.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var animatorStateTransition63458 = fragGrenadeAnimatorState63244.AddExitTransition();
			animatorStateTransition63458.canTransitionToSelf = true;
			animatorStateTransition63458.duration = 0.15f;
			animatorStateTransition63458.exitTime = 0f;
			animatorStateTransition63458.hasExitTime = false;
			animatorStateTransition63458.hasFixedDuration = true;
			animatorStateTransition63458.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63458.offset = 0f;
			animatorStateTransition63458.orderedInterruption = true;
			animatorStateTransition63458.isExit = true;
			animatorStateTransition63458.mute = false;
			animatorStateTransition63458.solo = false;
			animatorStateTransition63458.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");


			// State Machine Transitions.
			var animatorStateTransition63112 = baseStateMachine1705994986.AddAnyStateTransition(swordAnimatorState63224);
			animatorStateTransition63112.canTransitionToSelf = false;
			animatorStateTransition63112.duration = 0.1f;
			animatorStateTransition63112.exitTime = 0.75f;
			animatorStateTransition63112.hasExitTime = false;
			animatorStateTransition63112.hasFixedDuration = true;
			animatorStateTransition63112.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63112.offset = 0f;
			animatorStateTransition63112.orderedInterruption = true;
			animatorStateTransition63112.isExit = false;
			animatorStateTransition63112.mute = false;
			animatorStateTransition63112.solo = false;
			animatorStateTransition63112.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition63112.AddCondition(AnimatorConditionMode.Equals, 22f, "Slot0ItemID");

			var animatorStateTransition63114 = baseStateMachine1705994986.AddAnyStateTransition(knifeAnimatorState63226);
			animatorStateTransition63114.canTransitionToSelf = false;
			animatorStateTransition63114.duration = 0.1f;
			animatorStateTransition63114.exitTime = 0.75f;
			animatorStateTransition63114.hasExitTime = false;
			animatorStateTransition63114.hasFixedDuration = true;
			animatorStateTransition63114.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63114.offset = 0f;
			animatorStateTransition63114.orderedInterruption = true;
			animatorStateTransition63114.isExit = false;
			animatorStateTransition63114.mute = false;
			animatorStateTransition63114.solo = false;
			animatorStateTransition63114.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition63114.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition63114.AddCondition(AnimatorConditionMode.Equals, 23f, "Slot0ItemID");

			var animatorStateTransition63116 = baseStateMachine1705994986.AddAnyStateTransition(katanaAnimatorState63228);
			animatorStateTransition63116.canTransitionToSelf = false;
			animatorStateTransition63116.duration = 0.1f;
			animatorStateTransition63116.exitTime = 0.75f;
			animatorStateTransition63116.hasExitTime = false;
			animatorStateTransition63116.hasFixedDuration = true;
			animatorStateTransition63116.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63116.offset = 0f;
			animatorStateTransition63116.orderedInterruption = true;
			animatorStateTransition63116.isExit = false;
			animatorStateTransition63116.mute = false;
			animatorStateTransition63116.solo = false;
			animatorStateTransition63116.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition63116.AddCondition(AnimatorConditionMode.Equals, 24f, "Slot0ItemID");

			var animatorStateTransition63118 = baseStateMachine1705994986.AddAnyStateTransition(bowAnimatorState63230);
			animatorStateTransition63118.canTransitionToSelf = false;
			animatorStateTransition63118.duration = 0.1f;
			animatorStateTransition63118.exitTime = 0.75f;
			animatorStateTransition63118.hasExitTime = false;
			animatorStateTransition63118.hasFixedDuration = true;
			animatorStateTransition63118.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63118.offset = 0f;
			animatorStateTransition63118.orderedInterruption = true;
			animatorStateTransition63118.isExit = false;
			animatorStateTransition63118.mute = false;
			animatorStateTransition63118.solo = false;
			animatorStateTransition63118.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition63118.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot1ItemID");

			var animatorStateTransition63120 = baseStateMachine1705994986.AddAnyStateTransition(dualPistolAnimatorState63232);
			animatorStateTransition63120.canTransitionToSelf = false;
			animatorStateTransition63120.duration = 0.1f;
			animatorStateTransition63120.exitTime = 0.75f;
			animatorStateTransition63120.hasExitTime = false;
			animatorStateTransition63120.hasFixedDuration = true;
			animatorStateTransition63120.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63120.offset = 0f;
			animatorStateTransition63120.orderedInterruption = true;
			animatorStateTransition63120.isExit = false;
			animatorStateTransition63120.mute = false;
			animatorStateTransition63120.solo = false;
			animatorStateTransition63120.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition63120.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			animatorStateTransition63120.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot1ItemID");

			var animatorStateTransition63122 = baseStateMachine1705994986.AddAnyStateTransition(shotgunAnimatorState63234);
			animatorStateTransition63122.canTransitionToSelf = false;
			animatorStateTransition63122.duration = 0.1f;
			animatorStateTransition63122.exitTime = 0.75f;
			animatorStateTransition63122.hasExitTime = false;
			animatorStateTransition63122.hasFixedDuration = true;
			animatorStateTransition63122.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63122.offset = 0f;
			animatorStateTransition63122.orderedInterruption = true;
			animatorStateTransition63122.isExit = false;
			animatorStateTransition63122.mute = false;
			animatorStateTransition63122.solo = false;
			animatorStateTransition63122.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition63122.AddCondition(AnimatorConditionMode.Equals, 3f, "Slot0ItemID");

			var animatorStateTransition63124 = baseStateMachine1705994986.AddAnyStateTransition(pistolAnimatorState63236);
			animatorStateTransition63124.canTransitionToSelf = false;
			animatorStateTransition63124.duration = 0.1f;
			animatorStateTransition63124.exitTime = 0.75f;
			animatorStateTransition63124.hasExitTime = false;
			animatorStateTransition63124.hasFixedDuration = true;
			animatorStateTransition63124.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63124.offset = 0f;
			animatorStateTransition63124.orderedInterruption = true;
			animatorStateTransition63124.isExit = false;
			animatorStateTransition63124.mute = false;
			animatorStateTransition63124.solo = false;
			animatorStateTransition63124.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition63124.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			animatorStateTransition63124.AddCondition(AnimatorConditionMode.NotEqual, 2f, "Slot1ItemID");

			var animatorStateTransition63126 = baseStateMachine1705994986.AddAnyStateTransition(rocketLauncherAnimatorState63238);
			animatorStateTransition63126.canTransitionToSelf = false;
			animatorStateTransition63126.duration = 0.1f;
			animatorStateTransition63126.exitTime = 0.75f;
			animatorStateTransition63126.hasExitTime = false;
			animatorStateTransition63126.hasFixedDuration = true;
			animatorStateTransition63126.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63126.offset = 0f;
			animatorStateTransition63126.orderedInterruption = true;
			animatorStateTransition63126.isExit = false;
			animatorStateTransition63126.mute = false;
			animatorStateTransition63126.solo = false;
			animatorStateTransition63126.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition63126.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemID");

			var animatorStateTransition63128 = baseStateMachine1705994986.AddAnyStateTransition(assaultRifleAnimatorState63240);
			animatorStateTransition63128.canTransitionToSelf = false;
			animatorStateTransition63128.duration = 0.1f;
			animatorStateTransition63128.exitTime = 0.75f;
			animatorStateTransition63128.hasExitTime = false;
			animatorStateTransition63128.hasFixedDuration = true;
			animatorStateTransition63128.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63128.offset = 0f;
			animatorStateTransition63128.orderedInterruption = true;
			animatorStateTransition63128.isExit = false;
			animatorStateTransition63128.mute = false;
			animatorStateTransition63128.solo = false;
			animatorStateTransition63128.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition63128.AddCondition(AnimatorConditionMode.Equals, 1f, "Slot0ItemID");

			var animatorStateTransition63130 = baseStateMachine1705994986.AddAnyStateTransition(sniperRifleAnimatorState63242);
			animatorStateTransition63130.canTransitionToSelf = false;
			animatorStateTransition63130.duration = 0.1f;
			animatorStateTransition63130.exitTime = 0.75f;
			animatorStateTransition63130.hasExitTime = false;
			animatorStateTransition63130.hasFixedDuration = true;
			animatorStateTransition63130.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63130.offset = 0f;
			animatorStateTransition63130.orderedInterruption = true;
			animatorStateTransition63130.isExit = false;
			animatorStateTransition63130.mute = false;
			animatorStateTransition63130.solo = false;
			animatorStateTransition63130.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition63130.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemID");

			var animatorStateTransition63132 = baseStateMachine1705994986.AddAnyStateTransition(fragGrenadeAnimatorState63244);
			animatorStateTransition63132.canTransitionToSelf = false;
			animatorStateTransition63132.duration = 0.1f;
			animatorStateTransition63132.exitTime = 0.75f;
			animatorStateTransition63132.hasExitTime = false;
			animatorStateTransition63132.hasFixedDuration = true;
			animatorStateTransition63132.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition63132.offset = 0f;
			animatorStateTransition63132.orderedInterruption = true;
			animatorStateTransition63132.isExit = false;
			animatorStateTransition63132.mute = false;
			animatorStateTransition63132.solo = false;
			animatorStateTransition63132.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			animatorStateTransition63132.AddCondition(AnimatorConditionMode.Equals, 41f, "Slot0ItemID");
		}
	}
}
