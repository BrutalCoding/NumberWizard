using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
    public Text NumberGuess;
    public Text NumberOfStepsText;
    public static NumberWizard Instance;
    public int AmountOfStepsTaken;

    int guessNumber;
    int minNumber = 1;
    int maxNumber = 1000;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        if (SceneManager.GetActiveScene().name == "Result")
        {
            NumberOfStepsText.text = Instance.AmountOfStepsTaken.ToString();
        }
        else if (SceneManager.GetActiveScene().name == "Main")
        {
            Instance = null;
        }
    }

    // Use this for initialization
    void Start () {
        //Display number to screen
        guessNumber = 500;
        NumberGuess.text = guessNumber.ToString();
        
    }

    public void btnLowerPressed()
    {
        //Lower than the guessed number (e.g. between 1 - 500)
        maxNumber = guessNumber;

        //Half the guess (e.g. 250)
        guessNumber = (minNumber + maxNumber) / 2;

        //Display number to screen
        NumberGuess.text = guessNumber.ToString();

        //Add +1 to steps
        AmountOfStepsTaken++;
    }

    public void btnHigherPressed()
    {
        //Higher than the guessed number (e.g. between 500 - 1000)
        minNumber = guessNumber;
        
        //Half the guess (e.g. 750)
        guessNumber = (minNumber + maxNumber) / 2;

        //Display number to screen
        NumberGuess.text = guessNumber.ToString();

        //Add +1 to steps
        AmountOfStepsTaken++;
    }
}
