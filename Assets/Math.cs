using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour {
	public int valueOne;

	public int valueTwo; 

	public int valueThree;

	public int valueFour;

	private int result;

	private int resultOne;

	// Use this for initialization
	void Start (){
		DoMath();
	}
	
	void DoMath (){
		result = valueOne + valueTwo;
		print(valueOne + " + " + valueTwo + " = " + result);

		result = valueOne - valueTwo;
		print(valueOne + " - " + valueTwo + " = " + result);

		result = valueOne * valueTwo;
		print(valueOne + " x " + valueTwo + " = " + result);

		result = valueOne / valueTwo;
		print(valueOne + " / " + valueTwo + " = " + result);

		resultOne = valueThree + valueFour;
		print(valueThree + " + " + valueFour + " = " + resultOne);

		resultOne = valueThree - valueFour;
		print(valueThree + " - " + valueFour + " = " + resultOne);

		resultOne = valueThree * valueFour;
		print(valueThree + " x " + valueFour + " = " + resultOne);

		resultOne = valueThree / valueFour;
		print(valueThree + " / " + valueFour + " = " + resultOne);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
