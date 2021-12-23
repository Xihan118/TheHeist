using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleDamageReceiver : MonoBehaviour, IDamagable {

	public HealthHelper vehicleDamage;
	public bool isHead;

	public void ApplyDamage(int damage)
    {
		if (isHead)
		{
			damage = damage * 5;
		}
		int damageFromWeapon = (int)(damage);
		vehicleDamage.ApplyDamage(damageFromWeapon);
    }
	
	public void ApplyExplosionDamage (int damage)
	{
		vehicleDamage.ApplyDamage(damage);
	}
}
