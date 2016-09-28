using UnityEngine;
using System.Collections;

public interface IItems
{
	/// <summary>
	/// 物品的生命值
	/// </summary>
	/// <value>The hp.</value>
	float hp{ get; set; }

	/// <summary>
	/// 受到攻击
	/// </summary>
	/// <param name="damage">Damage.</param>
	void UnderAttack (float damage);

	/// <summary>
	/// 掉落物品（或者随机出怪物）（比如打木头有可能出蛇）
	/// </summary>
	void FallingItem ();

	void Refresh ();


}
