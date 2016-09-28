using UnityEngine;
using System.Collections;

public interface IAnimal
{
	/// <summary>
	/// 动物的血量
	/// </summary>
	/// <value>The hp.</value>
	float hp{ get; set; }

	/// <summary>
	/// 巡逻的方法
	/// </summary>
	void Patrol ();

	/// <summary>
	/// 动物碰见人之后选择的行为
	/// </summary>
	void Behaviour ();

	/// <summary>
	/// 掉血方法
	/// </summary>
	void UnderAttack (float damage);

	/// <summary>
	/// 死亡方法
	/// </summary>
	void Dead ();

	/// <summary>
	/// 物品掉落方法
	/// </summary>
	void FallingItems ();
}
