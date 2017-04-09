using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScript : MonoBehaviour {
    public Text NumberOfStepsText;
    public NumberWizard NW;

	// Use this for initialization
	void Start () {
        NumberOfStepsText.text = NW.AmountOfStepsTaken.ToString();
    }
}
