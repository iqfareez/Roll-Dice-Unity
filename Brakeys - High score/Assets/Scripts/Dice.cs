﻿using UnityEngine;
using TMPro;
//Modified Brakeys code
public class Dice : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    
    public TextMeshProUGUI scoreText1;
    public TextMeshProUGUI scoreText2;
    public TextMeshProUGUI totalText;

    private int number1;
    private int number2;

    public void BrakeysRollDice()
    {
        int number = Random.Range(1, 7);
        scoreText.text = number.ToString();

        // Debug.Log("Called Brakeys code");
    }

    public void RollDiceTwice()
    {
        number1 = Random.Range(1, 7);
        number2 = Random.Range(1, 7);

        scoreText1.text = number1.ToString();
        scoreText2.text = number2.ToString();
        totalText.text = "Total: " + (number1 + number2).ToString(); //total of this two number

    }

    public int getNum1 => number1;
    public int getNum2 => number2;
}
