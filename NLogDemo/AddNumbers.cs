using System;
using System.Collections.Generic;
using System.Text;

namespace NLogDemo
{
    public class AddNumbers
    {
        private readonly NLog nLog = new NLog();

        /// <summary>
        /// Addition of two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>Sum of two numbers</returns>
        public int Add(int firstNumber, int secondNumber)
        {
            /// Validation to check whether the number is greater than zero
            if(firstNumber == 0 || secondNumber == 0)
            {
                /// just to mark a flag that this operation was unsuccessful
                nLog.LogDebug("Debug Unsuccessful: Add()");
                /// Just to make a note that whatever values entered by should be greater than zero
                nLog.LogError("values entered by user was not greater than 0. ");
                /// just make a note as a warning for values should not zero
                nLog.LogWarn("First number or second number should not be zero.");
            }
            /// addition of two numbers which is being passed as a arguments
            int sum = firstNumber + secondNumber;
            nLog.LogDebug("Debug successful: Add()");
            /// just to mark a flag that this operation was Successful
            nLog.LogInfo("Add() passed: "+sum);
            return sum;
        }
    }
}
