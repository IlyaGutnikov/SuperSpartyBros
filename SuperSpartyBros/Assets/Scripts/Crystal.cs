using UnityEngine;
using System.Collections;

public class Crystal : MonoBehaviour {

	public GameObject explosion;

	void OnTriggerEnter2D (Collider2D other)
	{
		if ((other.tag == "Player" ) && (other.gameObject.GetComponent<CharacterController2D>().playerCanMove))
		{

			// if explosion prefab is provide, then instantiate it
			if (explosion)
			{
				Instantiate(explosion,transform.position,transform.rotation);
			}

			// do the player collect coin thing
			other.gameObject.GetComponent<CharacterController2D>().GetImmortality();

			// destroy the coin
			DestroyObject(this.gameObject);
		}
	}

}
