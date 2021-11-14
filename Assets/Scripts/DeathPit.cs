using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathPit : MonoBehaviour {

	private bool check = false;
	public GameObject live;
	public static int counter=0;

	void OnCollisionEnter(Collision col1)
	{ 
		if (col1.gameObject.tag == "Player")
			{
				if (counter == 0)
				{
					//counter++;
					live = GameObject.FindWithTag("Life2");
					live.transform.gameObject.SetActive(false);

				}
				else if (counter == 1)
				{
					//counter++;
					live = GameObject.FindWithTag("Life1");
					live.transform.gameObject.SetActive(false);
				}
				else if (counter == 2)
				{
					//counter++;
					live = GameObject.FindWithTag("Life3");
					live.transform.gameObject.SetActive(false);
				}

				counter++;
				//live.transform.gameObject.SetActive(false);
				//live.GetComponent<MeshRenderer>().material = Glass;
				check = true;
				col1.transform.position = new Vector3(0f, 1.5f, 0.38f);
			}
		else
			{
				check = false;
			}
	}
	void Update()
	{
		if (check)
		{
			if (counter > 3)
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
			}
		//UnityEditor.AssetDatabase.SaveAssets();
		}
	}
}
