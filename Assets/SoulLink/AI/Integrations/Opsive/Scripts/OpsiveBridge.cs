// Comment out EMERALD_LBD define you are using a version of Emerald AI that does not have Location Based Damage
#define EMERALD_LBD
// Uncomment LEGACY_OPSIVE if you are using Opsive prior to 2.2
//#define LEGACY_OPSIVE
// Uncomment LEGACY_EMERALD if you are using Emerald AI prior to 2.2
//#define LEGACY_EMERALD

using UnityEngine; 
using EmeraldAI; 
using Opsive.Shared.Events;

namespace Magique
{
#if LEGACY_OPSIVE
    public class OpsiveBridge : MonoBehaviour
    {
        private EmeraldAISystem _emeraldAI;
        private void Awake() 
        { 
            _emeraldAI = GetComponent<EmeraldAISystem>(); 
            EventHandler.RegisterEvent<float, Vector3, Vector3, GameObject, Collider>(gameObject, "OnObjectImpact", OnObjectImpact); 
        
        } // Awake()

        private void OnObjectImpact(float amount, Vector3 point, Vector3 normal, GameObject originator, Collider collider)
        {
            if (_emeraldAI != null)
            {
                _emeraldAI.Damage((int)amount, EmeraldAISystem.TargetType.Player, originator.transform);                
                //Debug.Log(this.name + " took " + amount + " damaged at location " + point + " with normal " + normal + " from object " + originator);            
            }
        } // OnObjectImpact()
    }  // class OpsiveBridge
#else

#if LEGACY_EMERALD
    using Opsive.UltimateCharacterController.Events;

    public class OpsiveBridge : MonoBehaviour
    {
        private Emerald_AI _emeraldAI;

        private void Awake()
        {
            _emeraldAI = GetComponent<Emerald_AI>();
            EventHandler.RegisterEvent<float, Vector3, Vector3, GameObject, Collider>(gameObject, "OnObjectImpact", OnObjectImpact);
        } // Awake()

        private void OnObjectImpact(float amount, Vector3 point, Vector3 normal, GameObject originator, Collider collider)
        {
            if (_emeraldAI != null)
            {
                _emeraldAI.Damage((int)amount, Emerald_AI.TargetType.Player);
                //Debug.Log(this.name + " took " + amount + " damaged at location " + point + " with normal " + normal + " from object " + originator);        
            }
        } // OnObjectImpact()
    } // class OpsiveBridge
#else
    public class OpsiveBridge : MonoBehaviour    
	{        
		private EmeraldAISystem _emeraldAI;
        private Collider[] _colliders;

        private void Awake()        
		{            
			_emeraldAI = GetComponent<EmeraldAISystem>();
            _colliders = GetComponentsInChildren<Collider>();

            foreach (var collider in _colliders)
            {
                EventHandler.RegisterEvent<float, Vector3, Vector3, GameObject, object, Collider>(collider.gameObject, "OnObjectImpact", OnObjectImpact);
            }
		} // Awake()

        /// <summary>    
        /// The object has been impacted with another object.    
        /// </summary>    
        /// <param name="amount">The amount of damage taken.</param>    
        /// <param name="position">The position of the damage.</param>    
        /// <param name="forceDirection">The direction that the object took damage from.</param>    
        /// <param name="attacker">The GameObject that did the damage.</param>    
        /// <param name="attackerObject">The object that did the damage.</param>    
        /// <param name="hitCollider">The Collider that was hit.</param> 
        private void OnObjectImpact(float amount, Vector3 position, Vector3 forceDirection, GameObject attacker, object attackerObject, Collider hitCollider)
        {            
			if (_emeraldAI != null)            
			{
#if EMERALD_LBD
                // !!!Thanks to Mattis for providing this code for location based damage!!!
                if (hitCollider.GetComponent<LocationBasedDamageArea>())
                {
                    hitCollider.GetComponent<LocationBasedDamageArea>().DamageArea((int)amount, EmeraldAISystem.TargetType.Player, attacker.transform);
                }
                else
#endif
                {
                    _emeraldAI.Damage((int)amount, EmeraldAISystem.TargetType.Player, attacker.transform);
                }
				//Debug.Log(name + " impacted by " + attacker + " on collider " + hitCollider + ".");            
			}        
		} // OnObjectImpact()

        /// The GameObject has been destroyed.    
        /// </summary>    
        public void OnDestroy()        
		{
            foreach (var collider in _colliders)
            {
                EventHandler.UnregisterEvent<float, Vector3, Vector3, GameObject, object, Collider>(collider.gameObject, "OnObjectImpact", OnObjectImpact);
            }
        } // OnDestroy()
    } // class OpsiveBridge
#endif
#endif
} // namespace Magique
