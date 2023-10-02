/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

namespace Opsive.UltimateCharacterController.AddOns.Agility.Editor.Inspectors.Character.Abilities
{
	using Opsive.Shared.Editor.Inspectors;
	using Opsive.UltimateCharacterController.Editor.Inspectors.Character.Abilities;
	using Opsive.UltimateCharacterController.Editor.Inspectors.Utility;
	using Opsive.UltimateCharacterController.Editor.Utility;
	using UnityEditor;
	using UnityEditor.Animations;
	using UnityEngine;

	/// <summary>
	/// Draws a custom inspector for the Hang Ability.
	/// </summary>
	[InspectorDrawer(typeof(Hang))]
	public class HangInspectorDrawer : DetectObjectAbilityBaseInspectorDrawer
    {
        /// <summary>
        /// Draws the fields related to the inspector drawer.
        /// </summary>
        /// <param name="target">The object that is being drawn.</param>
        /// <param name="parent">The Unity Object that the object belongs to.</param>
        protected override void DrawInspectorDrawerFields(object target, Object parent)
        {
            // Draw AllowMovements manually so it'll use the MaskField.
            var allowedMovements = (int)InspectorUtility.GetFieldValue<Hang.AllowedMovement>(target, "m_AllowedMovements");
            var allowedMovementsString = System.Enum.GetNames(typeof(Hang.AllowedMovement));
            var value = EditorGUILayout.MaskField(new GUIContent("Allowed Movements", InspectorUtility.GetFieldTooltip(target, "m_AllowedMovements")), allowedMovements, allowedMovementsString);
            if (value != allowedMovements) {
                InspectorUtility.SetFieldValue(target, "m_AllowedMovements", value);
            }

            base.DrawInspectorDrawerFields(target, parent);
        }

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
			if (animatorController.layers.Length <= 12) {
				Debug.LogWarning("Warning: The animator controller does not contain the same number of layers as the demo animator. All of the animations cannot be added.");
				return;
			}

			var baseStateMachine1477970618 = animatorController.layers[12].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1477970618.stateMachines.Length; ++j) {
					if (baseStateMachine1477970618.stateMachines[j].stateMachine.name == "Hang") {
						baseStateMachine1477970618.RemoveStateMachine(baseStateMachine1477970618.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var hangMovementAnimationClip27282Path = AssetDatabase.GUIDToAssetPath("fd8bcd7a5867d3c489f6e8c561390f5c"); 
			var hangMovementAnimationClip27282 = AnimatorBuilder.GetAnimationClip(hangMovementAnimationClip27282Path, "HangMovement");
			var hangIdleAnimationClip27284Path = AssetDatabase.GUIDToAssetPath("bddb2b4a0e5f12f49b71618b412ff5aa"); 
			var hangIdleAnimationClip27284 = AnimatorBuilder.GetAnimationClip(hangIdleAnimationClip27284Path, "HangIdle");
			var hangStartAnimationClip27288Path = AssetDatabase.GUIDToAssetPath("053d29fbe247cbc4f98bd80634cdad46"); 
			var hangStartAnimationClip27288 = AnimatorBuilder.GetAnimationClip(hangStartAnimationClip27288Path, "HangStart");
			var transferRightAnimationClip27294Path = AssetDatabase.GUIDToAssetPath("04c74e7c306a6cf48813b0ffc2e992db"); 
			var transferRightAnimationClip27294 = AnimatorBuilder.GetAnimationClip(transferRightAnimationClip27294Path, "TransferRight");
			var transferLeftAnimationClip27300Path = AssetDatabase.GUIDToAssetPath("77339d9bf70da1441b2e6b4de0bbc3d8"); 
			var transferLeftAnimationClip27300 = AnimatorBuilder.GetAnimationClip(transferLeftAnimationClip27300Path, "TransferLeft");
			var transferUpAnimationClip27306Path = AssetDatabase.GUIDToAssetPath("9409cd14629cef747a96eac1d5fa22f7"); 
			var transferUpAnimationClip27306 = AnimatorBuilder.GetAnimationClip(transferUpAnimationClip27306Path, "TransferUp");
			var dropStartAnimationClip27310Path = AssetDatabase.GUIDToAssetPath("0b38d3330a39f684ab19e45f90a6eead"); 
			var dropStartAnimationClip27310 = AnimatorBuilder.GetAnimationClip(dropStartAnimationClip27310Path, "DropStart");
			var pullUpAnimationClip27314Path = AssetDatabase.GUIDToAssetPath("c7d5ba824b936f649bbb2747a4a3fc4a"); 
			var pullUpAnimationClip27314 = AnimatorBuilder.GetAnimationClip(pullUpAnimationClip27314Path, "PullUp");
			var transferDownAnimationClip27320Path = AssetDatabase.GUIDToAssetPath("2ee34eba64def1b44a6062121131cc13"); 
			var transferDownAnimationClip27320 = AnimatorBuilder.GetAnimationClip(transferDownAnimationClip27320Path, "TransferDown");
			var hangJumpStartAnimationClip27324Path = AssetDatabase.GUIDToAssetPath("053d29fbe247cbc4f98bd80634cdad46"); 
			var hangJumpStartAnimationClip27324 = AnimatorBuilder.GetAnimationClip(hangJumpStartAnimationClip27324Path, "HangJumpStart");
			var dropStartLedgeStrafeAnimationClip27328Path = AssetDatabase.GUIDToAssetPath("02e3ce0a2c624334d9af402815fa5f5f"); 
			var dropStartLedgeStrafeAnimationClip27328 = AnimatorBuilder.GetAnimationClip(dropStartLedgeStrafeAnimationClip27328Path, "DropStartLedgeStrafe");
			var ladderClimbLefttoHangLeftAnimationClip27334Path = AssetDatabase.GUIDToAssetPath("ed9cbb6a01db29b40a47fd50169a331d"); 
			var ladderClimbLefttoHangLeftAnimationClip27334 = AnimatorBuilder.GetAnimationClip(ladderClimbLefttoHangLeftAnimationClip27334Path, "LadderClimbLefttoHangLeft");
			var ladderClimbRighttoHangLeftAnimationClip27340Path = AssetDatabase.GUIDToAssetPath("ed9cbb6a01db29b40a47fd50169a331d"); 
			var ladderClimbRighttoHangLeftAnimationClip27340 = AnimatorBuilder.GetAnimationClip(ladderClimbRighttoHangLeftAnimationClip27340Path, "LadderClimbRighttoHangLeft");
			var ladderClimbLefttoHangRightAnimationClip27346Path = AssetDatabase.GUIDToAssetPath("ed9cbb6a01db29b40a47fd50169a331d"); 
			var ladderClimbLefttoHangRightAnimationClip27346 = AnimatorBuilder.GetAnimationClip(ladderClimbLefttoHangRightAnimationClip27346Path, "LadderClimbLefttoHangRight");
			var ladderClimbRighttoHangRightAnimationClip27352Path = AssetDatabase.GUIDToAssetPath("ed9cbb6a01db29b40a47fd50169a331d"); 
			var ladderClimbRighttoHangRightAnimationClip27352 = AnimatorBuilder.GetAnimationClip(ladderClimbRighttoHangRightAnimationClip27352Path, "LadderClimbRighttoHangRight");
			var freeClimbtoHangLeftAnimationClip27358Path = AssetDatabase.GUIDToAssetPath("d59ea0cbf5f8ba947ace91c7e593bd22"); 
			var freeClimbtoHangLeftAnimationClip27358 = AnimatorBuilder.GetAnimationClip(freeClimbtoHangLeftAnimationClip27358Path, "FreeClimbtoHangLeft");
			var freeClimbtoHangRightAnimationClip27364Path = AssetDatabase.GUIDToAssetPath("d59ea0cbf5f8ba947ace91c7e593bd22"); 
			var freeClimbtoHangRightAnimationClip27364 = AnimatorBuilder.GetAnimationClip(freeClimbtoHangRightAnimationClip27364Path, "FreeClimbtoHangRight");
			var freeClimbtoHangVerticalAnimationClip488042Path = AssetDatabase.GUIDToAssetPath("00747cc52bbb52c41975e0a5a615b9fa"); 
			var freeClimbtoHangVerticalAnimationClip488042 = AnimatorBuilder.GetAnimationClip(freeClimbtoHangVerticalAnimationClip488042Path, "FreeClimbtoHangVertical");

			// State Machine.
			var hangAnimatorStateMachine218774 = baseStateMachine1477970618.AddStateMachine("Hang", new Vector3(630f, 210f, 0f));

			// States.
			var hangAnimatorState218776 = hangAnimatorStateMachine218774.AddState("Hang", new Vector3(384f, -84f, 0f));
			var hangAnimatorState218776blendTreeBlendTree218778 = new BlendTree();
			AssetDatabase.AddObjectToAsset(hangAnimatorState218776blendTreeBlendTree218778, animatorController);
			hangAnimatorState218776blendTreeBlendTree218778.hideFlags = HideFlags.HideInHierarchy;
			hangAnimatorState218776blendTreeBlendTree218778.blendParameter = "HorizontalMovement";
			hangAnimatorState218776blendTreeBlendTree218778.blendParameterY = "HorizontalMovement";
			hangAnimatorState218776blendTreeBlendTree218778.blendType = BlendTreeType.Simple1D;
			hangAnimatorState218776blendTreeBlendTree218778.maxThreshold = 1f;
			hangAnimatorState218776blendTreeBlendTree218778.minThreshold = -1f;
			hangAnimatorState218776blendTreeBlendTree218778.name = "Blend Tree";
			hangAnimatorState218776blendTreeBlendTree218778.useAutomaticThresholds = false;
			var hangAnimatorState218776blendTreeBlendTree218778Child0 =  new ChildMotion();
			hangAnimatorState218776blendTreeBlendTree218778Child0.motion = hangMovementAnimationClip27282;
			hangAnimatorState218776blendTreeBlendTree218778Child0.cycleOffset = 0f;
			hangAnimatorState218776blendTreeBlendTree218778Child0.directBlendParameter = "HorizontalMovement";
			hangAnimatorState218776blendTreeBlendTree218778Child0.mirror = false;
			hangAnimatorState218776blendTreeBlendTree218778Child0.position = new Vector2(0f, 0f);
			hangAnimatorState218776blendTreeBlendTree218778Child0.threshold = -1f;
			hangAnimatorState218776blendTreeBlendTree218778Child0.timeScale = 1.4f;
			var hangAnimatorState218776blendTreeBlendTree218778Child1 =  new ChildMotion();
			hangAnimatorState218776blendTreeBlendTree218778Child1.motion = hangIdleAnimationClip27284;
			hangAnimatorState218776blendTreeBlendTree218778Child1.cycleOffset = 0f;
			hangAnimatorState218776blendTreeBlendTree218778Child1.directBlendParameter = "HorizontalMovement";
			hangAnimatorState218776blendTreeBlendTree218778Child1.mirror = false;
			hangAnimatorState218776blendTreeBlendTree218778Child1.position = new Vector2(0f, 0f);
			hangAnimatorState218776blendTreeBlendTree218778Child1.threshold = 0f;
			hangAnimatorState218776blendTreeBlendTree218778Child1.timeScale = 1f;
			var hangAnimatorState218776blendTreeBlendTree218778Child2 =  new ChildMotion();
			hangAnimatorState218776blendTreeBlendTree218778Child2.motion = hangMovementAnimationClip27282;
			hangAnimatorState218776blendTreeBlendTree218778Child2.cycleOffset = 0f;
			hangAnimatorState218776blendTreeBlendTree218778Child2.directBlendParameter = "HorizontalMovement";
			hangAnimatorState218776blendTreeBlendTree218778Child2.mirror = false;
			hangAnimatorState218776blendTreeBlendTree218778Child2.position = new Vector2(0f, 0f);
			hangAnimatorState218776blendTreeBlendTree218778Child2.threshold = 1f;
			hangAnimatorState218776blendTreeBlendTree218778Child2.timeScale = -1.4f;
			hangAnimatorState218776blendTreeBlendTree218778.children = new ChildMotion[] {
				hangAnimatorState218776blendTreeBlendTree218778Child0,
				hangAnimatorState218776blendTreeBlendTree218778Child1,
				hangAnimatorState218776blendTreeBlendTree218778Child2
			};
			hangAnimatorState218776.motion = hangAnimatorState218776blendTreeBlendTree218778;
			hangAnimatorState218776.cycleOffset = 0f;
			hangAnimatorState218776.cycleOffsetParameterActive = false;
			hangAnimatorState218776.iKOnFeet = false;
			hangAnimatorState218776.mirror = false;
			hangAnimatorState218776.mirrorParameterActive = false;
			hangAnimatorState218776.speed = 1f;
			hangAnimatorState218776.speedParameterActive = false;
			hangAnimatorState218776.writeDefaultValues = false;

			var hangStartAnimatorState218780 = hangAnimatorStateMachine218774.AddState("Hang Start", new Vector3(384f, -192f, 0f));
			hangStartAnimatorState218780.motion = hangStartAnimationClip27288;
			hangStartAnimatorState218780.cycleOffset = 0f;
			hangStartAnimatorState218780.cycleOffsetParameterActive = false;
			hangStartAnimatorState218780.iKOnFeet = false;
			hangStartAnimatorState218780.mirror = false;
			hangStartAnimatorState218780.mirrorParameterActive = false;
			hangStartAnimatorState218780.speed = 2f;
			hangStartAnimatorState218780.speedParameterActive = false;
			hangStartAnimatorState218780.writeDefaultValues = false;

			var transferRightAnimatorState218782 = hangAnimatorStateMachine218774.AddState("Transfer Right", new Vector3(588f, 12f, 0f));
			transferRightAnimatorState218782.motion = transferRightAnimationClip27294;
			transferRightAnimatorState218782.cycleOffset = 0f;
			transferRightAnimatorState218782.cycleOffsetParameterActive = false;
			transferRightAnimatorState218782.iKOnFeet = true;
			transferRightAnimatorState218782.mirror = false;
			transferRightAnimatorState218782.mirrorParameterActive = false;
			transferRightAnimatorState218782.speed = 1.4f;
			transferRightAnimatorState218782.speedParameterActive = false;
			transferRightAnimatorState218782.writeDefaultValues = true;

			var transferLeftAnimatorState218784 = hangAnimatorStateMachine218774.AddState("Transfer Left", new Vector3(180f, 12f, 0f));
			transferLeftAnimatorState218784.motion = transferLeftAnimationClip27300;
			transferLeftAnimatorState218784.cycleOffset = 0f;
			transferLeftAnimatorState218784.cycleOffsetParameterActive = false;
			transferLeftAnimatorState218784.iKOnFeet = true;
			transferLeftAnimatorState218784.mirror = false;
			transferLeftAnimatorState218784.mirrorParameterActive = false;
			transferLeftAnimatorState218784.speed = 1.4f;
			transferLeftAnimatorState218784.speedParameterActive = false;
			transferLeftAnimatorState218784.writeDefaultValues = true;

			var transferUpAnimatorState218786 = hangAnimatorStateMachine218774.AddState("Transfer Up", new Vector3(264f, 84f, 0f));
			transferUpAnimatorState218786.motion = transferUpAnimationClip27306;
			transferUpAnimatorState218786.cycleOffset = 0f;
			transferUpAnimatorState218786.cycleOffsetParameterActive = false;
			transferUpAnimatorState218786.iKOnFeet = true;
			transferUpAnimatorState218786.mirror = false;
			transferUpAnimatorState218786.mirrorParameterActive = false;
			transferUpAnimatorState218786.speed = 1.4f;
			transferUpAnimatorState218786.speedParameterActive = false;
			transferUpAnimatorState218786.writeDefaultValues = true;

			var dropStartAnimatorState218788 = hangAnimatorStateMachine218774.AddState("Drop Start", new Vector3(132f, -192f, 0f));
			dropStartAnimatorState218788.motion = dropStartAnimationClip27310;
			dropStartAnimatorState218788.cycleOffset = 0f;
			dropStartAnimatorState218788.cycleOffsetParameterActive = false;
			dropStartAnimatorState218788.iKOnFeet = true;
			dropStartAnimatorState218788.mirror = false;
			dropStartAnimatorState218788.mirrorParameterActive = false;
			dropStartAnimatorState218788.speed = 1.3f;
			dropStartAnimatorState218788.speedParameterActive = false;
			dropStartAnimatorState218788.writeDefaultValues = true;

			var pullUpAnimatorState218790 = hangAnimatorStateMachine218774.AddState("Pull Up", new Vector3(384f, 168f, 0f));
			pullUpAnimatorState218790.motion = pullUpAnimationClip27314;
			pullUpAnimatorState218790.cycleOffset = 0f;
			pullUpAnimatorState218790.cycleOffsetParameter = "HorizontalMovement";
			pullUpAnimatorState218790.cycleOffsetParameterActive = false;
			pullUpAnimatorState218790.iKOnFeet = true;
			pullUpAnimatorState218790.mirror = false;
			pullUpAnimatorState218790.mirrorParameterActive = false;
			pullUpAnimatorState218790.speed = 1.4f;
			pullUpAnimatorState218790.speedParameterActive = false;
			pullUpAnimatorState218790.writeDefaultValues = true;

			var transferDownAnimatorState218792 = hangAnimatorStateMachine218774.AddState("Transfer Down", new Vector3(504f, 84f, 0f));
			transferDownAnimatorState218792.motion = transferDownAnimationClip27320;
			transferDownAnimatorState218792.cycleOffset = 0f;
			transferDownAnimatorState218792.cycleOffsetParameterActive = false;
			transferDownAnimatorState218792.iKOnFeet = true;
			transferDownAnimatorState218792.mirror = false;
			transferDownAnimatorState218792.mirrorParameterActive = false;
			transferDownAnimatorState218792.speed = 1.4f;
			transferDownAnimatorState218792.speedParameterActive = false;
			transferDownAnimatorState218792.writeDefaultValues = true;

			var hangJumpStartAnimatorState218794 = hangAnimatorStateMachine218774.AddState("Hang Jump Start", new Vector3(624f, -192f, 0f));
			hangJumpStartAnimatorState218794.motion = hangJumpStartAnimationClip27324;
			hangJumpStartAnimatorState218794.cycleOffset = 0f;
			hangJumpStartAnimatorState218794.cycleOffsetParameterActive = false;
			hangJumpStartAnimatorState218794.iKOnFeet = false;
			hangJumpStartAnimatorState218794.mirror = false;
			hangJumpStartAnimatorState218794.mirrorParameterActive = false;
			hangJumpStartAnimatorState218794.speed = 1f;
			hangJumpStartAnimatorState218794.speedParameterActive = false;
			hangJumpStartAnimatorState218794.writeDefaultValues = false;

			var dropStartfromLedgeStrafeAnimatorState218796 = hangAnimatorStateMachine218774.AddState("Drop Start from Ledge Strafe", new Vector3(132f, -264f, 0f));
			dropStartfromLedgeStrafeAnimatorState218796.motion = dropStartLedgeStrafeAnimationClip27328;
			dropStartfromLedgeStrafeAnimatorState218796.cycleOffset = 0f;
			dropStartfromLedgeStrafeAnimatorState218796.cycleOffsetParameterActive = false;
			dropStartfromLedgeStrafeAnimatorState218796.iKOnFeet = true;
			dropStartfromLedgeStrafeAnimatorState218796.mirror = false;
			dropStartfromLedgeStrafeAnimatorState218796.mirrorParameterActive = false;
			dropStartfromLedgeStrafeAnimatorState218796.speed = 1.3f;
			dropStartfromLedgeStrafeAnimatorState218796.speedParameterActive = false;
			dropStartfromLedgeStrafeAnimatorState218796.writeDefaultValues = true;

			// State Machine.
			var ladderClimbtoHangAnimatorStateMachine218798 = hangAnimatorStateMachine218774.AddStateMachine("Ladder Climb to Hang", new Vector3(790f, 130f, 0f));

			// States.
			var ladderClimbLefttoHangLeftAnimatorState218800 = ladderClimbtoHangAnimatorStateMachine218798.AddState("Ladder Climb Left to Hang Left", new Vector3(400f, -60f, 0f));
			ladderClimbLefttoHangLeftAnimatorState218800.motion = ladderClimbLefttoHangLeftAnimationClip27334;
			ladderClimbLefttoHangLeftAnimatorState218800.cycleOffset = 0f;
			ladderClimbLefttoHangLeftAnimatorState218800.cycleOffsetParameterActive = false;
			ladderClimbLefttoHangLeftAnimatorState218800.iKOnFeet = false;
			ladderClimbLefttoHangLeftAnimatorState218800.mirror = false;
			ladderClimbLefttoHangLeftAnimatorState218800.mirrorParameterActive = false;
			ladderClimbLefttoHangLeftAnimatorState218800.speed = 1f;
			ladderClimbLefttoHangLeftAnimatorState218800.speedParameterActive = false;
			ladderClimbLefttoHangLeftAnimatorState218800.writeDefaultValues = true;

			var ladderClimbRighttoHangLeftAnimatorState218802 = ladderClimbtoHangAnimatorStateMachine218798.AddState("Ladder Climb Right to Hang Left", new Vector3(400f, 0f, 0f));
			ladderClimbRighttoHangLeftAnimatorState218802.motion = ladderClimbRighttoHangLeftAnimationClip27340;
			ladderClimbRighttoHangLeftAnimatorState218802.cycleOffset = 0f;
			ladderClimbRighttoHangLeftAnimatorState218802.cycleOffsetParameterActive = false;
			ladderClimbRighttoHangLeftAnimatorState218802.iKOnFeet = false;
			ladderClimbRighttoHangLeftAnimatorState218802.mirror = false;
			ladderClimbRighttoHangLeftAnimatorState218802.mirrorParameterActive = false;
			ladderClimbRighttoHangLeftAnimatorState218802.speed = 1f;
			ladderClimbRighttoHangLeftAnimatorState218802.speedParameterActive = false;
			ladderClimbRighttoHangLeftAnimatorState218802.writeDefaultValues = true;

			var ladderClimbLefttoHangRightAnimatorState218804 = ladderClimbtoHangAnimatorStateMachine218798.AddState("Ladder Climb Left to Hang Right", new Vector3(400f, 60f, 0f));
			ladderClimbLefttoHangRightAnimatorState218804.motion = ladderClimbLefttoHangRightAnimationClip27346;
			ladderClimbLefttoHangRightAnimatorState218804.cycleOffset = 0f;
			ladderClimbLefttoHangRightAnimatorState218804.cycleOffsetParameterActive = false;
			ladderClimbLefttoHangRightAnimatorState218804.iKOnFeet = false;
			ladderClimbLefttoHangRightAnimatorState218804.mirror = false;
			ladderClimbLefttoHangRightAnimatorState218804.mirrorParameterActive = false;
			ladderClimbLefttoHangRightAnimatorState218804.speed = 1f;
			ladderClimbLefttoHangRightAnimatorState218804.speedParameterActive = false;
			ladderClimbLefttoHangRightAnimatorState218804.writeDefaultValues = true;

			var ladderClimbRighttoHangRightAnimatorState218806 = ladderClimbtoHangAnimatorStateMachine218798.AddState("Ladder Climb Right to Hang Right", new Vector3(400f, 120f, 0f));
			ladderClimbRighttoHangRightAnimatorState218806.motion = ladderClimbRighttoHangRightAnimationClip27352;
			ladderClimbRighttoHangRightAnimatorState218806.cycleOffset = 0f;
			ladderClimbRighttoHangRightAnimatorState218806.cycleOffsetParameterActive = false;
			ladderClimbRighttoHangRightAnimatorState218806.iKOnFeet = false;
			ladderClimbRighttoHangRightAnimatorState218806.mirror = false;
			ladderClimbRighttoHangRightAnimatorState218806.mirrorParameterActive = false;
			ladderClimbRighttoHangRightAnimatorState218806.speed = 1f;
			ladderClimbRighttoHangRightAnimatorState218806.speedParameterActive = false;
			ladderClimbRighttoHangRightAnimatorState218806.writeDefaultValues = true;

			// State Machine Defaults.
			ladderClimbtoHangAnimatorStateMachine218798.anyStatePosition = new Vector3(40f, -30f, 0f);
			ladderClimbtoHangAnimatorStateMachine218798.defaultState = ladderClimbLefttoHangLeftAnimatorState218800;
			ladderClimbtoHangAnimatorStateMachine218798.entryPosition = new Vector3(40f, -70f, 0f);
			ladderClimbtoHangAnimatorStateMachine218798.exitPosition = new Vector3(800f, 120f, 0f);
			ladderClimbtoHangAnimatorStateMachine218798.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Machine.
			var freeClimbtoHangAnimatorStateMachine218808 = hangAnimatorStateMachine218774.AddStateMachine("Free Climb to Hang", new Vector3(790f, 180f, 0f));

			// States.
			var freeClimbtoHangLeftAnimatorState218810 = freeClimbtoHangAnimatorStateMachine218808.AddState("Free Climb to Hang Left", new Vector3(400f, -10f, 0f));
			freeClimbtoHangLeftAnimatorState218810.motion = freeClimbtoHangLeftAnimationClip27358;
			freeClimbtoHangLeftAnimatorState218810.cycleOffset = 0f;
			freeClimbtoHangLeftAnimatorState218810.cycleOffsetParameterActive = false;
			freeClimbtoHangLeftAnimatorState218810.iKOnFeet = true;
			freeClimbtoHangLeftAnimatorState218810.mirror = false;
			freeClimbtoHangLeftAnimatorState218810.mirrorParameterActive = false;
			freeClimbtoHangLeftAnimatorState218810.speed = 1f;
			freeClimbtoHangLeftAnimatorState218810.speedParameterActive = false;
			freeClimbtoHangLeftAnimatorState218810.writeDefaultValues = true;

			var freeClimbtoHangRightAnimatorState218812 = freeClimbtoHangAnimatorStateMachine218808.AddState("Free Climb to Hang Right", new Vector3(400f, 50f, 0f));
			freeClimbtoHangRightAnimatorState218812.motion = freeClimbtoHangRightAnimationClip27364;
			freeClimbtoHangRightAnimatorState218812.cycleOffset = 0f;
			freeClimbtoHangRightAnimatorState218812.cycleOffsetParameterActive = false;
			freeClimbtoHangRightAnimatorState218812.iKOnFeet = true;
			freeClimbtoHangRightAnimatorState218812.mirror = false;
			freeClimbtoHangRightAnimatorState218812.mirrorParameterActive = false;
			freeClimbtoHangRightAnimatorState218812.speed = 1f;
			freeClimbtoHangRightAnimatorState218812.speedParameterActive = false;
			freeClimbtoHangRightAnimatorState218812.writeDefaultValues = true;

			var freeClimbtoHangVerticalAnimatorState218814 = freeClimbtoHangAnimatorStateMachine218808.AddState("Free Climb to Hang Vertical", new Vector3(400f, 110f, 0f));
			freeClimbtoHangVerticalAnimatorState218814.motion = freeClimbtoHangVerticalAnimationClip488042;
			freeClimbtoHangVerticalAnimatorState218814.cycleOffset = 0f;
			freeClimbtoHangVerticalAnimatorState218814.cycleOffsetParameterActive = false;
			freeClimbtoHangVerticalAnimatorState218814.iKOnFeet = true;
			freeClimbtoHangVerticalAnimatorState218814.mirror = false;
			freeClimbtoHangVerticalAnimatorState218814.mirrorParameterActive = false;
			freeClimbtoHangVerticalAnimatorState218814.speed = 1.5f;
			freeClimbtoHangVerticalAnimatorState218814.speedParameterActive = false;
			freeClimbtoHangVerticalAnimatorState218814.writeDefaultValues = true;

			// State Machine Defaults.
			freeClimbtoHangAnimatorStateMachine218808.anyStatePosition = new Vector3(50f, 20f, 0f);
			freeClimbtoHangAnimatorStateMachine218808.defaultState = freeClimbtoHangLeftAnimatorState218810;
			freeClimbtoHangAnimatorStateMachine218808.entryPosition = new Vector3(50f, 120f, 0f);
			freeClimbtoHangAnimatorStateMachine218808.exitPosition = new Vector3(800f, 120f, 0f);
			freeClimbtoHangAnimatorStateMachine218808.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Machine Defaults.
			hangAnimatorStateMachine218774.anyStatePosition = new Vector3(-84f, -72f, 0f);
			hangAnimatorStateMachine218774.defaultState = hangAnimatorState218776;
			hangAnimatorStateMachine218774.entryPosition = new Vector3(-84f, -156f, 0f);
			hangAnimatorStateMachine218774.exitPosition = new Vector3(876f, -84f, 0f);
			hangAnimatorStateMachine218774.parentStateMachinePosition = new Vector3(852f, -168f, 0f);

			// State Transitions.
			var animatorStateTransition218816 = hangAnimatorState218776.AddExitTransition();
			animatorStateTransition218816.canTransitionToSelf = true;
			animatorStateTransition218816.duration = 0.15f;
			animatorStateTransition218816.exitTime = 0.91f;
			animatorStateTransition218816.hasExitTime = false;
			animatorStateTransition218816.hasFixedDuration = true;
			animatorStateTransition218816.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218816.offset = 0f;
			animatorStateTransition218816.orderedInterruption = true;
			animatorStateTransition218816.isExit = true;
			animatorStateTransition218816.mute = false;
			animatorStateTransition218816.solo = false;
			animatorStateTransition218816.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var animatorStateTransition218818 = hangAnimatorState218776.AddTransition(transferRightAnimatorState218782);
			animatorStateTransition218818.canTransitionToSelf = true;
			animatorStateTransition218818.duration = 0.15f;
			animatorStateTransition218818.exitTime = 0.91f;
			animatorStateTransition218818.hasExitTime = false;
			animatorStateTransition218818.hasFixedDuration = true;
			animatorStateTransition218818.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218818.offset = 0f;
			animatorStateTransition218818.orderedInterruption = true;
			animatorStateTransition218818.isExit = false;
			animatorStateTransition218818.mute = false;
			animatorStateTransition218818.solo = false;
			animatorStateTransition218818.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218818.AddCondition(AnimatorConditionMode.Equals, 4f, "AbilityIntData");

			var animatorStateTransition218820 = hangAnimatorState218776.AddTransition(transferUpAnimatorState218786);
			animatorStateTransition218820.canTransitionToSelf = true;
			animatorStateTransition218820.duration = 0.1f;
			animatorStateTransition218820.exitTime = 0.91f;
			animatorStateTransition218820.hasExitTime = false;
			animatorStateTransition218820.hasFixedDuration = true;
			animatorStateTransition218820.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218820.offset = 0f;
			animatorStateTransition218820.orderedInterruption = true;
			animatorStateTransition218820.isExit = false;
			animatorStateTransition218820.mute = false;
			animatorStateTransition218820.solo = false;
			animatorStateTransition218820.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218820.AddCondition(AnimatorConditionMode.Equals, 3f, "AbilityIntData");

			var animatorStateTransition218822 = hangAnimatorState218776.AddTransition(transferLeftAnimatorState218784);
			animatorStateTransition218822.canTransitionToSelf = true;
			animatorStateTransition218822.duration = 0.15f;
			animatorStateTransition218822.exitTime = 0.91f;
			animatorStateTransition218822.hasExitTime = false;
			animatorStateTransition218822.hasFixedDuration = true;
			animatorStateTransition218822.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218822.offset = 0f;
			animatorStateTransition218822.orderedInterruption = true;
			animatorStateTransition218822.isExit = false;
			animatorStateTransition218822.mute = false;
			animatorStateTransition218822.solo = false;
			animatorStateTransition218822.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218822.AddCondition(AnimatorConditionMode.Equals, 5f, "AbilityIntData");

			var animatorStateTransition218824 = hangAnimatorState218776.AddTransition(pullUpAnimatorState218790);
			animatorStateTransition218824.canTransitionToSelf = true;
			animatorStateTransition218824.duration = 0f;
			animatorStateTransition218824.exitTime = 0.91f;
			animatorStateTransition218824.hasExitTime = false;
			animatorStateTransition218824.hasFixedDuration = false;
			animatorStateTransition218824.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218824.offset = 0f;
			animatorStateTransition218824.orderedInterruption = true;
			animatorStateTransition218824.isExit = false;
			animatorStateTransition218824.mute = false;
			animatorStateTransition218824.solo = false;
			animatorStateTransition218824.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218824.AddCondition(AnimatorConditionMode.Equals, 7f, "AbilityIntData");

			var animatorStateTransition218826 = hangAnimatorState218776.AddTransition(transferDownAnimatorState218792);
			animatorStateTransition218826.canTransitionToSelf = true;
			animatorStateTransition218826.duration = 0.15f;
			animatorStateTransition218826.exitTime = 0.91f;
			animatorStateTransition218826.hasExitTime = false;
			animatorStateTransition218826.hasFixedDuration = true;
			animatorStateTransition218826.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218826.offset = 0f;
			animatorStateTransition218826.orderedInterruption = true;
			animatorStateTransition218826.isExit = false;
			animatorStateTransition218826.mute = false;
			animatorStateTransition218826.solo = false;
			animatorStateTransition218826.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218826.AddCondition(AnimatorConditionMode.Equals, 6f, "AbilityIntData");

			var animatorStateTransition218828 = hangStartAnimatorState218780.AddTransition(hangAnimatorState218776);
			animatorStateTransition218828.canTransitionToSelf = true;
			animatorStateTransition218828.duration = 0.05f;
			animatorStateTransition218828.exitTime = 0.95f;
			animatorStateTransition218828.hasExitTime = true;
			animatorStateTransition218828.hasFixedDuration = true;
			animatorStateTransition218828.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218828.offset = 0f;
			animatorStateTransition218828.orderedInterruption = true;
			animatorStateTransition218828.isExit = false;
			animatorStateTransition218828.mute = false;
			animatorStateTransition218828.solo = false;

			var animatorStateTransition218830 = transferRightAnimatorState218782.AddTransition(hangAnimatorState218776);
			animatorStateTransition218830.canTransitionToSelf = true;
			animatorStateTransition218830.duration = 0.15f;
			animatorStateTransition218830.exitTime = 0.95f;
			animatorStateTransition218830.hasExitTime = true;
			animatorStateTransition218830.hasFixedDuration = true;
			animatorStateTransition218830.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218830.offset = 0f;
			animatorStateTransition218830.orderedInterruption = true;
			animatorStateTransition218830.isExit = false;
			animatorStateTransition218830.mute = false;
			animatorStateTransition218830.solo = false;

			var animatorStateTransition218832 = transferRightAnimatorState218782.AddExitTransition();
			animatorStateTransition218832.canTransitionToSelf = true;
			animatorStateTransition218832.duration = 0.15f;
			animatorStateTransition218832.exitTime = 0.9076923f;
			animatorStateTransition218832.hasExitTime = false;
			animatorStateTransition218832.hasFixedDuration = true;
			animatorStateTransition218832.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218832.offset = 0f;
			animatorStateTransition218832.orderedInterruption = true;
			animatorStateTransition218832.isExit = true;
			animatorStateTransition218832.mute = false;
			animatorStateTransition218832.solo = false;
			animatorStateTransition218832.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var animatorStateTransition218834 = transferLeftAnimatorState218784.AddTransition(hangAnimatorState218776);
			animatorStateTransition218834.canTransitionToSelf = true;
			animatorStateTransition218834.duration = 0.15f;
			animatorStateTransition218834.exitTime = 0.95f;
			animatorStateTransition218834.hasExitTime = true;
			animatorStateTransition218834.hasFixedDuration = true;
			animatorStateTransition218834.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218834.offset = 0f;
			animatorStateTransition218834.orderedInterruption = true;
			animatorStateTransition218834.isExit = false;
			animatorStateTransition218834.mute = false;
			animatorStateTransition218834.solo = false;

			var animatorStateTransition218836 = transferLeftAnimatorState218784.AddExitTransition();
			animatorStateTransition218836.canTransitionToSelf = true;
			animatorStateTransition218836.duration = 0.15f;
			animatorStateTransition218836.exitTime = 0.9076923f;
			animatorStateTransition218836.hasExitTime = false;
			animatorStateTransition218836.hasFixedDuration = true;
			animatorStateTransition218836.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218836.offset = 0f;
			animatorStateTransition218836.orderedInterruption = true;
			animatorStateTransition218836.isExit = true;
			animatorStateTransition218836.mute = false;
			animatorStateTransition218836.solo = false;
			animatorStateTransition218836.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var animatorStateTransition218838 = transferUpAnimatorState218786.AddTransition(hangAnimatorState218776);
			animatorStateTransition218838.canTransitionToSelf = true;
			animatorStateTransition218838.duration = 0.15f;
			animatorStateTransition218838.exitTime = 0.95f;
			animatorStateTransition218838.hasExitTime = true;
			animatorStateTransition218838.hasFixedDuration = true;
			animatorStateTransition218838.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218838.offset = 0f;
			animatorStateTransition218838.orderedInterruption = true;
			animatorStateTransition218838.isExit = false;
			animatorStateTransition218838.mute = false;
			animatorStateTransition218838.solo = false;

			var animatorStateTransition218840 = transferUpAnimatorState218786.AddExitTransition();
			animatorStateTransition218840.canTransitionToSelf = true;
			animatorStateTransition218840.duration = 0.15f;
			animatorStateTransition218840.exitTime = 0.8823529f;
			animatorStateTransition218840.hasExitTime = false;
			animatorStateTransition218840.hasFixedDuration = true;
			animatorStateTransition218840.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218840.offset = 0f;
			animatorStateTransition218840.orderedInterruption = true;
			animatorStateTransition218840.isExit = true;
			animatorStateTransition218840.mute = false;
			animatorStateTransition218840.solo = false;
			animatorStateTransition218840.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var animatorStateTransition218842 = dropStartAnimatorState218788.AddTransition(hangAnimatorState218776);
			animatorStateTransition218842.canTransitionToSelf = true;
			animatorStateTransition218842.duration = 0.15f;
			animatorStateTransition218842.exitTime = 0.99f;
			animatorStateTransition218842.hasExitTime = true;
			animatorStateTransition218842.hasFixedDuration = true;
			animatorStateTransition218842.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218842.offset = 0f;
			animatorStateTransition218842.orderedInterruption = true;
			animatorStateTransition218842.isExit = false;
			animatorStateTransition218842.mute = false;
			animatorStateTransition218842.solo = false;

			var animatorStateTransition218844 = pullUpAnimatorState218790.AddExitTransition();
			animatorStateTransition218844.canTransitionToSelf = true;
			animatorStateTransition218844.duration = 0.25f;
			animatorStateTransition218844.exitTime = 0.95f;
			animatorStateTransition218844.hasExitTime = false;
			animatorStateTransition218844.hasFixedDuration = true;
			animatorStateTransition218844.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218844.offset = 0f;
			animatorStateTransition218844.orderedInterruption = true;
			animatorStateTransition218844.isExit = true;
			animatorStateTransition218844.mute = false;
			animatorStateTransition218844.solo = false;
			animatorStateTransition218844.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var animatorStateTransition218846 = transferDownAnimatorState218792.AddTransition(hangAnimatorState218776);
			animatorStateTransition218846.canTransitionToSelf = true;
			animatorStateTransition218846.duration = 0.15f;
			animatorStateTransition218846.exitTime = 0.95f;
			animatorStateTransition218846.hasExitTime = true;
			animatorStateTransition218846.hasFixedDuration = true;
			animatorStateTransition218846.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218846.offset = 0f;
			animatorStateTransition218846.orderedInterruption = true;
			animatorStateTransition218846.isExit = false;
			animatorStateTransition218846.mute = false;
			animatorStateTransition218846.solo = false;

			var animatorStateTransition218848 = transferDownAnimatorState218792.AddExitTransition();
			animatorStateTransition218848.canTransitionToSelf = true;
			animatorStateTransition218848.duration = 0.15f;
			animatorStateTransition218848.exitTime = 0.8823529f;
			animatorStateTransition218848.hasExitTime = false;
			animatorStateTransition218848.hasFixedDuration = true;
			animatorStateTransition218848.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218848.offset = 0f;
			animatorStateTransition218848.orderedInterruption = true;
			animatorStateTransition218848.isExit = true;
			animatorStateTransition218848.mute = false;
			animatorStateTransition218848.solo = false;
			animatorStateTransition218848.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var animatorStateTransition218850 = hangJumpStartAnimatorState218794.AddTransition(hangAnimatorState218776);
			animatorStateTransition218850.canTransitionToSelf = true;
			animatorStateTransition218850.duration = 0.05f;
			animatorStateTransition218850.exitTime = 0.95f;
			animatorStateTransition218850.hasExitTime = true;
			animatorStateTransition218850.hasFixedDuration = true;
			animatorStateTransition218850.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218850.offset = 0f;
			animatorStateTransition218850.orderedInterruption = true;
			animatorStateTransition218850.isExit = false;
			animatorStateTransition218850.mute = false;
			animatorStateTransition218850.solo = false;

			var animatorStateTransition218852 = dropStartfromLedgeStrafeAnimatorState218796.AddTransition(hangAnimatorState218776);
			animatorStateTransition218852.canTransitionToSelf = true;
			animatorStateTransition218852.duration = 0.15f;
			animatorStateTransition218852.exitTime = 0.99f;
			animatorStateTransition218852.hasExitTime = true;
			animatorStateTransition218852.hasFixedDuration = true;
			animatorStateTransition218852.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218852.offset = 0f;
			animatorStateTransition218852.orderedInterruption = true;
			animatorStateTransition218852.isExit = false;
			animatorStateTransition218852.mute = false;
			animatorStateTransition218852.solo = false;

			// State Transitions.
			var animatorStateTransition218854 = ladderClimbLefttoHangLeftAnimatorState218800.AddTransition(hangAnimatorState218776);
			animatorStateTransition218854.canTransitionToSelf = true;
			animatorStateTransition218854.duration = 0.05f;
			animatorStateTransition218854.exitTime = 1f;
			animatorStateTransition218854.hasExitTime = true;
			animatorStateTransition218854.hasFixedDuration = true;
			animatorStateTransition218854.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218854.offset = 0f;
			animatorStateTransition218854.orderedInterruption = true;
			animatorStateTransition218854.isExit = false;
			animatorStateTransition218854.mute = false;
			animatorStateTransition218854.solo = false;
			animatorStateTransition218854.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");

			var animatorStateTransition218856 = ladderClimbLefttoHangLeftAnimatorState218800.AddExitTransition();
			animatorStateTransition218856.canTransitionToSelf = true;
			animatorStateTransition218856.duration = 0.05f;
			animatorStateTransition218856.exitTime = 0.88f;
			animatorStateTransition218856.hasExitTime = false;
			animatorStateTransition218856.hasFixedDuration = true;
			animatorStateTransition218856.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218856.offset = 0f;
			animatorStateTransition218856.orderedInterruption = true;
			animatorStateTransition218856.isExit = true;
			animatorStateTransition218856.mute = false;
			animatorStateTransition218856.solo = false;
			animatorStateTransition218856.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var animatorStateTransition218858 = ladderClimbRighttoHangLeftAnimatorState218802.AddTransition(hangAnimatorState218776);
			animatorStateTransition218858.canTransitionToSelf = true;
			animatorStateTransition218858.duration = 0.05f;
			animatorStateTransition218858.exitTime = 1f;
			animatorStateTransition218858.hasExitTime = true;
			animatorStateTransition218858.hasFixedDuration = true;
			animatorStateTransition218858.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218858.offset = 0f;
			animatorStateTransition218858.orderedInterruption = true;
			animatorStateTransition218858.isExit = false;
			animatorStateTransition218858.mute = false;
			animatorStateTransition218858.solo = false;
			animatorStateTransition218858.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");

			var animatorStateTransition218860 = ladderClimbRighttoHangLeftAnimatorState218802.AddExitTransition();
			animatorStateTransition218860.canTransitionToSelf = true;
			animatorStateTransition218860.duration = 0.05f;
			animatorStateTransition218860.exitTime = 0.88f;
			animatorStateTransition218860.hasExitTime = false;
			animatorStateTransition218860.hasFixedDuration = true;
			animatorStateTransition218860.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218860.offset = 0f;
			animatorStateTransition218860.orderedInterruption = true;
			animatorStateTransition218860.isExit = true;
			animatorStateTransition218860.mute = false;
			animatorStateTransition218860.solo = false;
			animatorStateTransition218860.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var animatorStateTransition218862 = ladderClimbLefttoHangRightAnimatorState218804.AddTransition(hangAnimatorState218776);
			animatorStateTransition218862.canTransitionToSelf = true;
			animatorStateTransition218862.duration = 0.05f;
			animatorStateTransition218862.exitTime = 1f;
			animatorStateTransition218862.hasExitTime = true;
			animatorStateTransition218862.hasFixedDuration = true;
			animatorStateTransition218862.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218862.offset = 0f;
			animatorStateTransition218862.orderedInterruption = true;
			animatorStateTransition218862.isExit = false;
			animatorStateTransition218862.mute = false;
			animatorStateTransition218862.solo = false;
			animatorStateTransition218862.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");

			var animatorStateTransition218864 = ladderClimbLefttoHangRightAnimatorState218804.AddExitTransition();
			animatorStateTransition218864.canTransitionToSelf = true;
			animatorStateTransition218864.duration = 0.05f;
			animatorStateTransition218864.exitTime = 0.88f;
			animatorStateTransition218864.hasExitTime = false;
			animatorStateTransition218864.hasFixedDuration = true;
			animatorStateTransition218864.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218864.offset = 0f;
			animatorStateTransition218864.orderedInterruption = true;
			animatorStateTransition218864.isExit = true;
			animatorStateTransition218864.mute = false;
			animatorStateTransition218864.solo = false;
			animatorStateTransition218864.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var animatorStateTransition218866 = ladderClimbRighttoHangRightAnimatorState218806.AddTransition(hangAnimatorState218776);
			animatorStateTransition218866.canTransitionToSelf = true;
			animatorStateTransition218866.duration = 0.05f;
			animatorStateTransition218866.exitTime = 1f;
			animatorStateTransition218866.hasExitTime = true;
			animatorStateTransition218866.hasFixedDuration = true;
			animatorStateTransition218866.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218866.offset = 0f;
			animatorStateTransition218866.orderedInterruption = true;
			animatorStateTransition218866.isExit = false;
			animatorStateTransition218866.mute = false;
			animatorStateTransition218866.solo = false;
			animatorStateTransition218866.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");

			var animatorStateTransition218868 = ladderClimbRighttoHangRightAnimatorState218806.AddExitTransition();
			animatorStateTransition218868.canTransitionToSelf = true;
			animatorStateTransition218868.duration = 0.05f;
			animatorStateTransition218868.exitTime = 0.8823529f;
			animatorStateTransition218868.hasExitTime = false;
			animatorStateTransition218868.hasFixedDuration = true;
			animatorStateTransition218868.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218868.offset = 0f;
			animatorStateTransition218868.orderedInterruption = true;
			animatorStateTransition218868.isExit = true;
			animatorStateTransition218868.mute = false;
			animatorStateTransition218868.solo = false;
			animatorStateTransition218868.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			// State Transitions.
			var animatorStateTransition218870 = freeClimbtoHangLeftAnimatorState218810.AddTransition(hangAnimatorState218776);
			animatorStateTransition218870.canTransitionToSelf = true;
			animatorStateTransition218870.duration = 0.25f;
			animatorStateTransition218870.exitTime = 1f;
			animatorStateTransition218870.hasExitTime = true;
			animatorStateTransition218870.hasFixedDuration = true;
			animatorStateTransition218870.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218870.offset = 0f;
			animatorStateTransition218870.orderedInterruption = true;
			animatorStateTransition218870.isExit = false;
			animatorStateTransition218870.mute = false;
			animatorStateTransition218870.solo = false;
			animatorStateTransition218870.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");

			var animatorStateTransition218872 = freeClimbtoHangLeftAnimatorState218810.AddExitTransition();
			animatorStateTransition218872.canTransitionToSelf = true;
			animatorStateTransition218872.duration = 0.05f;
			animatorStateTransition218872.exitTime = 0.88f;
			animatorStateTransition218872.hasExitTime = false;
			animatorStateTransition218872.hasFixedDuration = true;
			animatorStateTransition218872.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218872.offset = 0f;
			animatorStateTransition218872.orderedInterruption = true;
			animatorStateTransition218872.isExit = true;
			animatorStateTransition218872.mute = false;
			animatorStateTransition218872.solo = false;
			animatorStateTransition218872.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var animatorStateTransition218874 = freeClimbtoHangRightAnimatorState218812.AddTransition(hangAnimatorState218776);
			animatorStateTransition218874.canTransitionToSelf = true;
			animatorStateTransition218874.duration = 0.25f;
			animatorStateTransition218874.exitTime = 1f;
			animatorStateTransition218874.hasExitTime = true;
			animatorStateTransition218874.hasFixedDuration = true;
			animatorStateTransition218874.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218874.offset = 0f;
			animatorStateTransition218874.orderedInterruption = true;
			animatorStateTransition218874.isExit = false;
			animatorStateTransition218874.mute = false;
			animatorStateTransition218874.solo = false;
			animatorStateTransition218874.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");

			var animatorStateTransition218876 = freeClimbtoHangRightAnimatorState218812.AddExitTransition();
			animatorStateTransition218876.canTransitionToSelf = true;
			animatorStateTransition218876.duration = 0.05f;
			animatorStateTransition218876.exitTime = 0.88f;
			animatorStateTransition218876.hasExitTime = false;
			animatorStateTransition218876.hasFixedDuration = true;
			animatorStateTransition218876.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218876.offset = 0f;
			animatorStateTransition218876.orderedInterruption = true;
			animatorStateTransition218876.isExit = true;
			animatorStateTransition218876.mute = false;
			animatorStateTransition218876.solo = false;
			animatorStateTransition218876.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var animatorStateTransition218878 = freeClimbtoHangVerticalAnimatorState218814.AddExitTransition();
			animatorStateTransition218878.canTransitionToSelf = true;
			animatorStateTransition218878.duration = 0.05f;
			animatorStateTransition218878.exitTime = 1f;
			animatorStateTransition218878.hasExitTime = false;
			animatorStateTransition218878.hasFixedDuration = true;
			animatorStateTransition218878.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218878.offset = 0f;
			animatorStateTransition218878.orderedInterruption = true;
			animatorStateTransition218878.isExit = true;
			animatorStateTransition218878.mute = false;
			animatorStateTransition218878.solo = false;
			animatorStateTransition218878.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var animatorStateTransition218880 = freeClimbtoHangVerticalAnimatorState218814.AddTransition(hangAnimatorState218776);
			animatorStateTransition218880.canTransitionToSelf = true;
			animatorStateTransition218880.duration = 0.25f;
			animatorStateTransition218880.exitTime = 1f;
			animatorStateTransition218880.hasExitTime = true;
			animatorStateTransition218880.hasFixedDuration = true;
			animatorStateTransition218880.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218880.offset = 0f;
			animatorStateTransition218880.orderedInterruption = true;
			animatorStateTransition218880.isExit = false;
			animatorStateTransition218880.mute = false;
			animatorStateTransition218880.solo = false;
			animatorStateTransition218880.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");


			// State Machine Transitions.
			var animatorStateTransition218882 = baseStateMachine1477970618.AddAnyStateTransition(dropStartAnimatorState218788);
			animatorStateTransition218882.canTransitionToSelf = false;
			animatorStateTransition218882.duration = 0.15f;
			animatorStateTransition218882.exitTime = 0.75f;
			animatorStateTransition218882.hasExitTime = false;
			animatorStateTransition218882.hasFixedDuration = true;
			animatorStateTransition218882.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218882.offset = 0f;
			animatorStateTransition218882.orderedInterruption = true;
			animatorStateTransition218882.isExit = false;
			animatorStateTransition218882.mute = false;
			animatorStateTransition218882.solo = false;
			animatorStateTransition218882.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition218882.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218882.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition218882.AddCondition(AnimatorConditionMode.Less, 0.1f, "AbilityFloatData");

			var animatorStateTransition218884 = baseStateMachine1477970618.AddAnyStateTransition(hangJumpStartAnimatorState218794);
			animatorStateTransition218884.canTransitionToSelf = false;
			animatorStateTransition218884.duration = 0.05f;
			animatorStateTransition218884.exitTime = 0.75f;
			animatorStateTransition218884.hasExitTime = false;
			animatorStateTransition218884.hasFixedDuration = true;
			animatorStateTransition218884.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218884.offset = 0f;
			animatorStateTransition218884.orderedInterruption = true;
			animatorStateTransition218884.isExit = false;
			animatorStateTransition218884.mute = false;
			animatorStateTransition218884.solo = false;
			animatorStateTransition218884.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition218884.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218884.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");

			var animatorStateTransition218886 = baseStateMachine1477970618.AddAnyStateTransition(dropStartfromLedgeStrafeAnimatorState218796);
			animatorStateTransition218886.canTransitionToSelf = false;
			animatorStateTransition218886.duration = 0.15f;
			animatorStateTransition218886.exitTime = 0.75f;
			animatorStateTransition218886.hasExitTime = false;
			animatorStateTransition218886.hasFixedDuration = true;
			animatorStateTransition218886.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218886.offset = 0f;
			animatorStateTransition218886.orderedInterruption = true;
			animatorStateTransition218886.isExit = false;
			animatorStateTransition218886.mute = false;
			animatorStateTransition218886.solo = false;
			animatorStateTransition218886.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition218886.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218886.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition218886.AddCondition(AnimatorConditionMode.Greater, 0.9f, "AbilityFloatData");
			animatorStateTransition218886.AddCondition(AnimatorConditionMode.Less, 1.1f, "AbilityFloatData");

			var animatorStateTransition218888 = baseStateMachine1477970618.AddAnyStateTransition(hangStartAnimatorState218780);
			animatorStateTransition218888.canTransitionToSelf = false;
			animatorStateTransition218888.duration = 0.2f;
			animatorStateTransition218888.exitTime = 0.75f;
			animatorStateTransition218888.hasExitTime = false;
			animatorStateTransition218888.hasFixedDuration = true;
			animatorStateTransition218888.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218888.offset = 0f;
			animatorStateTransition218888.orderedInterruption = true;
			animatorStateTransition218888.isExit = false;
			animatorStateTransition218888.mute = false;
			animatorStateTransition218888.solo = false;
			animatorStateTransition218888.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition218888.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218888.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");

			var animatorStateTransition218890 = baseStateMachine1477970618.AddAnyStateTransition(ladderClimbLefttoHangLeftAnimatorState218800);
			animatorStateTransition218890.canTransitionToSelf = false;
			animatorStateTransition218890.duration = 0.05f;
			animatorStateTransition218890.exitTime = 0.75f;
			animatorStateTransition218890.hasExitTime = false;
			animatorStateTransition218890.hasFixedDuration = true;
			animatorStateTransition218890.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218890.offset = 0f;
			animatorStateTransition218890.orderedInterruption = true;
			animatorStateTransition218890.isExit = false;
			animatorStateTransition218890.mute = false;
			animatorStateTransition218890.solo = false;
			animatorStateTransition218890.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition218890.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218890.AddCondition(AnimatorConditionMode.Equals, 8f, "AbilityIntData");
			animatorStateTransition218890.AddCondition(AnimatorConditionMode.Less, 0f, "HorizontalMovement");
			animatorStateTransition218890.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var animatorStateTransition218892 = baseStateMachine1477970618.AddAnyStateTransition(ladderClimbRighttoHangLeftAnimatorState218802);
			animatorStateTransition218892.canTransitionToSelf = false;
			animatorStateTransition218892.duration = 0.05f;
			animatorStateTransition218892.exitTime = 0.75f;
			animatorStateTransition218892.hasExitTime = false;
			animatorStateTransition218892.hasFixedDuration = true;
			animatorStateTransition218892.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218892.offset = 0f;
			animatorStateTransition218892.orderedInterruption = true;
			animatorStateTransition218892.isExit = false;
			animatorStateTransition218892.mute = false;
			animatorStateTransition218892.solo = false;
			animatorStateTransition218892.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition218892.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218892.AddCondition(AnimatorConditionMode.Equals, 8f, "AbilityIntData");
			animatorStateTransition218892.AddCondition(AnimatorConditionMode.Less, 0f, "HorizontalMovement");
			animatorStateTransition218892.AddCondition(AnimatorConditionMode.Less, 0.5f, "LegIndex");

			var animatorStateTransition218894 = baseStateMachine1477970618.AddAnyStateTransition(ladderClimbLefttoHangRightAnimatorState218804);
			animatorStateTransition218894.canTransitionToSelf = false;
			animatorStateTransition218894.duration = 0.05f;
			animatorStateTransition218894.exitTime = 0.75f;
			animatorStateTransition218894.hasExitTime = false;
			animatorStateTransition218894.hasFixedDuration = true;
			animatorStateTransition218894.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218894.offset = 0f;
			animatorStateTransition218894.orderedInterruption = true;
			animatorStateTransition218894.isExit = false;
			animatorStateTransition218894.mute = false;
			animatorStateTransition218894.solo = false;
			animatorStateTransition218894.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition218894.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218894.AddCondition(AnimatorConditionMode.Equals, 8f, "AbilityIntData");
			animatorStateTransition218894.AddCondition(AnimatorConditionMode.Greater, 0f, "HorizontalMovement");
			animatorStateTransition218894.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var animatorStateTransition218896 = baseStateMachine1477970618.AddAnyStateTransition(ladderClimbRighttoHangRightAnimatorState218806);
			animatorStateTransition218896.canTransitionToSelf = false;
			animatorStateTransition218896.duration = 0.05f;
			animatorStateTransition218896.exitTime = 0.75f;
			animatorStateTransition218896.hasExitTime = false;
			animatorStateTransition218896.hasFixedDuration = true;
			animatorStateTransition218896.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218896.offset = 0f;
			animatorStateTransition218896.orderedInterruption = true;
			animatorStateTransition218896.isExit = false;
			animatorStateTransition218896.mute = false;
			animatorStateTransition218896.solo = false;
			animatorStateTransition218896.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition218896.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218896.AddCondition(AnimatorConditionMode.Equals, 8f, "AbilityIntData");
			animatorStateTransition218896.AddCondition(AnimatorConditionMode.Greater, 0f, "HorizontalMovement");
			animatorStateTransition218896.AddCondition(AnimatorConditionMode.Less, 0.5f, "LegIndex");

			var animatorStateTransition218898 = baseStateMachine1477970618.AddAnyStateTransition(freeClimbtoHangLeftAnimatorState218810);
			animatorStateTransition218898.canTransitionToSelf = false;
			animatorStateTransition218898.duration = 0.05f;
			animatorStateTransition218898.exitTime = 0.75f;
			animatorStateTransition218898.hasExitTime = false;
			animatorStateTransition218898.hasFixedDuration = true;
			animatorStateTransition218898.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218898.offset = 0f;
			animatorStateTransition218898.orderedInterruption = true;
			animatorStateTransition218898.isExit = false;
			animatorStateTransition218898.mute = false;
			animatorStateTransition218898.solo = false;
			animatorStateTransition218898.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition218898.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218898.AddCondition(AnimatorConditionMode.Equals, 9f, "AbilityIntData");
			animatorStateTransition218898.AddCondition(AnimatorConditionMode.Less, 0f, "HorizontalMovement");

			var animatorStateTransition218900 = baseStateMachine1477970618.AddAnyStateTransition(freeClimbtoHangRightAnimatorState218812);
			animatorStateTransition218900.canTransitionToSelf = false;
			animatorStateTransition218900.duration = 0.05f;
			animatorStateTransition218900.exitTime = 0.75f;
			animatorStateTransition218900.hasExitTime = false;
			animatorStateTransition218900.hasFixedDuration = true;
			animatorStateTransition218900.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218900.offset = 0f;
			animatorStateTransition218900.orderedInterruption = true;
			animatorStateTransition218900.isExit = false;
			animatorStateTransition218900.mute = false;
			animatorStateTransition218900.solo = false;
			animatorStateTransition218900.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition218900.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218900.AddCondition(AnimatorConditionMode.Equals, 9f, "AbilityIntData");
			animatorStateTransition218900.AddCondition(AnimatorConditionMode.Greater, 0f, "HorizontalMovement");

			var animatorStateTransition218902 = baseStateMachine1477970618.AddAnyStateTransition(freeClimbtoHangVerticalAnimatorState218814);
			animatorStateTransition218902.canTransitionToSelf = false;
			animatorStateTransition218902.duration = 0.05f;
			animatorStateTransition218902.exitTime = 0.75f;
			animatorStateTransition218902.hasExitTime = false;
			animatorStateTransition218902.hasFixedDuration = true;
			animatorStateTransition218902.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition218902.offset = 0f;
			animatorStateTransition218902.orderedInterruption = true;
			animatorStateTransition218902.isExit = false;
			animatorStateTransition218902.mute = false;
			animatorStateTransition218902.solo = false;
			animatorStateTransition218902.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition218902.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			animatorStateTransition218902.AddCondition(AnimatorConditionMode.Equals, 10f, "AbilityIntData");
		}
	}
}
