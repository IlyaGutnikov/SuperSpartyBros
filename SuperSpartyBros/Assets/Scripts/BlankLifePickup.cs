using UnityEngine;
using System.Collections;

public class BlankLifePickup : MonoBehaviour {

	public GameObject explosion;

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			collision.gameObject.GetComponent<CharacterController2D> ().GetBlankHeart ();

			// if explosion prefab is provide, then instantiate it
			if (explosion)
			{
				Instantiate(explosion,transform.position,transform.rotation);
			}

			GameManager.gm.RemoveLife ();

			// destroy the heart
			DestroyObject(this.gameObject);
		}
	}
}
