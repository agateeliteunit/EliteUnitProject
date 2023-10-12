using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldInventoryController : MonoBehaviour
{
    [SerializeField] public int _initialAmmo;
    [SerializeField] public int _initialHealth;
    [SerializeField] public int _initialGrenades;

	public int _currentAmmo;
	public int _currentHealth;
	public int _currentGrenades;	

	void Start() {
		
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
