using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Train_Right : MonoBehaviour
{
    public GameObject Train;
    public float xPos;
    public float zPos;
    public float min;
    public int trainNumber;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrainDrop());
    }
    IEnumerator TrainDrop()
    {
        while (trainNumber < 20)
        {

            xPos = Random.Range(42.2f, 42.4f);
            zPos = Random.Range(30f, 10000f);
            Instantiate(Train, new Vector3(xPos, 0.2f, zPos), Quaternion.identity);
            min = Random.Range(2f, 4f);
            yield return new WaitForSeconds(min);
            trainNumber += 1;
        }
    }
}
