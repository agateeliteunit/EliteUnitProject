using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.UltimateCharacterController.Inventory;
using Opsive.UltimateCharacterController.Items.Actions;


public class WorldInventoryController : MonoBehaviour
{
	[Tooltip("The character that contains the inventory.")]
	[SerializeField] protected GameObject m_Character;
	[SerializeField] public int _initialAmmo;
    [SerializeField] public int _initialHealth;
    [SerializeField] public int _initialGrenades;

	public int _currentAmmo;
	public int _currentHealth;
	public int _currentGrenades;	
	
	
	void Update() {
		
		var inventory = m_Character.GetComponent<InventoryBase>();
		if (inventory == null) {
			return;
		}
		for (int i = 0; i < inventory.SlotCount; ++i) {
			var item = inventory.GetActiveItem(i);
			if (item != null) {
				Debug.Log("Inventory Amount: " + inventory.GetItemIdentifierAmount(item.ItemIdentifier));
				// A single item can have multiple Item Actions.
				var itemActions = item.ItemActions;
				for (int j = 0; j < itemActions.Length; ++j) {
					var usableItem = itemActions[j] as IUsableItem;
					if (usableItem != null) {
						var consumableItemIdentifier = usableItem.GetConsumableItemIdentifier();
						if (consumableItemIdentifier != null) {
							// The loaded amount is retrived from the UsableItem and hte unloaded amount is retrieved from the inventory.
							Debug.Log("Consuambe Loaded Amount: " + usableItem.GetConsumableItemIdentifierAmount());
							Debug.Log("Consuambe Inventory Amount: " + inventory.GetItemIdentifierAmount(consumableItemIdentifier));
						}
					}
				}
			}
		}
		
		_currentAmmo = _initialAmmo;
		_currentHealth = _initialHealth;
		_currentGrenades = _initialGrenades;
		
	}

	public void IncreaseAmmo(int ammo) {
        _currentAmmo += ammo;
    }
	
	public void IncreaseHealth(int health) {
        _currentHealth += health;
    }

	public void IncreaseGrenades(int grenades) {
        _currentGrenades += grenades;
    }

	public void DecreaseAmmo(int ammo) {
        _currentAmmo -= ammo;
    }

	public void DecreaseHealth(int health) {
        _currentHealth -= health;
    }

	public void DecreaseGrenades(int grenades) {
        _currentGrenades -= grenades;
    }


}
