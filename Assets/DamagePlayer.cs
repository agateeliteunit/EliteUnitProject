using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Opsive.UltimateCharacterController.Traits;


public class DamagePlayer : MonoBehaviour
{
    [SerializeField] protected GameObject m_Character;
    // Start is called before the first frame update
    public void Shoot()
    {
        var health = m_Character.GetComponent<Health>();
        // Cause 10 damage to the character.
        health.Damage(10);
    }
}
