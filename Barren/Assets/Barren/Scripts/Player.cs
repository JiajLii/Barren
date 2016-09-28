using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour,IPlayer
{
	private float m_hp = 100;
	private float m_satisfy = 100;

	float hor;
	float ver;
	float speed = 3f;

	/// <summary>
	/// 人物血量
	/// </summary>
	/// <value>The hp.</value>
	public float hp { get { return m_hp; } set { m_hp = value; } }

	/// <summary>
	/// 饱腹程度
	/// </summary>
	/// <value>The satisfy.</value>
	public  float satisfy{ get { return m_satisfy; } set { m_satisfy = value; } }

	/// <summary>
	/// 攻击方法（返回你当前武器的攻击力）
	/// </summary>
	public  float Attack ()
	{
		return 20;
	}

	/// <summary>
	/// 收到伤害（掉血）的方法
	/// </summary>
	public  void UnderAttack (float damage)
	{
		m_hp -= damage;
	}

	/// <summary>
	/// 行走的方法
	/// </summary>
	public  void Move ()
	{
		if (hor != 0 || ver != 0) {
			hor = Input.GetAxis ("Horizontal");
			ver = Input.GetAxis ("Vertical");
			transform.position += new Vector3 (hor, 0, ver) * Time.deltaTime * speed;
		}

		
	}
	
}
