using UnityEngine;
using System.Collections;

public interface Player
{
	/// <summary>
	/// 返回你当前武器的攻击力
	/// </summary>
	void Attack ();

	/// <summary>
	/// 收到伤害的方法
	/// </summary>
	void UnderAttack (float damage);
	
}
