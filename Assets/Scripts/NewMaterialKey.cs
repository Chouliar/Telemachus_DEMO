using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMaterialKey: MonoBehaviour {

	public Material[] material;
	public Renderer rend;
	private BoxCollider collider;
	public GameObject obj;
	public string tText;
	public static int keys;

	void Start()
    {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
		//rend.sharedMaterial = material[0];
		
		
	}
	void OnCollisionEnter(Collision col)
	{
		
		obj = GameObject.FindWithTag("Score");
		collider = GetComponent<BoxCollider>();
		if (col.gameObject.tag == "Player")
        {
			rend.sharedMaterial = material[1];
			collider.isTrigger = true;
			keys++;
			tText = ("This level has 12 keys\nYour Keys:" + keys);
			obj.GetComponent<TextMesh>().text = tText;
		}

		
	}

}
