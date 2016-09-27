using UnityEngine;
using System.Collections;

public interface AnimalAI
{
	/// <summary>
	/// 巡逻的方法
	/// </summary>
	void Patrol ();

	/// <summary>
	/// 追击的方法
	/// </summary>
	void Pursue ();

	/// <summary>
	/// 攻击策略的选择
	/// </summary>
	void Attack ();

	/// <summary>
	/// 死亡方法
	/// </summary>
	void Dead ();

	/// <summary>
	/// 物品掉落方法
	/// </summary>
	void FallingItems ();
}
