using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ReTrunScene()
    {
        SceneManager.LoadScene("Start");
    }

    public void Update()
    {
        if (!PlayerStatus.Instance._inGame)
        {
            Invoke("ReTrunScene", 3f);
        }
    }
}
