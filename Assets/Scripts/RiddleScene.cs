using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class RiddleScene : MonoBehaviour
{
    public GameObject ScoreTxt;
    public string tTextChk;
    public string tText1;

    void OnCollisionEnter(Collision chkbox)
    {
        ScoreTxt= GameObject.FindWithTag("Score");
        tTextChk = ("This level has 12 keys\nYour Keys:12");
        tText1 = ScoreTxt.GetComponent<TextMesh>().text;
   
        if (tTextChk.Equals(tText1))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
