using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Terserah : MonoBehaviour
{
    public void SampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

public void Quit()
{
    Application.Quit();
}
}
