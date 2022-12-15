using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Character : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float speedGainPerSecond = 0.02f;//smoot speed
    [SerializeField] private float turnSpeed=1f;//200

    public GameObject train;

    private int steerValue;
    public Game_Control gamecontrol;
    public GameObject finish_movement;
    public GameObject panel_direction;
    public GameObject panel_advertisement;

    public UnityEngine.UI.Text statio_text;
    
    public AudioClip crashsound;
    public AudioClip goldsound;

    private bool x;

    // Update is called once per frame
    void Update()
    {
        speed += speedGainPerSecond * Time.deltaTime;

        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
       
        switch (other.gameObject.tag)
        {
            case "Obstacle":
                GetComponent<AudioSource>().PlayOneShot(crashsound);
                StartCoroutine("WaitForSceneLoad");
               

                break;
            case "money":
                GetComponent<AudioSource>().PlayOneShot(goldsound);
                gamecontrol.Moneyincrease();
                Destroy(other.gameObject);
                break;

            case "stationame":
                speed = 0f;
                statio_text.text=other.gameObject.name;
                transform.Translate(Vector3.forward * speed * 0);
                
                panel_advertisement.SetActive(true);
                train.transform.Translate(Vector3.back * speed * 0);


                //stname.WriteStation();
                //Debug.Log(other.gameObject.name);
                break;

            case "finish":
                speed = 0f;
                Debug.Log("finish");
                panel_direction.SetActive(true);
                transform.Translate(Vector3.forward * speed * 0);
                break;
            case "F2":
                //finish_movement.SetActive(true);
                break;
           


            default:
                break;
                 
        }

    }
  

    private IEnumerator WaitForSceneLoad()

    {

        yield return new WaitForSeconds(0.8f);
        

        SceneManager.LoadScene(1);
        Destroy(gameObject);
    }
    
    public void Steer(int value)
    {
        steerValue = value; 
    }
    
   
}
