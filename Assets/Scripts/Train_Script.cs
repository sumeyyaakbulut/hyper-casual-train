using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Train_Script : MonoBehaviour
{

    [SerializeField] private float speedt = 25f;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       // transform.Translate(speedt * Time.deltaTime, 0, 0);
        transform.Translate(Vector3.back * speedt * Time.deltaTime);
        
    }
}
