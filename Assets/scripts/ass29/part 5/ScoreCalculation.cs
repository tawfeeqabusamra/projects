using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculation : MonoBehaviour
{


    void Start()
    {
        int playerScore = 100;
        int diviser = 0;
        try
        {
            Debug.Log("Attempting to calculate score multiplier...");
            int totalScore = playerScore / diviser;


        }
        catch (DivideByZeroException)
        {
            Debug.Log("Error: Division by zero occurred while calculating score multiplier.");

        }
        finally
        {
            Debug.Log("Score calculation complete. Cleaning up resources.");
        }

    }


}
