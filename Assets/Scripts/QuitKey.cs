using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

// Quits the player when the user hits escape

public class QuitKey : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
