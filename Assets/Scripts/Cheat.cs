using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

// Teleport to Chest

public class Cheat : MonoBehaviour
{
    public GameObject obj;

    void Update()
    {
        if (Input.GetKey("t"))
        {
            obj = GameObject.FindWithTag("Player");
            obj.transform.position = new Vector3(120f, 1.5f, 0.38f);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
