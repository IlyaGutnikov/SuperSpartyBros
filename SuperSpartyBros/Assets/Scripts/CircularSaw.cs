using UnityEngine;
using System.Collections;

public class CircularSaw : MonoBehaviour {

	public int damageAmount = 10;

	void OnTriggerEnter2D(Collider2D collision)
	{
		if ((collision.tag == "Player") )
		{
			CharacterController2D player = collision.gameObject.GetComponent<CharacterController2D>();
			if (player.playerCanMove) {

				// apply damage to the player
				player.ApplyDamage (damageAmount);

			}
		}
	}
}
