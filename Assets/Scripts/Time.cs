using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour {

    [SerializeField]
    Text yearText;
    [SerializeField]
    Text monthText;
    [SerializeField]
    Text dayText;
    [SerializeField]
    float timeInDay;

    
    private int currentDay = 1;
    private int currentMonth = 1;
    private int currentYear = 1;
   
    // Use this for initialization
   
    private void Start()
    {
       
        StartCoroutine(TimeDay());

        

    }
    // Update is called once per frame
    void Update()
    {

        
    }

    IEnumerator TimeDay()
    {
        yield return new WaitForSecondsRealtime(timeInDay);
              
        dayIncrease();
        StartCoroutine(TimeDay());
        
    }

    void dayIncrease()
    {
        currentDay++;      

        dayText.text = "Day " + currentDay;
        if (currentDay > 30)
        {
            currentDay = 1;
            monthIncrease();
            dayText.text = "Day " + currentDay;
        }
    }

    private void monthIncrease()
    {
        currentMonth++;
        
        monthText.text = "Month " + currentMonth;
        if (currentMonth >12)
        {
            currentMonth = 1;
            yearIncrease();
            monthText.text = "Month " + currentMonth;
        }

    }

    private void yearIncrease()
    {
        currentYear++;
        
        yearText.text = "Year " + currentYear;
        
    }
}
