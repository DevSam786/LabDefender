using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arena : MonoBehaviour
{
    public GameObject invisibleTrigger;//to trigger blockers
    public bool isEnemyClear; //to check all enemy is clear;
    public bool invisibleTriggered;//To Check is Trigger is triggered or not
    public bool wallColliderIsOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isEnemyClear == true && invisibleTriggered == true)
        {
            invisibleTrigger.SetActive(false);
        }else if(isEnemyClear == true && wallColliderIsOn == true)
        {

        }
    }
}
