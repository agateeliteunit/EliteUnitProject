using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.UltimateCharacterController.Inventory;
using Opsive.UltimateCharacterController.Items;
using Opsive.UltimateCharacterController.Items.Actions;
using Opsive.UltimateCharacterController.Items.Actions.PerspectiveProperties;
using Opsive.Shared.Inventory;


public class WorldInventoryController : MonoBehaviour
{
	[Tooltip("The character that contains the inventory.")]
	[SerializeField] protected GameObject m_Character;

	[SerializeField] protected int m_CategoryIndex;
	[Tooltip("The index of the ItemSet that should be equipped.")]
	[SerializeField] protected int m_ItemSetIndex;

	[SerializeField] public int _initialAmmo;
    [SerializeField] public int _initialHealth;
    [SerializeField] public int _initialGrenades;

	public int _currentAmmo;
	public int _currentHealth;
	public int _currentGrenades;	

	private int _currentRifleAmmo;
	private int _currentPistolAmmo;
	private int _currentGrenadeAmmo;
	private int _currentShotgunAmmo;

	private int _currentRifleAmmoInClip;
	private int _currentPistolAmmoInClip;
	private int _currentGrenadeAmmoInClip;
	private int _currentShotgunAmmoInClip;

	
	
	void Start () {
		var inventory = m_Character.GetComponent<InventoryBase>();
        List<IItemIdentifier> allItems = inventory.GetAllItemIdentifiers();
			for (int i = 0; i < allItems.Count; ++i) {
            	var identifier = allItems[i];
				var item = inventory.GetItem(identifier, 0);
				if (item != null) {
					var itemActions = item.ItemActions;
					for (int j = 0; j < itemActions.Length; ++j) {
						var usableItem = itemActions[j] as IUsableItem;
						if (usableItem != null) {
							var consumableItemIdentifier = usableItem.GetConsumableItemIdentifier();
							Debug.Log(consumableItemIdentifier);
							if (consumableItemIdentifier != null) {
								if (consumableItemIdentifier.ToString() == "AssaultRifleBullet") {
                                    _currentRifleAmmo = inventory.GetItemIdentifierAmount(consumableItemIdentifier);
									_currentRifleAmmoInClip = usableItem.GetConsumableItemIdentifierAmount();
                                }
								if (consumableItemIdentifier.ToString() == "PistolBullet") {
                                    _currentPistolAmmo = inventory.GetItemIdentifierAmount(consumableItemIdentifier);
									_currentPistolAmmoInClip = usableItem.GetConsumableItemIdentifierAmount();
                                }
								if (consumableItemIdentifier.ToString() == "FragGrenade") {
                                    _currentGrenadeAmmo = inventory.GetItemIdentifierAmount(consumableItemIdentifier);
									_currentGrenadeAmmoInClip = usableItem.GetConsumableItemIdentifierAmount();
                                }
                                if (consumableItemIdentifier.ToString() == "ShotgunBullet") {
                                    _currentShotgunAmmo = inventory.GetItemIdentifierAmount(consumableItemIdentifier);
									_currentShotgunAmmoInClip = usableItem.GetConsumableItemIdentifierAmount();
                                }
							}
						}
					}
                }
			}
    }
	
	void Update() {
		
		var inventory = m_Character.GetComponent<InventoryBase>();
		if (inventory == null) {
			return;
		}

		List<IItemIdentifier> allItems = inventory.GetAllItemIdentifiers();
			for (int i = 0; i < allItems.Count; ++i) {
            	var identifier = allItems[i];
				var item = inventory.GetItem(identifier, 0);
				if (item != null) {
					Debug.Log(item);
					var itemActions = item.ItemActions;
					for (int j = 0; j < itemActions.Length; ++j) {
						var usableItem = itemActions[j] as IUsableItem;
						if (usableItem != null) {
							var consumableItemIdentifier = usableItem.GetConsumableItemIdentifier();
							if (consumableItemIdentifier != null) {
								if (consumableItemIdentifier.ToString() == "AssaultRifleBullet") {
                                    _currentRifleAmmo = inventory.GetItemIdentifierAmount(consumableItemIdentifier);
									_currentRifleAmmoInClip = usableItem.GetConsumableItemIdentifierAmount();
                                }
								if (consumableItemIdentifier.ToString() == "PistolBullet") {
                                    _currentPistolAmmo = inventory.GetItemIdentifierAmount(consumableItemIdentifier);
									_currentPistolAmmoInClip = usableItem.GetConsumableItemIdentifierAmount();
                                }
								if (consumableItemIdentifier.ToString() == "FragGrenade") {
                                    _currentGrenadeAmmo = inventory.GetItemIdentifierAmount(consumableItemIdentifier);
									_currentGrenadeAmmoInClip = usableItem.GetConsumableItemIdentifierAmount();
                                }
                                if (consumableItemIdentifier.ToString() == "ShotgunBullet") {
                                    _currentShotgunAmmo = inventory.GetItemIdentifierAmount(consumableItemIdentifier);
									_currentShotgunAmmoInClip = usableItem.GetConsumableItemIdentifierAmount();
                                }
							}
						}
					}
                }
			}
		
		Debug.Log("Rifle ammo: " + _currentRifleAmmo);
		Debug.Log("Rifle ammo (Mag) : " + _currentRifleAmmoInClip);
		Debug.Log("Pistol ammo: " + _currentPistolAmmo);
		Debug.Log("Pistol ammo (Mag) : " + _currentPistolAmmoInClip);
		Debug.Log("Grenade ammo: " + _currentGrenadeAmmo);
		Debug.Log("Grenade ammo (Hand) : " + _currentGrenadeAmmoInClip);
		Debug.Log("Shotgun ammo: " + _currentShotgunAmmo);
		Debug.Log("Shotgun ammo (Mag) : " + _currentShotgunAmmoInClip);
		
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
