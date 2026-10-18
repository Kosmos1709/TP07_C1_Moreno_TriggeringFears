using UnityEngine;

public class MoveBackground : MonoBehaviour {

	public float speed;
	private float x;
	public float EndPoint;
	public float StartPoint;


	// Use this for initialization
	void Start () {
		//StartPoint = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {

		x = transform.position.x;
		x += speed * Time.deltaTime;
		transform.position = new Vector3 (x, transform.position.y, transform.position.z);

			if (x <= EndPoint){
			x = StartPoint;
			transform.position = new Vector3 (x, transform.position.y, transform.position.z);
			}
		


	}
}
