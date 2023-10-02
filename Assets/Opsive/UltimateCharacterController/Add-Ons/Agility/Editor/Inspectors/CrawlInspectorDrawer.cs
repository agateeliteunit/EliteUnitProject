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
	/// Draws a custom inspector for the Crawl Ability.
	/// </summary>
	[InspectorDrawer(typeof(Crawl))]
	public class CrawlInspectorDrawer : AbilityInspectorDrawer
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
			if (animatorController.layers.Length <= 12) {
				Debug.LogWarning("Warning: The animator controller does not contain the same number of layers as the demo animator. All of the animations cannot be added.");
				return;
			}

			var baseStateMachine1660313344 = animatorController.layers[12].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1660313344.stateMachines.Length; ++j) {
					if (baseStateMachine1660313344.stateMachines[j].stateMachine.name == "Crawl") {
						baseStateMachine1660313344.RemoveStateMachine(baseStateMachine1660313344.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var crawlBwdTurnLeftAnimationClip52918Path = AssetDatabase.GUIDToAssetPath("75b8972d94de91d4598aa090536b8daf"); 
			var crawlBwdTurnLeftAnimationClip52918 = AnimatorBuilder.GetAnimationClip(crawlBwdTurnLeftAnimationClip52918Path, "CrawlBwdTurnLeft");
			var crawlBwdAnimationClip52920Path = AssetDatabase.GUIDToAssetPath("e66f1ee8858e9694cbd519fd40d37b71"); 
			var crawlBwdAnimationClip52920 = AnimatorBuilder.GetAnimationClip(crawlBwdAnimationClip52920Path, "CrawlBwd");
			var crawlBwdTurnRightAnimationClip52922Path = AssetDatabase.GUIDToAssetPath("75b8972d94de91d4598aa090536b8daf"); 
			var crawlBwdTurnRightAnimationClip52922 = AnimatorBuilder.GetAnimationClip(crawlBwdTurnRightAnimationClip52922Path, "CrawlBwdTurnRight");
			var crawlStrafeAnimationClip52924Path = AssetDatabase.GUIDToAssetPath("416047b55078be24a9e0531434953979"); 
			var crawlStrafeAnimationClip52924 = AnimatorBuilder.GetAnimationClip(crawlStrafeAnimationClip52924Path, "CrawlStrafe");
			var crawlIdleAnimationClip52926Path = AssetDatabase.GUIDToAssetPath("dad2b6b732153c743bc5764038943df6"); 
			var crawlIdleAnimationClip52926 = AnimatorBuilder.GetAnimationClip(crawlIdleAnimationClip52926Path, "CrawlIdle");
			var crawlFwdTurnLeftAnimationClip52928Path = AssetDatabase.GUIDToAssetPath("75b8972d94de91d4598aa090536b8daf"); 
			var crawlFwdTurnLeftAnimationClip52928 = AnimatorBuilder.GetAnimationClip(crawlFwdTurnLeftAnimationClip52928Path, "CrawlFwdTurnLeft");
			var crawlFwdAnimationClip52930Path = AssetDatabase.GUIDToAssetPath("40930071f4f826547a10efb4ca391bd3"); 
			var crawlFwdAnimationClip52930 = AnimatorBuilder.GetAnimationClip(crawlFwdAnimationClip52930Path, "CrawlFwd");
			var crawlFwdTurnRightAnimationClip52932Path = AssetDatabase.GUIDToAssetPath("75b8972d94de91d4598aa090536b8daf"); 
			var crawlFwdTurnRightAnimationClip52932 = AnimatorBuilder.GetAnimationClip(crawlFwdTurnRightAnimationClip52932Path, "CrawlFwdTurnRight");
			var crawlStartAnimationClip52942Path = AssetDatabase.GUIDToAssetPath("87de1b796b9f8184ab60676491a00064"); 
			var crawlStartAnimationClip52942 = AnimatorBuilder.GetAnimationClip(crawlStartAnimationClip52942Path, "CrawlStart");
			var crawlCrouchStartAnimationClip52944Path = AssetDatabase.GUIDToAssetPath("d1b7e9ce6c89fc64581d452313b5d25b"); 
			var crawlCrouchStartAnimationClip52944 = AnimatorBuilder.GetAnimationClip(crawlCrouchStartAnimationClip52944Path, "CrawlCrouchStart");
			var crawlStopAnimationClip52952Path = AssetDatabase.GUIDToAssetPath("88d87302bce822749814fdaca20ed08d"); 
			var crawlStopAnimationClip52952 = AnimatorBuilder.GetAnimationClip(crawlStopAnimationClip52952Path, "CrawlStop");
			var crawlCrouchStopAnimationClip52954Path = AssetDatabase.GUIDToAssetPath("dd9fead20f0e0914b9cbb9b4edcfb7d3"); 
			var crawlCrouchStopAnimationClip52954 = AnimatorBuilder.GetAnimationClip(crawlCrouchStopAnimationClip52954Path, "CrawlCrouchStop");
			var crawlIdleTurnAnimationClip52962Path = AssetDatabase.GUIDToAssetPath("822d43966b2a09948b0887e36a4749ac"); 
			var crawlIdleTurnAnimationClip52962 = AnimatorBuilder.GetAnimationClip(crawlIdleTurnAnimationClip52962Path, "CrawlIdleTurn");

			// State Machine.
			var crawlAnimatorStateMachine50112 = baseStateMachine1660313344.AddStateMachine("Crawl", new Vector3(624f, 156f, 0f));

			// States.
			var crawlMovementAnimatorState54174 = crawlAnimatorStateMachine50112.AddState("Crawl Movement", new Vector3(624f, 36f, 0f));
			var crawlMovementAnimatorState54174blendTreeBlendTree54184 = new BlendTree();
			AssetDatabase.AddObjectToAsset(crawlMovementAnimatorState54174blendTreeBlendTree54184, animatorController);
			crawlMovementAnimatorState54174blendTreeBlendTree54184.hideFlags = HideFlags.HideInHierarchy;
			crawlMovementAnimatorState54174blendTreeBlendTree54184.blendParameter = "HorizontalMovement";
			crawlMovementAnimatorState54174blendTreeBlendTree54184.blendParameterY = "ForwardMovement";
			crawlMovementAnimatorState54174blendTreeBlendTree54184.blendType = BlendTreeType.SimpleDirectional2D;
			crawlMovementAnimatorState54174blendTreeBlendTree54184.maxThreshold = 7f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184.minThreshold = -1f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184.name = "Blend Tree";
			crawlMovementAnimatorState54174blendTreeBlendTree54184.useAutomaticThresholds = false;
			var crawlMovementAnimatorState54174blendTreeBlendTree54184Child0 =  new ChildMotion();
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child0.motion = crawlBwdTurnLeftAnimationClip52918;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child0.cycleOffset = 0f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child0.directBlendParameter = "HorizontalMovement";
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child0.mirror = false;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child0.position = new Vector2(-1f, -1f);
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child0.threshold = -1f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child0.timeScale = -1.25f;
			var crawlMovementAnimatorState54174blendTreeBlendTree54184Child1 =  new ChildMotion();
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child1.motion = crawlBwdAnimationClip52920;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child1.cycleOffset = 0f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child1.directBlendParameter = "HorizontalMovement";
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child1.mirror = false;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child1.position = new Vector2(0f, -1f);
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child1.threshold = 0f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child1.timeScale = 1.25f;
			var crawlMovementAnimatorState54174blendTreeBlendTree54184Child2 =  new ChildMotion();
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child2.motion = crawlBwdTurnRightAnimationClip52922;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child2.cycleOffset = 0f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child2.directBlendParameter = "HorizontalMovement";
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child2.mirror = false;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child2.position = new Vector2(1f, -1f);
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child2.threshold = 1f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child2.timeScale = -1.25f;
			var crawlMovementAnimatorState54174blendTreeBlendTree54184Child3 =  new ChildMotion();
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child3.motion = crawlStrafeAnimationClip52924;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child3.cycleOffset = 0f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child3.directBlendParameter = "HorizontalMovement";
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child3.mirror = false;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child3.position = new Vector2(-1f, 0f);
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child3.threshold = 2f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child3.timeScale = 1.5f;
			var crawlMovementAnimatorState54174blendTreeBlendTree54184Child4 =  new ChildMotion();
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child4.motion = crawlIdleAnimationClip52926;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child4.cycleOffset = 0f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child4.directBlendParameter = "HorizontalMovement";
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child4.mirror = false;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child4.position = new Vector2(0f, 0f);
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child4.threshold = 3f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child4.timeScale = 1f;
			var crawlMovementAnimatorState54174blendTreeBlendTree54184Child5 =  new ChildMotion();
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child5.motion = crawlStrafeAnimationClip52924;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child5.cycleOffset = 0f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child5.directBlendParameter = "HorizontalMovement";
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child5.mirror = false;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child5.position = new Vector2(1f, 0f);
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child5.threshold = 4f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child5.timeScale = -1.5f;
			var crawlMovementAnimatorState54174blendTreeBlendTree54184Child6 =  new ChildMotion();
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child6.motion = crawlFwdTurnLeftAnimationClip52928;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child6.cycleOffset = 0f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child6.directBlendParameter = "HorizontalMovement";
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child6.mirror = false;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child6.position = new Vector2(-1f, 1f);
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child6.threshold = 5f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child6.timeScale = 1.5f;
			var crawlMovementAnimatorState54174blendTreeBlendTree54184Child7 =  new ChildMotion();
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child7.motion = crawlFwdAnimationClip52930;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child7.cycleOffset = 0f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child7.directBlendParameter = "HorizontalMovement";
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child7.mirror = false;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child7.position = new Vector2(0f, 1f);
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child7.threshold = 6f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child7.timeScale = 1.5f;
			var crawlMovementAnimatorState54174blendTreeBlendTree54184Child8 =  new ChildMotion();
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child8.motion = crawlFwdTurnRightAnimationClip52932;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child8.cycleOffset = 0f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child8.directBlendParameter = "HorizontalMovement";
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child8.mirror = false;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child8.position = new Vector2(1f, 1f);
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child8.threshold = 7f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184Child8.timeScale = 1.5f;
			crawlMovementAnimatorState54174blendTreeBlendTree54184.children = new ChildMotion[] {
				crawlMovementAnimatorState54174blendTreeBlendTree54184Child0,
				crawlMovementAnimatorState54174blendTreeBlendTree54184Child1,
				crawlMovementAnimatorState54174blendTreeBlendTree54184Child2,
				crawlMovementAnimatorState54174blendTreeBlendTree54184Child3,
				crawlMovementAnimatorState54174blendTreeBlendTree54184Child4,
				crawlMovementAnimatorState54174blendTreeBlendTree54184Child5,
				crawlMovementAnimatorState54174blendTreeBlendTree54184Child6,
				crawlMovementAnimatorState54174blendTreeBlendTree54184Child7,
				crawlMovementAnimatorState54174blendTreeBlendTree54184Child8
			};
			crawlMovementAnimatorState54174.motion = crawlMovementAnimatorState54174blendTreeBlendTree54184;
			crawlMovementAnimatorState54174.cycleOffset = 0f;
			crawlMovementAnimatorState54174.cycleOffsetParameterActive = false;
			crawlMovementAnimatorState54174.iKOnFeet = true;
			crawlMovementAnimatorState54174.mirror = false;
			crawlMovementAnimatorState54174.mirrorParameterActive = false;
			crawlMovementAnimatorState54174.speed = 1f;
			crawlMovementAnimatorState54174.speedParameterActive = false;
			crawlMovementAnimatorState54174.writeDefaultValues = true;

			var crawlStartAnimatorState53190 = crawlAnimatorStateMachine50112.AddState("Crawl Start", new Vector3(264f, -108f, 0f));
			var crawlStartAnimatorState53190blendTreeBlendTree54192 = new BlendTree();
			AssetDatabase.AddObjectToAsset(crawlStartAnimatorState53190blendTreeBlendTree54192, animatorController);
			crawlStartAnimatorState53190blendTreeBlendTree54192.hideFlags = HideFlags.HideInHierarchy;
			crawlStartAnimatorState53190blendTreeBlendTree54192.blendParameter = "Height";
			crawlStartAnimatorState53190blendTreeBlendTree54192.blendParameterY = "HorizontalMovement";
			crawlStartAnimatorState53190blendTreeBlendTree54192.blendType = BlendTreeType.Simple1D;
			crawlStartAnimatorState53190blendTreeBlendTree54192.maxThreshold = 1f;
			crawlStartAnimatorState53190blendTreeBlendTree54192.minThreshold = 0f;
			crawlStartAnimatorState53190blendTreeBlendTree54192.name = "Blend Tree";
			crawlStartAnimatorState53190blendTreeBlendTree54192.useAutomaticThresholds = false;
			var crawlStartAnimatorState53190blendTreeBlendTree54192Child0 =  new ChildMotion();
			crawlStartAnimatorState53190blendTreeBlendTree54192Child0.motion = crawlStartAnimationClip52942;
			crawlStartAnimatorState53190blendTreeBlendTree54192Child0.cycleOffset = 0f;
			crawlStartAnimatorState53190blendTreeBlendTree54192Child0.directBlendParameter = "HorizontalMovement";
			crawlStartAnimatorState53190blendTreeBlendTree54192Child0.mirror = false;
			crawlStartAnimatorState53190blendTreeBlendTree54192Child0.position = new Vector2(0f, 0f);
			crawlStartAnimatorState53190blendTreeBlendTree54192Child0.threshold = 0f;
			crawlStartAnimatorState53190blendTreeBlendTree54192Child0.timeScale = 1f;
			var crawlStartAnimatorState53190blendTreeBlendTree54192Child1 =  new ChildMotion();
			crawlStartAnimatorState53190blendTreeBlendTree54192Child1.motion = crawlCrouchStartAnimationClip52944;
			crawlStartAnimatorState53190blendTreeBlendTree54192Child1.cycleOffset = 0f;
			crawlStartAnimatorState53190blendTreeBlendTree54192Child1.directBlendParameter = "HorizontalMovement";
			crawlStartAnimatorState53190blendTreeBlendTree54192Child1.mirror = false;
			crawlStartAnimatorState53190blendTreeBlendTree54192Child1.position = new Vector2(0f, 0f);
			crawlStartAnimatorState53190blendTreeBlendTree54192Child1.threshold = 1f;
			crawlStartAnimatorState53190blendTreeBlendTree54192Child1.timeScale = 1f;
			crawlStartAnimatorState53190blendTreeBlendTree54192.children = new ChildMotion[] {
				crawlStartAnimatorState53190blendTreeBlendTree54192Child0,
				crawlStartAnimatorState53190blendTreeBlendTree54192Child1
			};
			crawlStartAnimatorState53190.motion = crawlStartAnimatorState53190blendTreeBlendTree54192;
			crawlStartAnimatorState53190.cycleOffset = 0f;
			crawlStartAnimatorState53190.cycleOffsetParameterActive = false;
			crawlStartAnimatorState53190.iKOnFeet = true;
			crawlStartAnimatorState53190.mirror = false;
			crawlStartAnimatorState53190.mirrorParameterActive = false;
			crawlStartAnimatorState53190.speed = 1.5f;
			crawlStartAnimatorState53190.speedParameterActive = false;
			crawlStartAnimatorState53190.writeDefaultValues = true;

			var crawlStopAnimatorState54176 = crawlAnimatorStateMachine50112.AddState("Crawl Stop", new Vector3(624f, 168f, 0f));
			var crawlStopAnimatorState54176blendTreeBlendTree54198 = new BlendTree();
			AssetDatabase.AddObjectToAsset(crawlStopAnimatorState54176blendTreeBlendTree54198, animatorController);
			crawlStopAnimatorState54176blendTreeBlendTree54198.hideFlags = HideFlags.HideInHierarchy;
			crawlStopAnimatorState54176blendTreeBlendTree54198.blendParameter = "Height";
			crawlStopAnimatorState54176blendTreeBlendTree54198.blendParameterY = "HorizontalMovement";
			crawlStopAnimatorState54176blendTreeBlendTree54198.blendType = BlendTreeType.Simple1D;
			crawlStopAnimatorState54176blendTreeBlendTree54198.maxThreshold = 1f;
			crawlStopAnimatorState54176blendTreeBlendTree54198.minThreshold = 0f;
			crawlStopAnimatorState54176blendTreeBlendTree54198.name = "Blend Tree";
			crawlStopAnimatorState54176blendTreeBlendTree54198.useAutomaticThresholds = false;
			var crawlStopAnimatorState54176blendTreeBlendTree54198Child0 =  new ChildMotion();
			crawlStopAnimatorState54176blendTreeBlendTree54198Child0.motion = crawlStopAnimationClip52952;
			crawlStopAnimatorState54176blendTreeBlendTree54198Child0.cycleOffset = 0f;
			crawlStopAnimatorState54176blendTreeBlendTree54198Child0.directBlendParameter = "HorizontalMovement";
			crawlStopAnimatorState54176blendTreeBlendTree54198Child0.mirror = false;
			crawlStopAnimatorState54176blendTreeBlendTree54198Child0.position = new Vector2(0f, 0f);
			crawlStopAnimatorState54176blendTreeBlendTree54198Child0.threshold = 0f;
			crawlStopAnimatorState54176blendTreeBlendTree54198Child0.timeScale = 1f;
			var crawlStopAnimatorState54176blendTreeBlendTree54198Child1 =  new ChildMotion();
			crawlStopAnimatorState54176blendTreeBlendTree54198Child1.motion = crawlCrouchStopAnimationClip52954;
			crawlStopAnimatorState54176blendTreeBlendTree54198Child1.cycleOffset = 0f;
			crawlStopAnimatorState54176blendTreeBlendTree54198Child1.directBlendParameter = "HorizontalMovement";
			crawlStopAnimatorState54176blendTreeBlendTree54198Child1.mirror = false;
			crawlStopAnimatorState54176blendTreeBlendTree54198Child1.position = new Vector2(0f, 0f);
			crawlStopAnimatorState54176blendTreeBlendTree54198Child1.threshold = 1f;
			crawlStopAnimatorState54176blendTreeBlendTree54198Child1.timeScale = 1f;
			crawlStopAnimatorState54176blendTreeBlendTree54198.children = new ChildMotion[] {
				crawlStopAnimatorState54176blendTreeBlendTree54198Child0,
				crawlStopAnimatorState54176blendTreeBlendTree54198Child1
			};
			crawlStopAnimatorState54176.motion = crawlStopAnimatorState54176blendTreeBlendTree54198;
			crawlStopAnimatorState54176.cycleOffset = 0f;
			crawlStopAnimatorState54176.cycleOffsetParameterActive = false;
			crawlStopAnimatorState54176.iKOnFeet = true;
			crawlStopAnimatorState54176.mirror = false;
			crawlStopAnimatorState54176.mirrorParameterActive = false;
			crawlStopAnimatorState54176.speed = 1.5f;
			crawlStopAnimatorState54176.speedParameterActive = false;
			crawlStopAnimatorState54176.writeDefaultValues = true;

			var crawlIdleAnimatorState54178 = crawlAnimatorStateMachine50112.AddState("Crawl Idle", new Vector3(264f, 36f, 0f));
			var crawlIdleAnimatorState54178blendTreeBlendTree54204 = new BlendTree();
			AssetDatabase.AddObjectToAsset(crawlIdleAnimatorState54178blendTreeBlendTree54204, animatorController);
			crawlIdleAnimatorState54178blendTreeBlendTree54204.hideFlags = HideFlags.HideInHierarchy;
			crawlIdleAnimatorState54178blendTreeBlendTree54204.blendParameter = "Yaw";
			crawlIdleAnimatorState54178blendTreeBlendTree54204.blendParameterY = "ForwardMovement";
			crawlIdleAnimatorState54178blendTreeBlendTree54204.blendType = BlendTreeType.Simple1D;
			crawlIdleAnimatorState54178blendTreeBlendTree54204.maxThreshold = 12f;
			crawlIdleAnimatorState54178blendTreeBlendTree54204.minThreshold = -12f;
			crawlIdleAnimatorState54178blendTreeBlendTree54204.name = "Blend Tree";
			crawlIdleAnimatorState54178blendTreeBlendTree54204.useAutomaticThresholds = false;
			var crawlIdleAnimatorState54178blendTreeBlendTree54204Child0 =  new ChildMotion();
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child0.motion = crawlIdleTurnAnimationClip52962;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child0.cycleOffset = 0f;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child0.directBlendParameter = "HorizontalMovement";
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child0.mirror = false;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child0.position = new Vector2(-1f, 0f);
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child0.threshold = -12f;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child0.timeScale = 2f;
			var crawlIdleAnimatorState54178blendTreeBlendTree54204Child1 =  new ChildMotion();
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child1.motion = crawlIdleTurnAnimationClip52962;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child1.cycleOffset = 0f;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child1.directBlendParameter = "HorizontalMovement";
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child1.mirror = false;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child1.position = new Vector2(-0.96f, 0.26f);
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child1.threshold = -6f;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child1.timeScale = 1f;
			var crawlIdleAnimatorState54178blendTreeBlendTree54204Child2 =  new ChildMotion();
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child2.motion = crawlIdleAnimationClip52926;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child2.cycleOffset = 0f;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child2.directBlendParameter = "HorizontalMovement";
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child2.mirror = false;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child2.position = new Vector2(-0.87f, 0.5f);
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child2.threshold = 0f;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child2.timeScale = 1f;
			var crawlIdleAnimatorState54178blendTreeBlendTree54204Child3 =  new ChildMotion();
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child3.motion = crawlIdleTurnAnimationClip52962;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child3.cycleOffset = 0f;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child3.directBlendParameter = "HorizontalMovement";
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child3.mirror = false;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child3.position = new Vector2(-0.71f, 0.71f);
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child3.threshold = 6f;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child3.timeScale = -1f;
			var crawlIdleAnimatorState54178blendTreeBlendTree54204Child4 =  new ChildMotion();
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child4.motion = crawlIdleTurnAnimationClip52962;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child4.cycleOffset = 0f;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child4.directBlendParameter = "HorizontalMovement";
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child4.mirror = false;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child4.position = new Vector2(-0.5f, 0.87f);
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child4.threshold = 12f;
			crawlIdleAnimatorState54178blendTreeBlendTree54204Child4.timeScale = -2f;
			crawlIdleAnimatorState54178blendTreeBlendTree54204.children = new ChildMotion[] {
				crawlIdleAnimatorState54178blendTreeBlendTree54204Child0,
				crawlIdleAnimatorState54178blendTreeBlendTree54204Child1,
				crawlIdleAnimatorState54178blendTreeBlendTree54204Child2,
				crawlIdleAnimatorState54178blendTreeBlendTree54204Child3,
				crawlIdleAnimatorState54178blendTreeBlendTree54204Child4
			};
			crawlIdleAnimatorState54178.motion = crawlIdleAnimatorState54178blendTreeBlendTree54204;
			crawlIdleAnimatorState54178.cycleOffset = 0f;
			crawlIdleAnimatorState54178.cycleOffsetParameterActive = false;
			crawlIdleAnimatorState54178.iKOnFeet = true;
			crawlIdleAnimatorState54178.mirror = false;
			crawlIdleAnimatorState54178.mirrorParameterActive = false;
			crawlIdleAnimatorState54178.speed = 1f;
			crawlIdleAnimatorState54178.speedParameterActive = false;
			crawlIdleAnimatorState54178.writeDefaultValues = true;

			// State Machine Defaults.
			crawlAnimatorStateMachine50112.anyStatePosition = new Vector3(48f, 48f, 0f);
			crawlAnimatorStateMachine50112.defaultState = crawlIdleAnimatorState54178;
			crawlAnimatorStateMachine50112.entryPosition = new Vector3(72f, -36f, 0f);
			crawlAnimatorStateMachine50112.exitPosition = new Vector3(876f, 48f, 0f);
			crawlAnimatorStateMachine50112.parentStateMachinePosition = new Vector3(852f, -48f, 0f);

			// State Transitions.
			var animatorStateTransition54180 = crawlMovementAnimatorState54174.AddTransition(crawlStopAnimatorState54176);
			animatorStateTransition54180.canTransitionToSelf = true;
			animatorStateTransition54180.duration = 0.15f;
			animatorStateTransition54180.exitTime = 0.92f;
			animatorStateTransition54180.hasExitTime = false;
			animatorStateTransition54180.hasFixedDuration = true;
			animatorStateTransition54180.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition54180.offset = 0f;
			animatorStateTransition54180.orderedInterruption = true;
			animatorStateTransition54180.isExit = false;
			animatorStateTransition54180.mute = false;
			animatorStateTransition54180.solo = false;
			animatorStateTransition54180.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition54182 = crawlMovementAnimatorState54174.AddTransition(crawlIdleAnimatorState54178);
			animatorStateTransition54182.canTransitionToSelf = true;
			animatorStateTransition54182.duration = 0.2f;
			animatorStateTransition54182.exitTime = 0.8849694f;
			animatorStateTransition54182.hasExitTime = false;
			animatorStateTransition54182.hasFixedDuration = true;
			animatorStateTransition54182.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition54182.offset = 0f;
			animatorStateTransition54182.orderedInterruption = true;
			animatorStateTransition54182.isExit = false;
			animatorStateTransition54182.mute = false;
			animatorStateTransition54182.solo = false;
			animatorStateTransition54182.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var animatorStateTransition54186 = crawlStartAnimatorState53190.AddTransition(crawlMovementAnimatorState54174);
			animatorStateTransition54186.canTransitionToSelf = true;
			animatorStateTransition54186.duration = 0.2f;
			animatorStateTransition54186.exitTime = 0.8f;
			animatorStateTransition54186.hasExitTime = true;
			animatorStateTransition54186.hasFixedDuration = true;
			animatorStateTransition54186.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition54186.offset = 0f;
			animatorStateTransition54186.orderedInterruption = true;
			animatorStateTransition54186.isExit = false;
			animatorStateTransition54186.mute = false;
			animatorStateTransition54186.solo = false;
			animatorStateTransition54186.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			var animatorStateTransition54188 = crawlStartAnimatorState53190.AddTransition(crawlIdleAnimatorState54178);
			animatorStateTransition54188.canTransitionToSelf = true;
			animatorStateTransition54188.duration = 0.2f;
			animatorStateTransition54188.exitTime = 0.8f;
			animatorStateTransition54188.hasExitTime = true;
			animatorStateTransition54188.hasFixedDuration = true;
			animatorStateTransition54188.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition54188.offset = 0f;
			animatorStateTransition54188.orderedInterruption = true;
			animatorStateTransition54188.isExit = false;
			animatorStateTransition54188.mute = false;
			animatorStateTransition54188.solo = false;
			animatorStateTransition54188.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var animatorStateTransition54190 = crawlStartAnimatorState53190.AddTransition(crawlStopAnimatorState54176);
			animatorStateTransition54190.canTransitionToSelf = true;
			animatorStateTransition54190.duration = 0.15f;
			animatorStateTransition54190.exitTime = 0.8f;
			animatorStateTransition54190.hasExitTime = false;
			animatorStateTransition54190.hasFixedDuration = true;
			animatorStateTransition54190.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition54190.offset = 0f;
			animatorStateTransition54190.orderedInterruption = true;
			animatorStateTransition54190.isExit = false;
			animatorStateTransition54190.mute = false;
			animatorStateTransition54190.solo = false;
			animatorStateTransition54190.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var animatorStateTransition54194 = crawlStopAnimatorState54176.AddTransition(crawlStartAnimatorState53190);
			animatorStateTransition54194.canTransitionToSelf = true;
			animatorStateTransition54194.duration = 0.15f;
			animatorStateTransition54194.exitTime = 0.8f;
			animatorStateTransition54194.hasExitTime = false;
			animatorStateTransition54194.hasFixedDuration = true;
			animatorStateTransition54194.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition54194.offset = 0f;
			animatorStateTransition54194.orderedInterruption = true;
			animatorStateTransition54194.isExit = false;
			animatorStateTransition54194.mute = false;
			animatorStateTransition54194.solo = false;
			animatorStateTransition54194.AddCondition(AnimatorConditionMode.Equals, 103f, "AbilityIndex");
			animatorStateTransition54194.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");

			var animatorStateTransition54196 = crawlStopAnimatorState54176.AddExitTransition();
			animatorStateTransition54196.canTransitionToSelf = true;
			animatorStateTransition54196.duration = 0.25f;
			animatorStateTransition54196.exitTime = 0.95f;
			animatorStateTransition54196.hasExitTime = false;
			animatorStateTransition54196.hasFixedDuration = true;
			animatorStateTransition54196.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition54196.offset = 0f;
			animatorStateTransition54196.orderedInterruption = false;
			animatorStateTransition54196.isExit = true;
			animatorStateTransition54196.mute = false;
			animatorStateTransition54196.solo = false;
			animatorStateTransition54196.AddCondition(AnimatorConditionMode.NotEqual, 103f, "AbilityIndex");

			var animatorStateTransition54200 = crawlIdleAnimatorState54178.AddTransition(crawlMovementAnimatorState54174);
			animatorStateTransition54200.canTransitionToSelf = true;
			animatorStateTransition54200.duration = 0.2f;
			animatorStateTransition54200.exitTime = 0.8231132f;
			animatorStateTransition54200.hasExitTime = false;
			animatorStateTransition54200.hasFixedDuration = true;
			animatorStateTransition54200.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition54200.offset = 0f;
			animatorStateTransition54200.orderedInterruption = true;
			animatorStateTransition54200.isExit = false;
			animatorStateTransition54200.mute = false;
			animatorStateTransition54200.solo = false;
			animatorStateTransition54200.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			var animatorStateTransition54202 = crawlIdleAnimatorState54178.AddTransition(crawlStopAnimatorState54176);
			animatorStateTransition54202.canTransitionToSelf = true;
			animatorStateTransition54202.duration = 0.15f;
			animatorStateTransition54202.exitTime = 0.8231132f;
			animatorStateTransition54202.hasExitTime = false;
			animatorStateTransition54202.hasFixedDuration = true;
			animatorStateTransition54202.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition54202.offset = 0f;
			animatorStateTransition54202.orderedInterruption = true;
			animatorStateTransition54202.isExit = false;
			animatorStateTransition54202.mute = false;
			animatorStateTransition54202.solo = false;
			animatorStateTransition54202.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");


			// State Machine Transitions.
			var animatorStateTransition50302 = baseStateMachine1660313344.AddAnyStateTransition(crawlStartAnimatorState53190);
			animatorStateTransition50302.canTransitionToSelf = false;
			animatorStateTransition50302.duration = 0.15f;
			animatorStateTransition50302.exitTime = 0.75f;
			animatorStateTransition50302.hasExitTime = false;
			animatorStateTransition50302.hasFixedDuration = true;
			animatorStateTransition50302.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition50302.offset = 0f;
			animatorStateTransition50302.orderedInterruption = true;
			animatorStateTransition50302.isExit = false;
			animatorStateTransition50302.mute = false;
			animatorStateTransition50302.solo = false;
			animatorStateTransition50302.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition50302.AddCondition(AnimatorConditionMode.Equals, 103f, "AbilityIndex");
		}
	}
}
