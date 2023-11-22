using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EmeraldAI.Utility;
using Opsive.UltimateCharacterController.Traits;

public class DamageRange : MonoBehaviour
{
    public float inaccuracy = 0.0f;
    [Tooltip("The character that has the health component.")]
    [SerializeField] protected GameObject m_Character;

    public void ExecuteEvent()
    {
        var health = m_Character.GetComponent<Health>();
        // Generate a random number between 0 and 1.
        float randomValue = Random.Range(0f, 1f);
        // Set a miss chance value for the enemy.
        float missChance = 0.6f; // Adjust this value to control the miss chance.

        // If the random value is less than the miss chance, the attack misses.
        if (randomValue < missChance)
        {
            Debug.Log("Enemy missed the attack!");
        }
        else
        {
            // Otherwise, cause damage to the character.
            health.Damage(2);
        }
    }
}