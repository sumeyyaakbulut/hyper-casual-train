using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Control : MonoBehaviour
{
    public int moneynumber = 0;
    
    public UnityEngine.UI.Text moneynumber_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void Moneyincrease()
    {
        moneynumber += 1;
        moneynumber_text.text = "" + moneynumber;
    }
}
