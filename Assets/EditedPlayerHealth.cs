using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.UltimateCharacterController.Traits;


public class EditedPlayerHealth : MonoBehaviour
{
    [SerializeField] protected GameObject m_Character;

    // Start is called before the first frame update
    public void TakeDamage(Vector3 location, Vector3 direction, float damage, Collider bodyPart = null, GameObject origin = null)
    {
        var health = m_Character.GetComponent<Health>();
        // Cause 10 damage to the character.
        health.Damage(10);
    }
}
