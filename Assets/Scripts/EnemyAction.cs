using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyAction : MonoBehaviour {

	private bool check = false;
	public GameObject live;
	public int counter = 0;
	public GameObject enm;

	void OnCollisionEnter(Collision enemy)
	{

		if (enemy.gameObject.tag == "Player")
		{
			if (enemy.GetType() == typeof(SphereCollider))
            {
				enm = GameObject.FindWithTag("Enemy");
				enm.transform.gameObject.SetActive(false);
			}
			else if (counter == 0)
			{
				live = GameObject.FindWithTag("Life2");
				live.transform.gameObject.SetActive(false);
			}
			else if (counter == 1)
			{
				live = GameObject.FindWithTag("Life1");
				live.transform.gameObject.SetActive(false);
			}
			else if (counter == 2)
			{
				live = GameObject.FindWithTag("Life3");
				live.transform.gameObject.SetActive(false);
			}

			counter++;
			check = true;
			enemy.transform.position = new Vector3(0f, 1.5f, 0.38f);
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
