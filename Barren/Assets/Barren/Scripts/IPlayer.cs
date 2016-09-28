using UnityEngine;
using System.Collections;

public interface IPlayer
{
	/// <summary>
	/// 人物血量
	/// </summary>
	/// <value>The hp.</value>
	float hp{ get; set; }

	/// <summary>
	/// 饱腹程度
	/// </summary>
	/// <value>The satisfy.</value>
	float satisfy{ get; set; }

	/// <summary>
	/// 攻击方法（返回你当前武器的攻击力）
	/// </summary>
	float Attack ();

	/// <summary>
	/// 收到伤害（掉血）的方法
	/// </summary>
	void UnderAttack (float damage);

	/// <summary>
	/// 行走的方法
	/// </summary>
	void Move ();
}
