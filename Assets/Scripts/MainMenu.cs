using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject panel_advertis;
    public GameObject character;

    public GameObject train;
    private float speedt = 25f;

    private float speed = 3f;
    private float speedGainPerSecond = 0.02f;

    public void Play()
    {
        SceneManager.LoadScene(2);
    }
    public void F2()
    {
        SceneManager.LoadScene(6);
    }
    public void T1()
    {
        SceneManager.LoadScene(5);  
    }
    public void Advertisement()
    {
        panel_advertis.SetActive(false);
        speed += speedGainPerSecond * Time.deltaTime;
        character.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        train.transform.Translate(Vector3.back * speedt * Time.deltaTime);

    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(0);
    }
}
