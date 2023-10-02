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
	/// Draws a custom inspector for the Dodge Ability.
	/// </summary>
	[InspectorDrawer(typeof(Dodge))]
	public class DodgeInspectorDrawer : AbilityInspectorDrawer
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

			var baseStateMachine1732673470 = animatorController.layers[0].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1732673470.stateMachines.Length; ++j) {
					if (baseStateMachine1732673470.stateMachines[j].stateMachine.name == "Dodge") {
						baseStateMachine1732673470.RemoveStateMachine(baseStateMachine1732673470.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var meleeDodgeBwdAnimationClip60334Path = AssetDatabase.GUIDToAssetPath("e7bcf8f3e84813f48a90cd7827dbf231"); 
			var meleeDodgeBwdAnimationClip60334 = AnimatorBuilder.GetAnimationClip(meleeDodgeBwdAnimationClip60334Path, "MeleeDodgeBwd");
			var meleeDodgeFwdAnimationClip60338Path = AssetDatabase.GUIDToAssetPath("a9418386ebd4e1644ae68187307fc18d"); 
			var meleeDodgeFwdAnimationClip60338 = AnimatorBuilder.GetAnimationClip(meleeDodgeFwdAnimationClip60338Path, "MeleeDodgeFwd");
			var meleeDodgeRightFrontAnimationClip60342Path = AssetDatabase.GUIDToAssetPath("51ea8026172e39b41aea0efa128ffa9b"); 
			var meleeDodgeRightFrontAnimationClip60342 = AnimatorBuilder.GetAnimationClip(meleeDodgeRightFrontAnimationClip60342Path, "MeleeDodgeRightFront");
			var meleeDodgeLeftFrontAnimationClip60346Path = AssetDatabase.GUIDToAssetPath("36ff4a8422553284e81570068ac8394c"); 
			var meleeDodgeLeftFrontAnimationClip60346 = AnimatorBuilder.GetAnimationClip(meleeDodgeLeftFrontAnimationClip60346Path, "MeleeDodgeLeftFront");
			var meleeDodgeLeftBackAnimationClip60350Path = AssetDatabase.GUIDToAssetPath("8ff8c865fd67aa147b0247cee5342ed6"); 
			var meleeDodgeLeftBackAnimationClip60350 = AnimatorBuilder.GetAnimationClip(meleeDodgeLeftBackAnimationClip60350Path, "MeleeDodgeLeftBack");
			var meleeDodgeRightBackAnimationClip60354Path = AssetDatabase.GUIDToAssetPath("2540da54527da3f48a4268b798bb77f8"); 
			var meleeDodgeRightBackAnimationClip60354 = AnimatorBuilder.GetAnimationClip(meleeDodgeRightBackAnimationClip60354Path, "MeleeDodgeRightBack");
			var dodgeLeftFrontAnimationClip60358Path = AssetDatabase.GUIDToAssetPath("2924899db8750e145a94f8407e27f52e"); 
			var dodgeLeftFrontAnimationClip60358 = AnimatorBuilder.GetAnimationClip(dodgeLeftFrontAnimationClip60358Path, "DodgeLeftFront");
			var dodgeRightFrontAnimationClip60362Path = AssetDatabase.GUIDToAssetPath("b44a54647fcaab745b64d5fd05e82d23"); 
			var dodgeRightFrontAnimationClip60362 = AnimatorBuilder.GetAnimationClip(dodgeRightFrontAnimationClip60362Path, "DodgeRightFront");
			var dodgeFwdAnimationClip60366Path = AssetDatabase.GUIDToAssetPath("c6577d4489d7c56478e2206131c3f836"); 
			var dodgeFwdAnimationClip60366 = AnimatorBuilder.GetAnimationClip(dodgeFwdAnimationClip60366Path, "DodgeFwd");
			var dodgeBwdAnimationClip60370Path = AssetDatabase.GUIDToAssetPath("e1a75bd20e3b6a449b6cdb0272e141da"); 
			var dodgeBwdAnimationClip60370 = AnimatorBuilder.GetAnimationClip(dodgeBwdAnimationClip60370Path, "DodgeBwd");
			var dodgeRightBackAnimationClip60374Path = AssetDatabase.GUIDToAssetPath("de82364f24793704ba3dbe4388b6d4ee"); 
			var dodgeRightBackAnimationClip60374 = AnimatorBuilder.GetAnimationClip(dodgeRightBackAnimationClip60374Path, "DodgeRightBack");
			var dodgeLeftBackAnimationClip60378Path = AssetDatabase.GUIDToAssetPath("b1aa4ab0d79ce554db3b358804cc79fc"); 
			var dodgeLeftBackAnimationClip60378 = AnimatorBuilder.GetAnimationClip(dodgeLeftBackAnimationClip60378Path, "DodgeLeftBack");
			var bowDodgeBwdAnimationClip60382Path = AssetDatabase.GUIDToAssetPath("1b60dd3de1d599144a0f7abc7647ca5c"); 
			var bowDodgeBwdAnimationClip60382 = AnimatorBuilder.GetAnimationClip(bowDodgeBwdAnimationClip60382Path, "BowDodgeBwd");
			var bowDodgeFwdAnimationClip60386Path = AssetDatabase.GUIDToAssetPath("e2affe2826a89294e9b162cd9898143c"); 
			var bowDodgeFwdAnimationClip60386 = AnimatorBuilder.GetAnimationClip(bowDodgeFwdAnimationClip60386Path, "BowDodgeFwd");
			var bowDodgeRightFrontAnimationClip60390Path = AssetDatabase.GUIDToAssetPath("eb7944ac7f494cd418908bf77250f0f0"); 
			var bowDodgeRightFrontAnimationClip60390 = AnimatorBuilder.GetAnimationClip(bowDodgeRightFrontAnimationClip60390Path, "BowDodgeRightFront");
			var bowDodgeLeftFrontAnimationClip60394Path = AssetDatabase.GUIDToAssetPath("79f1b69833b2c99499766434ee4f1088"); 
			var bowDodgeLeftFrontAnimationClip60394 = AnimatorBuilder.GetAnimationClip(bowDodgeLeftFrontAnimationClip60394Path, "BowDodgeLeftFront");
			var bowDodgeLeftBackAnimationClip60398Path = AssetDatabase.GUIDToAssetPath("08e76a348a853204191cc4b375421fcf"); 
			var bowDodgeLeftBackAnimationClip60398 = AnimatorBuilder.GetAnimationClip(bowDodgeLeftBackAnimationClip60398Path, "BowDodgeLeftBack");
			var bowDodgeRightBackAnimationClip60402Path = AssetDatabase.GUIDToAssetPath("11b8cb3821ea2044ca00f75a857195a8"); 
			var bowDodgeRightBackAnimationClip60402 = AnimatorBuilder.GetAnimationClip(bowDodgeRightBackAnimationClip60402Path, "BowDodgeRightBack");

			// State Machine.
			var dodgeAnimatorStateMachine58238 = baseStateMachine1732673470.AddStateMachine("Dodge", new Vector3(624f, 60f, 0f));

			// State Machine.
			var meleeDodgeAnimatorStateMachine60326 = dodgeAnimatorStateMachine58238.AddStateMachine("Melee Dodge", new Vector3(372f, 36f, 0f));

			// States.
			var meleeDodgeBackwardAnimatorState59102 = meleeDodgeAnimatorStateMachine60326.AddState("Melee Dodge Backward", new Vector3(384f, -60f, 0f));
			meleeDodgeBackwardAnimatorState59102.motion = meleeDodgeBwdAnimationClip60334;
			meleeDodgeBackwardAnimatorState59102.cycleOffset = 0f;
			meleeDodgeBackwardAnimatorState59102.cycleOffsetParameterActive = false;
			meleeDodgeBackwardAnimatorState59102.iKOnFeet = true;
			meleeDodgeBackwardAnimatorState59102.mirror = false;
			meleeDodgeBackwardAnimatorState59102.mirrorParameterActive = false;
			meleeDodgeBackwardAnimatorState59102.speed = 1f;
			meleeDodgeBackwardAnimatorState59102.speedParameterActive = false;
			meleeDodgeBackwardAnimatorState59102.writeDefaultValues = false;

			var meleeDodgeForwardAnimatorState59104 = meleeDodgeAnimatorStateMachine60326.AddState("Melee Dodge Forward", new Vector3(384f, -120f, 0f));
			meleeDodgeForwardAnimatorState59104.motion = meleeDodgeFwdAnimationClip60338;
			meleeDodgeForwardAnimatorState59104.cycleOffset = 0f;
			meleeDodgeForwardAnimatorState59104.cycleOffsetParameterActive = false;
			meleeDodgeForwardAnimatorState59104.iKOnFeet = true;
			meleeDodgeForwardAnimatorState59104.mirror = false;
			meleeDodgeForwardAnimatorState59104.mirrorParameterActive = false;
			meleeDodgeForwardAnimatorState59104.speed = 1f;
			meleeDodgeForwardAnimatorState59104.speedParameterActive = false;
			meleeDodgeForwardAnimatorState59104.writeDefaultValues = false;

			var meleeDodgeRightFrontAnimatorState59106 = meleeDodgeAnimatorStateMachine60326.AddState("Melee Dodge Right Front", new Vector3(384f, 120f, 0f));
			meleeDodgeRightFrontAnimatorState59106.motion = meleeDodgeRightFrontAnimationClip60342;
			meleeDodgeRightFrontAnimatorState59106.cycleOffset = 0f;
			meleeDodgeRightFrontAnimatorState59106.cycleOffsetParameterActive = false;
			meleeDodgeRightFrontAnimatorState59106.iKOnFeet = true;
			meleeDodgeRightFrontAnimatorState59106.mirror = false;
			meleeDodgeRightFrontAnimatorState59106.mirrorParameterActive = false;
			meleeDodgeRightFrontAnimatorState59106.speed = 1f;
			meleeDodgeRightFrontAnimatorState59106.speedParameterActive = false;
			meleeDodgeRightFrontAnimatorState59106.writeDefaultValues = false;

			var meleeDodgeLeftFrontAnimatorState59108 = meleeDodgeAnimatorStateMachine60326.AddState("Melee Dodge Left Front", new Vector3(384f, 0f, 0f));
			meleeDodgeLeftFrontAnimatorState59108.motion = meleeDodgeLeftFrontAnimationClip60346;
			meleeDodgeLeftFrontAnimatorState59108.cycleOffset = 0f;
			meleeDodgeLeftFrontAnimatorState59108.cycleOffsetParameterActive = false;
			meleeDodgeLeftFrontAnimatorState59108.iKOnFeet = true;
			meleeDodgeLeftFrontAnimatorState59108.mirror = false;
			meleeDodgeLeftFrontAnimatorState59108.mirrorParameterActive = false;
			meleeDodgeLeftFrontAnimatorState59108.speed = 1f;
			meleeDodgeLeftFrontAnimatorState59108.speedParameterActive = false;
			meleeDodgeLeftFrontAnimatorState59108.writeDefaultValues = false;

			var meleeDodgeLeftBackAnimatorState59110 = meleeDodgeAnimatorStateMachine60326.AddState("Melee Dodge Left Back", new Vector3(384f, 60f, 0f));
			meleeDodgeLeftBackAnimatorState59110.motion = meleeDodgeLeftBackAnimationClip60350;
			meleeDodgeLeftBackAnimatorState59110.cycleOffset = 0f;
			meleeDodgeLeftBackAnimatorState59110.cycleOffsetParameterActive = false;
			meleeDodgeLeftBackAnimatorState59110.iKOnFeet = true;
			meleeDodgeLeftBackAnimatorState59110.mirror = false;
			meleeDodgeLeftBackAnimatorState59110.mirrorParameterActive = false;
			meleeDodgeLeftBackAnimatorState59110.speed = 1f;
			meleeDodgeLeftBackAnimatorState59110.speedParameterActive = false;
			meleeDodgeLeftBackAnimatorState59110.writeDefaultValues = false;

			var meleeDodgeRightBackAnimatorState59112 = meleeDodgeAnimatorStateMachine60326.AddState("Melee Dodge Right Back", new Vector3(384f, 180f, 0f));
			meleeDodgeRightBackAnimatorState59112.motion = meleeDodgeRightBackAnimationClip60354;
			meleeDodgeRightBackAnimatorState59112.cycleOffset = 0f;
			meleeDodgeRightBackAnimatorState59112.cycleOffsetParameterActive = false;
			meleeDodgeRightBackAnimatorState59112.iKOnFeet = true;
			meleeDodgeRightBackAnimatorState59112.mirror = false;
			meleeDodgeRightBackAnimatorState59112.mirrorParameterActive = false;
			meleeDodgeRightBackAnimatorState59112.speed = 1f;
			meleeDodgeRightBackAnimatorState59112.speedParameterActive = false;
			meleeDodgeRightBackAnimatorState59112.writeDefaultValues = false;

			// State Machine Defaults.
			meleeDodgeAnimatorStateMachine60326.anyStatePosition = new Vector3(48f, 36f, 0f);
			meleeDodgeAnimatorStateMachine60326.defaultState = meleeDodgeForwardAnimatorState59104;
			meleeDodgeAnimatorStateMachine60326.entryPosition = new Vector3(48f, -12f, 0f);
			meleeDodgeAnimatorStateMachine60326.exitPosition = new Vector3(800f, 120f, 0f);
			meleeDodgeAnimatorStateMachine60326.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Machine.
			var aimDodgeAnimatorStateMachine60328 = dodgeAnimatorStateMachine58238.AddStateMachine("Aim Dodge", new Vector3(372f, -12f, 0f));

			// States.
			var dodgeLeftFrontAnimatorState59114 = aimDodgeAnimatorStateMachine60328.AddState("Dodge Left Front", new Vector3(432f, 72f, 0f));
			dodgeLeftFrontAnimatorState59114.motion = dodgeLeftFrontAnimationClip60358;
			dodgeLeftFrontAnimatorState59114.cycleOffset = 0f;
			dodgeLeftFrontAnimatorState59114.cycleOffsetParameterActive = false;
			dodgeLeftFrontAnimatorState59114.iKOnFeet = true;
			dodgeLeftFrontAnimatorState59114.mirror = false;
			dodgeLeftFrontAnimatorState59114.mirrorParameterActive = false;
			dodgeLeftFrontAnimatorState59114.speed = 1f;
			dodgeLeftFrontAnimatorState59114.speedParameterActive = false;
			dodgeLeftFrontAnimatorState59114.writeDefaultValues = false;

			var dodgeRightFrontAnimatorState59116 = aimDodgeAnimatorStateMachine60328.AddState("Dodge Right Front", new Vector3(432f, 192f, 0f));
			dodgeRightFrontAnimatorState59116.motion = dodgeRightFrontAnimationClip60362;
			dodgeRightFrontAnimatorState59116.cycleOffset = 0f;
			dodgeRightFrontAnimatorState59116.cycleOffsetParameterActive = false;
			dodgeRightFrontAnimatorState59116.iKOnFeet = true;
			dodgeRightFrontAnimatorState59116.mirror = false;
			dodgeRightFrontAnimatorState59116.mirrorParameterActive = false;
			dodgeRightFrontAnimatorState59116.speed = 1f;
			dodgeRightFrontAnimatorState59116.speedParameterActive = false;
			dodgeRightFrontAnimatorState59116.writeDefaultValues = false;

			var dodgeForwardAnimatorState59118 = aimDodgeAnimatorStateMachine60328.AddState("Dodge Forward", new Vector3(432f, -48f, 0f));
			dodgeForwardAnimatorState59118.motion = dodgeFwdAnimationClip60366;
			dodgeForwardAnimatorState59118.cycleOffset = 0f;
			dodgeForwardAnimatorState59118.cycleOffsetParameterActive = false;
			dodgeForwardAnimatorState59118.iKOnFeet = true;
			dodgeForwardAnimatorState59118.mirror = false;
			dodgeForwardAnimatorState59118.mirrorParameterActive = false;
			dodgeForwardAnimatorState59118.speed = 1f;
			dodgeForwardAnimatorState59118.speedParameterActive = false;
			dodgeForwardAnimatorState59118.writeDefaultValues = true;

			var dodgeBackwardAnimatorState59120 = aimDodgeAnimatorStateMachine60328.AddState("Dodge Backward", new Vector3(432f, 12f, 0f));
			dodgeBackwardAnimatorState59120.motion = dodgeBwdAnimationClip60370;
			dodgeBackwardAnimatorState59120.cycleOffset = 0f;
			dodgeBackwardAnimatorState59120.cycleOffsetParameterActive = false;
			dodgeBackwardAnimatorState59120.iKOnFeet = true;
			dodgeBackwardAnimatorState59120.mirror = false;
			dodgeBackwardAnimatorState59120.mirrorParameterActive = false;
			dodgeBackwardAnimatorState59120.speed = 1f;
			dodgeBackwardAnimatorState59120.speedParameterActive = false;
			dodgeBackwardAnimatorState59120.writeDefaultValues = true;

			var dodgeRightBackAnimatorState59122 = aimDodgeAnimatorStateMachine60328.AddState("Dodge Right Back", new Vector3(432f, 252f, 0f));
			dodgeRightBackAnimatorState59122.motion = dodgeRightBackAnimationClip60374;
			dodgeRightBackAnimatorState59122.cycleOffset = 0f;
			dodgeRightBackAnimatorState59122.cycleOffsetParameterActive = false;
			dodgeRightBackAnimatorState59122.iKOnFeet = true;
			dodgeRightBackAnimatorState59122.mirror = false;
			dodgeRightBackAnimatorState59122.mirrorParameterActive = false;
			dodgeRightBackAnimatorState59122.speed = 1f;
			dodgeRightBackAnimatorState59122.speedParameterActive = false;
			dodgeRightBackAnimatorState59122.writeDefaultValues = false;

			var dodgeLeftBackAnimatorState59124 = aimDodgeAnimatorStateMachine60328.AddState("Dodge Left Back", new Vector3(432f, 132f, 0f));
			dodgeLeftBackAnimatorState59124.motion = dodgeLeftBackAnimationClip60378;
			dodgeLeftBackAnimatorState59124.cycleOffset = 0f;
			dodgeLeftBackAnimatorState59124.cycleOffsetParameterActive = false;
			dodgeLeftBackAnimatorState59124.iKOnFeet = true;
			dodgeLeftBackAnimatorState59124.mirror = false;
			dodgeLeftBackAnimatorState59124.mirrorParameterActive = false;
			dodgeLeftBackAnimatorState59124.speed = 1f;
			dodgeLeftBackAnimatorState59124.speedParameterActive = false;
			dodgeLeftBackAnimatorState59124.writeDefaultValues = false;

			// State Machine Defaults.
			aimDodgeAnimatorStateMachine60328.anyStatePosition = new Vector3(48f, 48f, 0f);
			aimDodgeAnimatorStateMachine60328.defaultState = dodgeForwardAnimatorState59118;
			aimDodgeAnimatorStateMachine60328.entryPosition = new Vector3(48f, 0f, 0f);
			aimDodgeAnimatorStateMachine60328.exitPosition = new Vector3(800f, 120f, 0f);
			aimDodgeAnimatorStateMachine60328.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Machine.
			var bowDodgeAnimatorStateMachine60330 = dodgeAnimatorStateMachine58238.AddStateMachine("Bow Dodge", new Vector3(372f, 84f, 0f));

			// States.
			var bowDodgeBackwardAnimatorState59126 = bowDodgeAnimatorStateMachine60330.AddState("Bow Dodge Backward", new Vector3(384f, -60f, 0f));
			bowDodgeBackwardAnimatorState59126.motion = bowDodgeBwdAnimationClip60382;
			bowDodgeBackwardAnimatorState59126.cycleOffset = 0f;
			bowDodgeBackwardAnimatorState59126.cycleOffsetParameterActive = false;
			bowDodgeBackwardAnimatorState59126.iKOnFeet = true;
			bowDodgeBackwardAnimatorState59126.mirror = false;
			bowDodgeBackwardAnimatorState59126.mirrorParameterActive = false;
			bowDodgeBackwardAnimatorState59126.speed = 1f;
			bowDodgeBackwardAnimatorState59126.speedParameterActive = false;
			bowDodgeBackwardAnimatorState59126.writeDefaultValues = false;

			var bowDodgeForwardAnimatorState59128 = bowDodgeAnimatorStateMachine60330.AddState("Bow Dodge Forward", new Vector3(384f, -120f, 0f));
			bowDodgeForwardAnimatorState59128.motion = bowDodgeFwdAnimationClip60386;
			bowDodgeForwardAnimatorState59128.cycleOffset = 0f;
			bowDodgeForwardAnimatorState59128.cycleOffsetParameterActive = false;
			bowDodgeForwardAnimatorState59128.iKOnFeet = true;
			bowDodgeForwardAnimatorState59128.mirror = false;
			bowDodgeForwardAnimatorState59128.mirrorParameterActive = false;
			bowDodgeForwardAnimatorState59128.speed = 1f;
			bowDodgeForwardAnimatorState59128.speedParameterActive = false;
			bowDodgeForwardAnimatorState59128.writeDefaultValues = false;

			var bowDodgeRightFrontAnimatorState59130 = bowDodgeAnimatorStateMachine60330.AddState("Bow Dodge Right Front", new Vector3(384f, 120f, 0f));
			bowDodgeRightFrontAnimatorState59130.motion = bowDodgeRightFrontAnimationClip60390;
			bowDodgeRightFrontAnimatorState59130.cycleOffset = 0f;
			bowDodgeRightFrontAnimatorState59130.cycleOffsetParameterActive = false;
			bowDodgeRightFrontAnimatorState59130.iKOnFeet = true;
			bowDodgeRightFrontAnimatorState59130.mirror = false;
			bowDodgeRightFrontAnimatorState59130.mirrorParameterActive = false;
			bowDodgeRightFrontAnimatorState59130.speed = 1f;
			bowDodgeRightFrontAnimatorState59130.speedParameterActive = false;
			bowDodgeRightFrontAnimatorState59130.writeDefaultValues = false;

			var bowDodgeLeftFrontAnimatorState59132 = bowDodgeAnimatorStateMachine60330.AddState("Bow Dodge Left Front", new Vector3(384f, 0f, 0f));
			bowDodgeLeftFrontAnimatorState59132.motion = bowDodgeLeftFrontAnimationClip60394;
			bowDodgeLeftFrontAnimatorState59132.cycleOffset = 0f;
			bowDodgeLeftFrontAnimatorState59132.cycleOffsetParameterActive = false;
			bowDodgeLeftFrontAnimatorState59132.iKOnFeet = true;
			bowDodgeLeftFrontAnimatorState59132.mirror = false;
			bowDodgeLeftFrontAnimatorState59132.mirrorParameterActive = false;
			bowDodgeLeftFrontAnimatorState59132.speed = 1f;
			bowDodgeLeftFrontAnimatorState59132.speedParameterActive = false;
			bowDodgeLeftFrontAnimatorState59132.writeDefaultValues = false;

			var bowDodgeLeftBackAnimatorState59134 = bowDodgeAnimatorStateMachine60330.AddState("Bow Dodge Left Back", new Vector3(384f, 60f, 0f));
			bowDodgeLeftBackAnimatorState59134.motion = bowDodgeLeftBackAnimationClip60398;
			bowDodgeLeftBackAnimatorState59134.cycleOffset = 0f;
			bowDodgeLeftBackAnimatorState59134.cycleOffsetParameterActive = false;
			bowDodgeLeftBackAnimatorState59134.iKOnFeet = true;
			bowDodgeLeftBackAnimatorState59134.mirror = false;
			bowDodgeLeftBackAnimatorState59134.mirrorParameterActive = false;
			bowDodgeLeftBackAnimatorState59134.speed = 1f;
			bowDodgeLeftBackAnimatorState59134.speedParameterActive = false;
			bowDodgeLeftBackAnimatorState59134.writeDefaultValues = false;

			var bowDodgeRightBackAnimatorState59136 = bowDodgeAnimatorStateMachine60330.AddState("Bow Dodge Right Back", new Vector3(384f, 180f, 0f));
			bowDodgeRightBackAnimatorState59136.motion = bowDodgeRightBackAnimationClip60402;
			bowDodgeRightBackAnimatorState59136.cycleOffset = 0f;
			bowDodgeRightBackAnimatorState59136.cycleOffsetParameterActive = false;
			bowDodgeRightBackAnimatorState59136.iKOnFeet = true;
			bowDodgeRightBackAnimatorState59136.mirror = false;
			bowDodgeRightBackAnimatorState59136.mirrorParameterActive = false;
			bowDodgeRightBackAnimatorState59136.speed = 1f;
			bowDodgeRightBackAnimatorState59136.speedParameterActive = false;
			bowDodgeRightBackAnimatorState59136.writeDefaultValues = false;

			// State Machine Defaults.
			bowDodgeAnimatorStateMachine60330.anyStatePosition = new Vector3(48f, 48f, 0f);
			bowDodgeAnimatorStateMachine60330.defaultState = bowDodgeForwardAnimatorState59128;
			bowDodgeAnimatorStateMachine60330.entryPosition = new Vector3(48f, 0f, 0f);
			bowDodgeAnimatorStateMachine60330.exitPosition = new Vector3(800f, 120f, 0f);
			bowDodgeAnimatorStateMachine60330.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Machine Defaults.
			dodgeAnimatorStateMachine58238.anyStatePosition = new Vector3(50f, 20f, 0f);
			dodgeAnimatorStateMachine58238.defaultState = dodgeForwardAnimatorState59118;
			dodgeAnimatorStateMachine58238.entryPosition = new Vector3(50f, 120f, 0f);
			dodgeAnimatorStateMachine58238.exitPosition = new Vector3(800f, 120f, 0f);
			dodgeAnimatorStateMachine58238.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Transitions.
			var animatorStateTransition60332 = meleeDodgeBackwardAnimatorState59102.AddExitTransition();
			animatorStateTransition60332.canTransitionToSelf = true;
			animatorStateTransition60332.duration = 0.1f;
			animatorStateTransition60332.exitTime = 0.75f;
			animatorStateTransition60332.hasExitTime = false;
			animatorStateTransition60332.hasFixedDuration = true;
			animatorStateTransition60332.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60332.offset = 0f;
			animatorStateTransition60332.orderedInterruption = true;
			animatorStateTransition60332.isExit = true;
			animatorStateTransition60332.mute = false;
			animatorStateTransition60332.solo = false;
			animatorStateTransition60332.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var animatorStateTransition60336 = meleeDodgeForwardAnimatorState59104.AddExitTransition();
			animatorStateTransition60336.canTransitionToSelf = true;
			animatorStateTransition60336.duration = 0.1f;
			animatorStateTransition60336.exitTime = 0.95f;
			animatorStateTransition60336.hasExitTime = false;
			animatorStateTransition60336.hasFixedDuration = true;
			animatorStateTransition60336.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60336.offset = 0f;
			animatorStateTransition60336.orderedInterruption = true;
			animatorStateTransition60336.isExit = true;
			animatorStateTransition60336.mute = false;
			animatorStateTransition60336.solo = false;
			animatorStateTransition60336.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var animatorStateTransition60340 = meleeDodgeRightFrontAnimatorState59106.AddExitTransition();
			animatorStateTransition60340.canTransitionToSelf = true;
			animatorStateTransition60340.duration = 0.1f;
			animatorStateTransition60340.exitTime = 0.95f;
			animatorStateTransition60340.hasExitTime = false;
			animatorStateTransition60340.hasFixedDuration = true;
			animatorStateTransition60340.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60340.offset = 0f;
			animatorStateTransition60340.orderedInterruption = true;
			animatorStateTransition60340.isExit = true;
			animatorStateTransition60340.mute = false;
			animatorStateTransition60340.solo = false;
			animatorStateTransition60340.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var animatorStateTransition60344 = meleeDodgeLeftFrontAnimatorState59108.AddExitTransition();
			animatorStateTransition60344.canTransitionToSelf = true;
			animatorStateTransition60344.duration = 0.1f;
			animatorStateTransition60344.exitTime = 0.95f;
			animatorStateTransition60344.hasExitTime = false;
			animatorStateTransition60344.hasFixedDuration = true;
			animatorStateTransition60344.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60344.offset = 0f;
			animatorStateTransition60344.orderedInterruption = true;
			animatorStateTransition60344.isExit = true;
			animatorStateTransition60344.mute = false;
			animatorStateTransition60344.solo = false;
			animatorStateTransition60344.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var animatorStateTransition60348 = meleeDodgeLeftBackAnimatorState59110.AddExitTransition();
			animatorStateTransition60348.canTransitionToSelf = true;
			animatorStateTransition60348.duration = 0.1f;
			animatorStateTransition60348.exitTime = 0.95f;
			animatorStateTransition60348.hasExitTime = false;
			animatorStateTransition60348.hasFixedDuration = true;
			animatorStateTransition60348.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60348.offset = 0f;
			animatorStateTransition60348.orderedInterruption = true;
			animatorStateTransition60348.isExit = true;
			animatorStateTransition60348.mute = false;
			animatorStateTransition60348.solo = false;
			animatorStateTransition60348.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var animatorStateTransition60352 = meleeDodgeRightBackAnimatorState59112.AddExitTransition();
			animatorStateTransition60352.canTransitionToSelf = true;
			animatorStateTransition60352.duration = 0.1f;
			animatorStateTransition60352.exitTime = 0.95f;
			animatorStateTransition60352.hasExitTime = false;
			animatorStateTransition60352.hasFixedDuration = true;
			animatorStateTransition60352.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60352.offset = 0f;
			animatorStateTransition60352.orderedInterruption = true;
			animatorStateTransition60352.isExit = true;
			animatorStateTransition60352.mute = false;
			animatorStateTransition60352.solo = false;
			animatorStateTransition60352.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			// State Transitions.
			var animatorStateTransition60356 = dodgeLeftFrontAnimatorState59114.AddExitTransition();
			animatorStateTransition60356.canTransitionToSelf = true;
			animatorStateTransition60356.duration = 0.1f;
			animatorStateTransition60356.exitTime = 0.95f;
			animatorStateTransition60356.hasExitTime = false;
			animatorStateTransition60356.hasFixedDuration = true;
			animatorStateTransition60356.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60356.offset = 0f;
			animatorStateTransition60356.orderedInterruption = true;
			animatorStateTransition60356.isExit = true;
			animatorStateTransition60356.mute = false;
			animatorStateTransition60356.solo = false;
			animatorStateTransition60356.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var animatorStateTransition60360 = dodgeRightFrontAnimatorState59116.AddExitTransition();
			animatorStateTransition60360.canTransitionToSelf = true;
			animatorStateTransition60360.duration = 0.1f;
			animatorStateTransition60360.exitTime = 0.95f;
			animatorStateTransition60360.hasExitTime = false;
			animatorStateTransition60360.hasFixedDuration = true;
			animatorStateTransition60360.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60360.offset = 0f;
			animatorStateTransition60360.orderedInterruption = true;
			animatorStateTransition60360.isExit = true;
			animatorStateTransition60360.mute = false;
			animatorStateTransition60360.solo = false;
			animatorStateTransition60360.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var animatorStateTransition60364 = dodgeForwardAnimatorState59118.AddExitTransition();
			animatorStateTransition60364.canTransitionToSelf = true;
			animatorStateTransition60364.duration = 0.1f;
			animatorStateTransition60364.exitTime = 0.95f;
			animatorStateTransition60364.hasExitTime = false;
			animatorStateTransition60364.hasFixedDuration = true;
			animatorStateTransition60364.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60364.offset = 0f;
			animatorStateTransition60364.orderedInterruption = true;
			animatorStateTransition60364.isExit = true;
			animatorStateTransition60364.mute = false;
			animatorStateTransition60364.solo = false;
			animatorStateTransition60364.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var animatorStateTransition60368 = dodgeBackwardAnimatorState59120.AddExitTransition();
			animatorStateTransition60368.canTransitionToSelf = true;
			animatorStateTransition60368.duration = 0.1f;
			animatorStateTransition60368.exitTime = 0.75f;
			animatorStateTransition60368.hasExitTime = false;
			animatorStateTransition60368.hasFixedDuration = true;
			animatorStateTransition60368.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60368.offset = 0f;
			animatorStateTransition60368.orderedInterruption = true;
			animatorStateTransition60368.isExit = true;
			animatorStateTransition60368.mute = false;
			animatorStateTransition60368.solo = false;
			animatorStateTransition60368.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var animatorStateTransition60372 = dodgeRightBackAnimatorState59122.AddExitTransition();
			animatorStateTransition60372.canTransitionToSelf = true;
			animatorStateTransition60372.duration = 0.1f;
			animatorStateTransition60372.exitTime = 0.95f;
			animatorStateTransition60372.hasExitTime = false;
			animatorStateTransition60372.hasFixedDuration = true;
			animatorStateTransition60372.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60372.offset = 0f;
			animatorStateTransition60372.orderedInterruption = true;
			animatorStateTransition60372.isExit = true;
			animatorStateTransition60372.mute = false;
			animatorStateTransition60372.solo = false;
			animatorStateTransition60372.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var animatorStateTransition60376 = dodgeLeftBackAnimatorState59124.AddExitTransition();
			animatorStateTransition60376.canTransitionToSelf = true;
			animatorStateTransition60376.duration = 0.1f;
			animatorStateTransition60376.exitTime = 0.95f;
			animatorStateTransition60376.hasExitTime = false;
			animatorStateTransition60376.hasFixedDuration = true;
			animatorStateTransition60376.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60376.offset = 0f;
			animatorStateTransition60376.orderedInterruption = true;
			animatorStateTransition60376.isExit = true;
			animatorStateTransition60376.mute = false;
			animatorStateTransition60376.solo = false;
			animatorStateTransition60376.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			// State Transitions.
			var animatorStateTransition60380 = bowDodgeBackwardAnimatorState59126.AddExitTransition();
			animatorStateTransition60380.canTransitionToSelf = true;
			animatorStateTransition60380.duration = 0.1f;
			animatorStateTransition60380.exitTime = 0.75f;
			animatorStateTransition60380.hasExitTime = false;
			animatorStateTransition60380.hasFixedDuration = true;
			animatorStateTransition60380.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60380.offset = 0f;
			animatorStateTransition60380.orderedInterruption = true;
			animatorStateTransition60380.isExit = true;
			animatorStateTransition60380.mute = false;
			animatorStateTransition60380.solo = false;
			animatorStateTransition60380.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var animatorStateTransition60384 = bowDodgeForwardAnimatorState59128.AddExitTransition();
			animatorStateTransition60384.canTransitionToSelf = true;
			animatorStateTransition60384.duration = 0.1f;
			animatorStateTransition60384.exitTime = 0.95f;
			animatorStateTransition60384.hasExitTime = false;
			animatorStateTransition60384.hasFixedDuration = true;
			animatorStateTransition60384.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60384.offset = 0f;
			animatorStateTransition60384.orderedInterruption = true;
			animatorStateTransition60384.isExit = true;
			animatorStateTransition60384.mute = false;
			animatorStateTransition60384.solo = false;
			animatorStateTransition60384.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var animatorStateTransition60388 = bowDodgeRightFrontAnimatorState59130.AddExitTransition();
			animatorStateTransition60388.canTransitionToSelf = true;
			animatorStateTransition60388.duration = 0.1f;
			animatorStateTransition60388.exitTime = 0.95f;
			animatorStateTransition60388.hasExitTime = false;
			animatorStateTransition60388.hasFixedDuration = true;
			animatorStateTransition60388.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60388.offset = 0f;
			animatorStateTransition60388.orderedInterruption = true;
			animatorStateTransition60388.isExit = true;
			animatorStateTransition60388.mute = false;
			animatorStateTransition60388.solo = false;
			animatorStateTransition60388.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var animatorStateTransition60392 = bowDodgeLeftFrontAnimatorState59132.AddExitTransition();
			animatorStateTransition60392.canTransitionToSelf = true;
			animatorStateTransition60392.duration = 0.1f;
			animatorStateTransition60392.exitTime = 0.95f;
			animatorStateTransition60392.hasExitTime = false;
			animatorStateTransition60392.hasFixedDuration = true;
			animatorStateTransition60392.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60392.offset = 0f;
			animatorStateTransition60392.orderedInterruption = true;
			animatorStateTransition60392.isExit = true;
			animatorStateTransition60392.mute = false;
			animatorStateTransition60392.solo = false;
			animatorStateTransition60392.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var animatorStateTransition60396 = bowDodgeLeftBackAnimatorState59134.AddExitTransition();
			animatorStateTransition60396.canTransitionToSelf = true;
			animatorStateTransition60396.duration = 0.1f;
			animatorStateTransition60396.exitTime = 0.95f;
			animatorStateTransition60396.hasExitTime = false;
			animatorStateTransition60396.hasFixedDuration = true;
			animatorStateTransition60396.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60396.offset = 0f;
			animatorStateTransition60396.orderedInterruption = true;
			animatorStateTransition60396.isExit = true;
			animatorStateTransition60396.mute = false;
			animatorStateTransition60396.solo = false;
			animatorStateTransition60396.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var animatorStateTransition60400 = bowDodgeRightBackAnimatorState59136.AddExitTransition();
			animatorStateTransition60400.canTransitionToSelf = true;
			animatorStateTransition60400.duration = 0.1f;
			animatorStateTransition60400.exitTime = 0.95f;
			animatorStateTransition60400.hasExitTime = false;
			animatorStateTransition60400.hasFixedDuration = true;
			animatorStateTransition60400.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition60400.offset = 0f;
			animatorStateTransition60400.orderedInterruption = true;
			animatorStateTransition60400.isExit = true;
			animatorStateTransition60400.mute = false;
			animatorStateTransition60400.solo = false;
			animatorStateTransition60400.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");


			// State Machine Transitions.
			var animatorStateTransition58776 = baseStateMachine1732673470.AddAnyStateTransition(meleeDodgeBackwardAnimatorState59102);
			animatorStateTransition58776.canTransitionToSelf = false;
			animatorStateTransition58776.duration = 0.1f;
			animatorStateTransition58776.exitTime = 0.75f;
			animatorStateTransition58776.hasExitTime = false;
			animatorStateTransition58776.hasFixedDuration = true;
			animatorStateTransition58776.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58776.offset = 0f;
			animatorStateTransition58776.orderedInterruption = true;
			animatorStateTransition58776.isExit = false;
			animatorStateTransition58776.mute = false;
			animatorStateTransition58776.solo = false;
			animatorStateTransition58776.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58776.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58776.AddCondition(AnimatorConditionMode.Equals, 3f, "AbilityIntData");
			animatorStateTransition58776.AddCondition(AnimatorConditionMode.Equals, 1f, "MovementSetID");

			var animatorStateTransition58778 = baseStateMachine1732673470.AddAnyStateTransition(meleeDodgeForwardAnimatorState59104);
			animatorStateTransition58778.canTransitionToSelf = false;
			animatorStateTransition58778.duration = 0.1f;
			animatorStateTransition58778.exitTime = 0.75f;
			animatorStateTransition58778.hasExitTime = false;
			animatorStateTransition58778.hasFixedDuration = true;
			animatorStateTransition58778.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58778.offset = 0f;
			animatorStateTransition58778.orderedInterruption = true;
			animatorStateTransition58778.isExit = false;
			animatorStateTransition58778.mute = false;
			animatorStateTransition58778.solo = false;
			animatorStateTransition58778.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58778.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58778.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition58778.AddCondition(AnimatorConditionMode.Equals, 1f, "MovementSetID");

			var animatorStateTransition58780 = baseStateMachine1732673470.AddAnyStateTransition(meleeDodgeRightFrontAnimatorState59106);
			animatorStateTransition58780.canTransitionToSelf = false;
			animatorStateTransition58780.duration = 0.1f;
			animatorStateTransition58780.exitTime = 0.75f;
			animatorStateTransition58780.hasExitTime = false;
			animatorStateTransition58780.hasFixedDuration = true;
			animatorStateTransition58780.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58780.offset = 0f;
			animatorStateTransition58780.orderedInterruption = true;
			animatorStateTransition58780.isExit = false;
			animatorStateTransition58780.mute = false;
			animatorStateTransition58780.solo = false;
			animatorStateTransition58780.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58780.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58780.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition58780.AddCondition(AnimatorConditionMode.Equals, 1f, "MovementSetID");
			animatorStateTransition58780.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var animatorStateTransition58782 = baseStateMachine1732673470.AddAnyStateTransition(meleeDodgeLeftFrontAnimatorState59108);
			animatorStateTransition58782.canTransitionToSelf = false;
			animatorStateTransition58782.duration = 0.1f;
			animatorStateTransition58782.exitTime = 0.75f;
			animatorStateTransition58782.hasExitTime = false;
			animatorStateTransition58782.hasFixedDuration = true;
			animatorStateTransition58782.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58782.offset = 0f;
			animatorStateTransition58782.orderedInterruption = true;
			animatorStateTransition58782.isExit = false;
			animatorStateTransition58782.mute = false;
			animatorStateTransition58782.solo = false;
			animatorStateTransition58782.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58782.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58782.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			animatorStateTransition58782.AddCondition(AnimatorConditionMode.Equals, 1f, "MovementSetID");
			animatorStateTransition58782.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var animatorStateTransition58784 = baseStateMachine1732673470.AddAnyStateTransition(meleeDodgeLeftBackAnimatorState59110);
			animatorStateTransition58784.canTransitionToSelf = false;
			animatorStateTransition58784.duration = 0.1f;
			animatorStateTransition58784.exitTime = 0.75f;
			animatorStateTransition58784.hasExitTime = false;
			animatorStateTransition58784.hasFixedDuration = true;
			animatorStateTransition58784.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58784.offset = 0f;
			animatorStateTransition58784.orderedInterruption = true;
			animatorStateTransition58784.isExit = false;
			animatorStateTransition58784.mute = false;
			animatorStateTransition58784.solo = false;
			animatorStateTransition58784.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58784.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58784.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			animatorStateTransition58784.AddCondition(AnimatorConditionMode.Equals, 1f, "MovementSetID");
			animatorStateTransition58784.AddCondition(AnimatorConditionMode.Less, 0.499f, "LegIndex");

			var animatorStateTransition58786 = baseStateMachine1732673470.AddAnyStateTransition(meleeDodgeRightBackAnimatorState59112);
			animatorStateTransition58786.canTransitionToSelf = false;
			animatorStateTransition58786.duration = 0.1f;
			animatorStateTransition58786.exitTime = 0.75f;
			animatorStateTransition58786.hasExitTime = false;
			animatorStateTransition58786.hasFixedDuration = true;
			animatorStateTransition58786.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58786.offset = 0f;
			animatorStateTransition58786.orderedInterruption = true;
			animatorStateTransition58786.isExit = false;
			animatorStateTransition58786.mute = false;
			animatorStateTransition58786.solo = false;
			animatorStateTransition58786.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58786.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58786.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition58786.AddCondition(AnimatorConditionMode.Equals, 1f, "MovementSetID");
			animatorStateTransition58786.AddCondition(AnimatorConditionMode.Less, 0.499f, "LegIndex");

			var animatorStateTransition58788 = baseStateMachine1732673470.AddAnyStateTransition(dodgeLeftFrontAnimatorState59114);
			animatorStateTransition58788.canTransitionToSelf = false;
			animatorStateTransition58788.duration = 0.1f;
			animatorStateTransition58788.exitTime = 0.75f;
			animatorStateTransition58788.hasExitTime = false;
			animatorStateTransition58788.hasFixedDuration = true;
			animatorStateTransition58788.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58788.offset = 0f;
			animatorStateTransition58788.orderedInterruption = true;
			animatorStateTransition58788.isExit = false;
			animatorStateTransition58788.mute = false;
			animatorStateTransition58788.solo = false;
			animatorStateTransition58788.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58788.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58788.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			animatorStateTransition58788.AddCondition(AnimatorConditionMode.Equals, 0f, "MovementSetID");
			animatorStateTransition58788.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var animatorStateTransition58790 = baseStateMachine1732673470.AddAnyStateTransition(dodgeRightFrontAnimatorState59116);
			animatorStateTransition58790.canTransitionToSelf = false;
			animatorStateTransition58790.duration = 0.1f;
			animatorStateTransition58790.exitTime = 0.75f;
			animatorStateTransition58790.hasExitTime = false;
			animatorStateTransition58790.hasFixedDuration = true;
			animatorStateTransition58790.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58790.offset = 0f;
			animatorStateTransition58790.orderedInterruption = true;
			animatorStateTransition58790.isExit = false;
			animatorStateTransition58790.mute = false;
			animatorStateTransition58790.solo = false;
			animatorStateTransition58790.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58790.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58790.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition58790.AddCondition(AnimatorConditionMode.Equals, 0f, "MovementSetID");
			animatorStateTransition58790.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var animatorStateTransition58792 = baseStateMachine1732673470.AddAnyStateTransition(dodgeForwardAnimatorState59118);
			animatorStateTransition58792.canTransitionToSelf = false;
			animatorStateTransition58792.duration = 0.1f;
			animatorStateTransition58792.exitTime = 0.75f;
			animatorStateTransition58792.hasExitTime = false;
			animatorStateTransition58792.hasFixedDuration = true;
			animatorStateTransition58792.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58792.offset = 0f;
			animatorStateTransition58792.orderedInterruption = true;
			animatorStateTransition58792.isExit = false;
			animatorStateTransition58792.mute = false;
			animatorStateTransition58792.solo = false;
			animatorStateTransition58792.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58792.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58792.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition58792.AddCondition(AnimatorConditionMode.Equals, 0f, "MovementSetID");

			var animatorStateTransition58794 = baseStateMachine1732673470.AddAnyStateTransition(dodgeBackwardAnimatorState59120);
			animatorStateTransition58794.canTransitionToSelf = false;
			animatorStateTransition58794.duration = 0.1f;
			animatorStateTransition58794.exitTime = 0.75f;
			animatorStateTransition58794.hasExitTime = false;
			animatorStateTransition58794.hasFixedDuration = true;
			animatorStateTransition58794.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58794.offset = 0f;
			animatorStateTransition58794.orderedInterruption = true;
			animatorStateTransition58794.isExit = false;
			animatorStateTransition58794.mute = false;
			animatorStateTransition58794.solo = false;
			animatorStateTransition58794.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58794.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58794.AddCondition(AnimatorConditionMode.Equals, 3f, "AbilityIntData");
			animatorStateTransition58794.AddCondition(AnimatorConditionMode.Equals, 0f, "MovementSetID");

			var animatorStateTransition58796 = baseStateMachine1732673470.AddAnyStateTransition(dodgeRightBackAnimatorState59122);
			animatorStateTransition58796.canTransitionToSelf = false;
			animatorStateTransition58796.duration = 0.1f;
			animatorStateTransition58796.exitTime = 0.75f;
			animatorStateTransition58796.hasExitTime = false;
			animatorStateTransition58796.hasFixedDuration = true;
			animatorStateTransition58796.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58796.offset = 0f;
			animatorStateTransition58796.orderedInterruption = true;
			animatorStateTransition58796.isExit = false;
			animatorStateTransition58796.mute = false;
			animatorStateTransition58796.solo = false;
			animatorStateTransition58796.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58796.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58796.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition58796.AddCondition(AnimatorConditionMode.Equals, 0f, "MovementSetID");
			animatorStateTransition58796.AddCondition(AnimatorConditionMode.Less, 0.499f, "LegIndex");

			var animatorStateTransition58798 = baseStateMachine1732673470.AddAnyStateTransition(dodgeLeftBackAnimatorState59124);
			animatorStateTransition58798.canTransitionToSelf = false;
			animatorStateTransition58798.duration = 0.1f;
			animatorStateTransition58798.exitTime = 0.75f;
			animatorStateTransition58798.hasExitTime = false;
			animatorStateTransition58798.hasFixedDuration = true;
			animatorStateTransition58798.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58798.offset = 0f;
			animatorStateTransition58798.orderedInterruption = true;
			animatorStateTransition58798.isExit = false;
			animatorStateTransition58798.mute = false;
			animatorStateTransition58798.solo = false;
			animatorStateTransition58798.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58798.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58798.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			animatorStateTransition58798.AddCondition(AnimatorConditionMode.Equals, 0f, "MovementSetID");
			animatorStateTransition58798.AddCondition(AnimatorConditionMode.Less, 0.499f, "LegIndex");

			var animatorStateTransition58800 = baseStateMachine1732673470.AddAnyStateTransition(bowDodgeBackwardAnimatorState59126);
			animatorStateTransition58800.canTransitionToSelf = false;
			animatorStateTransition58800.duration = 0.1f;
			animatorStateTransition58800.exitTime = 0.75f;
			animatorStateTransition58800.hasExitTime = false;
			animatorStateTransition58800.hasFixedDuration = true;
			animatorStateTransition58800.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58800.offset = 0f;
			animatorStateTransition58800.orderedInterruption = true;
			animatorStateTransition58800.isExit = false;
			animatorStateTransition58800.mute = false;
			animatorStateTransition58800.solo = false;
			animatorStateTransition58800.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58800.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58800.AddCondition(AnimatorConditionMode.Equals, 3f, "AbilityIntData");
			animatorStateTransition58800.AddCondition(AnimatorConditionMode.Equals, 2f, "MovementSetID");

			var animatorStateTransition58802 = baseStateMachine1732673470.AddAnyStateTransition(bowDodgeForwardAnimatorState59128);
			animatorStateTransition58802.canTransitionToSelf = false;
			animatorStateTransition58802.duration = 0.1f;
			animatorStateTransition58802.exitTime = 0.75f;
			animatorStateTransition58802.hasExitTime = false;
			animatorStateTransition58802.hasFixedDuration = true;
			animatorStateTransition58802.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58802.offset = 0f;
			animatorStateTransition58802.orderedInterruption = true;
			animatorStateTransition58802.isExit = false;
			animatorStateTransition58802.mute = false;
			animatorStateTransition58802.solo = false;
			animatorStateTransition58802.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58802.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58802.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition58802.AddCondition(AnimatorConditionMode.Equals, 2f, "MovementSetID");

			var animatorStateTransition58804 = baseStateMachine1732673470.AddAnyStateTransition(bowDodgeRightFrontAnimatorState59130);
			animatorStateTransition58804.canTransitionToSelf = false;
			animatorStateTransition58804.duration = 0.1f;
			animatorStateTransition58804.exitTime = 0.75f;
			animatorStateTransition58804.hasExitTime = false;
			animatorStateTransition58804.hasFixedDuration = true;
			animatorStateTransition58804.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58804.offset = 0f;
			animatorStateTransition58804.orderedInterruption = true;
			animatorStateTransition58804.isExit = false;
			animatorStateTransition58804.mute = false;
			animatorStateTransition58804.solo = false;
			animatorStateTransition58804.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58804.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58804.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition58804.AddCondition(AnimatorConditionMode.Equals, 2f, "MovementSetID");
			animatorStateTransition58804.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var animatorStateTransition58806 = baseStateMachine1732673470.AddAnyStateTransition(bowDodgeLeftFrontAnimatorState59132);
			animatorStateTransition58806.canTransitionToSelf = false;
			animatorStateTransition58806.duration = 0.1f;
			animatorStateTransition58806.exitTime = 0.75f;
			animatorStateTransition58806.hasExitTime = false;
			animatorStateTransition58806.hasFixedDuration = true;
			animatorStateTransition58806.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58806.offset = 0f;
			animatorStateTransition58806.orderedInterruption = true;
			animatorStateTransition58806.isExit = false;
			animatorStateTransition58806.mute = false;
			animatorStateTransition58806.solo = false;
			animatorStateTransition58806.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58806.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58806.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			animatorStateTransition58806.AddCondition(AnimatorConditionMode.Equals, 2f, "MovementSetID");
			animatorStateTransition58806.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var animatorStateTransition58808 = baseStateMachine1732673470.AddAnyStateTransition(bowDodgeLeftBackAnimatorState59134);
			animatorStateTransition58808.canTransitionToSelf = false;
			animatorStateTransition58808.duration = 0.1f;
			animatorStateTransition58808.exitTime = 0.75f;
			animatorStateTransition58808.hasExitTime = false;
			animatorStateTransition58808.hasFixedDuration = true;
			animatorStateTransition58808.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58808.offset = 0f;
			animatorStateTransition58808.orderedInterruption = true;
			animatorStateTransition58808.isExit = false;
			animatorStateTransition58808.mute = false;
			animatorStateTransition58808.solo = false;
			animatorStateTransition58808.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58808.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58808.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			animatorStateTransition58808.AddCondition(AnimatorConditionMode.Equals, 2f, "MovementSetID");
			animatorStateTransition58808.AddCondition(AnimatorConditionMode.Less, 0.499f, "LegIndex");

			var animatorStateTransition58810 = baseStateMachine1732673470.AddAnyStateTransition(bowDodgeRightBackAnimatorState59136);
			animatorStateTransition58810.canTransitionToSelf = false;
			animatorStateTransition58810.duration = 0.1f;
			animatorStateTransition58810.exitTime = 0.75f;
			animatorStateTransition58810.hasExitTime = false;
			animatorStateTransition58810.hasFixedDuration = true;
			animatorStateTransition58810.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition58810.offset = 0f;
			animatorStateTransition58810.orderedInterruption = true;
			animatorStateTransition58810.isExit = false;
			animatorStateTransition58810.mute = false;
			animatorStateTransition58810.solo = false;
			animatorStateTransition58810.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition58810.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			animatorStateTransition58810.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition58810.AddCondition(AnimatorConditionMode.Equals, 2f, "MovementSetID");
			animatorStateTransition58810.AddCondition(AnimatorConditionMode.Less, 0.499f, "LegIndex");
		}
	}
}
