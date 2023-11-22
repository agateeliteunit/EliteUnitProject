﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EmeraldAI.Example;
using Opsive.UltimateCharacterController.Traits;

namespace EmeraldAI
{
    //This script will automatically be added to player targets. You can customize the DamagePlayerStandard function
    //or create your own. Ensure that it will be called within the SendPlayerDamage function. This allows users to customize
    //how player damage is received and applied without having to modify any main system scripts. The EmeraldComponent can
    //be used for added functionality such as only allowing blocking if the received AI is using the Melee Weapon Type.
    public class EmeraldAIPlayerDamage : MonoBehaviour
    {
        [SerializeField] protected GameObject m_Character;
        public List<string> ActiveEffects = new List<string>();
        public bool IsDead = false;

        public void SendPlayerDamage(int DamageAmount, Transform Target, EmeraldAISystem EmeraldComponent, bool CriticalHit = false)
        {
            //The standard damage function that sends damage to the Emerald AI demo player

            DamageOpsivePlayer(DamageAmount, Target);

            //Creates damage text on the player's position, if enabled.
            

            //Sends damage to another function that will then send the damage to the RFPS player.
            //If you are using RFPS, you can uncomment this to allow Emerald Agents to damage your RFPS player.
            //DamageRFPS(DamageAmount, Target);

            //Sends damage to another function that will then send the damage to the RFPS player.
            //If you are using RFPS, you can uncomment this to allow Emerald Agents to damage your RFPS player.
            //DamageInvectorPlayer(DamageAmount, Target);

            //Damage UFPS Player
            //DamageUFPSPlayer(DamageAmount);
        }

        void DamageOpsivePlayer(int DamageAmount, Transform target)
        {
            var tpcHealth = m_Character.GetComponentInParent<Health>();
            tpcHealth.Damage(30);

            if (tpcHealth)
            {
                tpcHealth.Damage(DamageAmount, target.position, target.forward, 1f, target.gameObject);

                if (tpcHealth.HealthValue <= 0)
                {
                    EmeraldAISystem emeraldAI = target.GetComponent<EmeraldAISystem>(); EmeraldAIEventsManager emeraldAIEvents =
                    target.GetComponent<EmeraldAIEventsManager>(); if (emeraldAIEvents != null && emeraldAI != null &&
                    emeraldAI.CurrentTarget == this.gameObject.transform)
                    {
                        // For Emerald AI prior to v3.0 uncomment the following line
                        //emeraldAI.ClearTarget();

                        // For Emerald AI prior to v3.0 comment out the following line

                        //emeraldAIEvents.ClearTarget();
                    }
                }

            }
        }


        void DamagePlayerStandard(int DamageAmount)
        {
            if (GetComponent<EmeraldAIPlayerHealth>() != null)
            {
                EmeraldAIPlayerHealth PlayerHealth = GetComponent<EmeraldAIPlayerHealth>();
                PlayerHealth.DamagePlayer(DamageAmount);

                if (PlayerHealth.CurrentHealth <= 0)
                {
                    IsDead = true;
                }
            }
        }

        /*
        void DamageRFPS(int DamageAmount, Transform Target)
        {
            if (GetComponent<FPSPlayer>() != null)
            {
                GetComponent<FPSPlayer>().ApplyDamage((float)DamageAmount, Target, true);
            }
        }
        */

        /*
        void DamageInvectorPlayer (int DamageAmount, Transform Target)
        {
            if (GetComponent<Invector.vCharacterController.vCharacter>())
            {
                var PlayerInput = GetComponent<Invector.vCharacterController.vMeleeCombatInput>();

                if (!PlayerInput.blockInput.GetButton())
                {
                    var _Damage = new Invector.vDamage(DamageAmount);
                    _Damage.sender = Target;
                    _Damage.hitPosition = Target.position;
                    GetComponent<Invector.vCharacterController.vCharacter>().TakeDamage(_Damage);
                }
            }
        }
        */

        /*
        void DamageUFPSPlayer(int DamageAmount)
        {
            if (GetComponent<vp_FPPlayerDamageHandler>())
            {
                GetComponent<vp_FPPlayerDamageHandler>().Damage((float)DamageAmount);
            }
        }
        */
    }
}
