﻿// -------------------------------------------------------------------------------
// THIS FILE IS ORIGINALLY GENERATED BY THE DESIGNER.
// YOU ARE ONLY ALLOWED TO MODIFY CODE BETWEEN '///<<< BEGIN' AND '///<<< END'.
// PLEASE MODIFY AND REGENERETE IT IN THE DESIGNER FOR CLASS/MEMBERS/METHODS, ETC.
// -------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

///<<< BEGIN WRITING YOUR CODE FILE_INIT

///<<< END WRITING YOUR CODE

public class FirstAgent : behaviac.Agent
///<<< BEGIN WRITING YOUR CODE FirstAgent
///<<< END WRITING YOUR CODE
{
	private FirstStruct p1 = new FirstStruct();
	public void _set_p1(FirstStruct value)
	{
		p1 = value;
	}
	public FirstStruct _get_p1()
	{
		return p1;
	}

	public int GetP1s1()
	{
///<<< BEGIN WRITING YOUR CODE GetP1s1
		return p1.s1;
///<<< END WRITING YOUR CODE
	}

	public void SayHello()
	{
///<<< BEGIN WRITING YOUR CODE SayHello
        Console.WriteLine();
        Console.WriteLine("Hello Behaviac!");
        Console.WriteLine();
///<<< END WRITING YOUR CODE
	}

///<<< BEGIN WRITING YOUR CODE CLASS_PART

///<<< END WRITING YOUR CODE

}

///<<< BEGIN WRITING YOUR CODE FILE_UNINIT

///<<< END WRITING YOUR CODE
