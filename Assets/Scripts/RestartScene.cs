using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

// Quits the player when the user hits r

public class RestartScene : MonoBehaviour
{
    public GameObject obj;

    void Update()
    {
        if (Input.GetKey("r"))
        {
            obj = GameObject.FindWithTag("Player");
            obj.transform.position = new Vector3(0f, 1.5f, 0.38f);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
