﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit {

	public Apple(){
		Debug.Log("1st Apple Constructor Called");
	}

	public new void Chop(){
		Debug.Log("The Apple has been chopped");
	}

	public new void SayHello(){
		Debug.Log("Hello, I'm an apple");
	}
}
