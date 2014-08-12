using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {

	public GameObject PlayerExplode;
	public GameObject Ufo1;
	public GameObject Ufo2;
	public GameObject Ufo3;
	public GameObject Ufo1Explode;
	public GameObject Ufo2Explode;
	public GameObject Ufo3Explode;

	// Use this for initialization
	void Start () {
		Instantiate(PlayerExplode, new Vector3(0.5f, -1f), Quaternion.identity);
		Instantiate(Ufo1, new Vector3(-1.0f, 1.65f), Quaternion.identity);
		Instantiate(Ufo2, new Vector3(0f, 1.65f), Quaternion.identity);
		Instantiate(Ufo3, new Vector3(1.0f, 1.65f), Quaternion.identity);	
		Instantiate(Ufo1Explode, new Vector3(-1.0f, 0.65f), Quaternion.identity);
		Instantiate(Ufo2Explode, new Vector3(0f, 0.65f), Quaternion.identity);
		Instantiate(Ufo3Explode, new Vector3(1.0f, 0.65f), Quaternion.identity);	

		Instantiate(Ufo1, new Vector3(-2.0f, 1.65f), Quaternion.identity);
		Instantiate(Ufo1, new Vector3(-2.0f, 0.65f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
