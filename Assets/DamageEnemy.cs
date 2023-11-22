using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EmeraldAI.Utility;
using Opsive.UltimateCharacterController.Traits;

public class DamageEnemy : MonoBehaviour
{

    [Tooltip("The character that has the health component.")]
    [SerializeField] protected GameObject m_Character;

    // Start is called before the first frame update
    void SendDamage()
    {
        var health = m_Character.GetComponent<Health>();
        // Cause 10 damage to the character.
        health.Damage(30);
    }
}
