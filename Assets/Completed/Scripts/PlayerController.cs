using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float NewTonPara;
	public bool Flag_A = true;
	private Rigidbody2D rg2d;

	void Start()
	{
		rg2d = GetComponent<Rigidbody2D> ();
		rg2d.position = new Vector2 (15, 13);
		Vector2 initCircling = new Vector2 (13, -15);
		rg2d.AddForce (initCircling, ForceMode2D.Impulse);
	}

	void FixedUpdate()
	{
		
		if (Input.GetKey ("a"))
			Flag_A = false;
		if (Flag_A) {
			Vector2 UniversalGravitation = new Vector2 (-1 * rg2d.position.x, -1 * rg2d.position.y);
			rg2d.AddForce (UniversalGravitation);

			if (Input.GetKey ("up")) {
				float perpenX = rg2d.position.y;
				float perpenY = -rg2d.position.x;
				Vector2 perpendicular = new Vector2 (perpenX, perpenY);
			

				rg2d.AddForce (perpendicular * speed);
			}

			if (Input.GetKey ("down")) {
				float perpenX = -rg2d.position.y;
				float perpenY = rg2d.position.x;
				Vector2 perpendicular = new Vector2 (perpenX, perpenY);


				rg2d.AddForce (perpendicular * speed);
			}
		}

	}


}
