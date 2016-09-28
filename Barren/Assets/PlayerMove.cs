using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
	IPlayer player;

	void Start ()
	{
		player = GetComponent<IPlayer> ();

	}

	void Update ()
	{
		player.Move ();
	}
}
