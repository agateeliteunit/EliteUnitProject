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

	private int _currentRifleAmmo;
	private int _currentPistolAmmo;
	private int _currentGrenadeAmmo;
	private int _currentShotgunAmmo;

	public int currentRifleAmmo { get { return _currentRifleAmmo; } }
	public int currentPistolAmmo { get { return _currentPistolAmmo; } }
	public int currentGrenadeAmmo { get { return _currentGrenadeAmmo; } }
	public int currentShotgunAmmo { get { return _currentShotgunAmmo; } }

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
	}
}
