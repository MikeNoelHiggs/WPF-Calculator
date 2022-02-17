using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace Calculator_UI_WPF
{
    class CalculatorFixture
    {
        public int? result;
        public double? dresult;
        public string display = "0";
        public static DataTable dt = new DataTable();

        /// <summary> Adds two values together. </summary>
        /// <param name="a">Value to have value 'b' added to</param>
        /// <param name="b">Value to add to value 'a'</param>
        public static int Add(int a, int b)
        {
            int res = a + b;
            return res;
        }

        /// <summary> Adds two decimal values together. </summary>
        /// <param name="a">Value to have value 'b' added to</param>
        /// <param name="b">Value to add to value 'a'</param>
        public static double Add(double a, double b)
        {
            double res = a + b;
            return res;
        }

        /// <summary> Subtracts a value from another. </summary>
        /// <param name="a">Value for value 'b' to be subtracted from.</param> 
        /// <param name="b">Value to subtract from value 'a'</param>
        public static int Subtract(int a, int b)
        {
            int res = a - b;
            return res;
        }

        /// <summary> Subtracts a decimal value from another. </summary>
        /// <param name="a">Value for value 'b' to be subtracted from.</param> 
        /// <param name="b">Value to subtract from value 'a'</param>
        public static double Subtract(double a, double b)
        {
            double res = a - b;
            return res;
        }

        /// <summary> Multiplies one value by another </summary>
        /// <param name="a"> Value to be multiplied by value 'b'. </param> 
        /// <param name="b"> Value to multiply value 'a' by. </param>
        public static int Multiply(int a, int b)
        {
            int res = a * b;
            return res;
        }

        /// <summary> Multiplies one decimal value by another </summary>
        /// <param name="a"> Value to be multiplied by value 'b'. </param> 
        /// <param name="b"> Value to multiply value 'a' by. </param>
        public static double Multiply(double a, double b)
        {
            double res = a * b;
            return res;
        }

        /// <summary> Divides one value by the another. </summary>
        /// <param name="a"> Value to divide by value 'b' </param> 
        /// <param name="b"> Value to divde value 'a' by. </param>
        public static int? Divide(int a, int b)
        {
            try
            {
                if (b == 0)
                {
                    return null;
                }

                else
                {
                    int res = a / b;
                    return res;
                }
            }

            catch (DivideByZeroException e)
            {
                Debug.WriteLine(e.StackTrace);
                return null;
            }
        }

        /// <summary> Divides one Decimal value by the another. </summary>
        /// <param name="a"> Value to divide by value 'b' </param> 
        /// <param name="b"> Value to divde value 'a' by. </param>
        public static double? Divide(double a, double b)
        {
            try
            {
                if (b == 0)
                {
                    return null;
                }

                else
                {
                    double res = a / b;
                    return res;
                }
            }

            catch (DivideByZeroException e)
            {
                Debug.WriteLine(e.StackTrace);
                return null;
            }
        }

        /// <summary> Gives remainder after dividing a value by the another. </summary>
        /// <param name="a"> Value to divide by value 'b' </param> 
        /// <param name="b"> Value to divde value 'a' by. </param>
        public static int? Mod(int a, int b)
        {
            // Catch divide by zero exception, print the stack trace to the debug console, return null as result.
            try
            {
                if (b == 0)
                {
                    return null;
                }

                else
                {
                    int res = a % b;
                    return res;
                }
            }

            catch (DivideByZeroException e)
            {
                Debug.WriteLine(e.StackTrace);
                return null;
            }
        }

        /// <summary> Returns square route of a given value </summary>
        /// <param name="a"> Value to return sqaure route of </param> 
        public static int? Sqrt(int a)
        {
            try
            {
                if (a < 0)
                {
                    return null;
                }
                else
                {
                    int res = (Convert.ToInt32(Math.Round((Math.Sqrt(a)))));
                    return res;
                }
            }

            catch (OverflowException e)
            {
                Debug.WriteLine(e.StackTrace);
                return null;
            }

            catch (FormatException e)
            {
                Debug.WriteLine(e.StackTrace);
                return null;
            }

        }

        public static double? Sqrt(double a)
        {
            try
            {
                if (a < 0)
                {
                    return null;
                }
                else
                {
                    double res = (Math.Sqrt(a));
                    return res;
                }
            }
            catch (OverflowException e)
            {
                {
                    Debug.WriteLine(e.StackTrace);
                    return null;
                }
            }
        }

        /// <summary> Returns the result of sqauring the value (To it's second power) e.g 2*2 or 2^2 </summary>
        /// <param name="a"> Value to raise to second power. </param> 
        public static int? Sqr(int a)
        {
            try
            {
                if (a < Math.Sqrt(int.MaxValue))
                {
                    int? res = Convert.ToInt32(Math.Pow(a, 2));
                    return res;
                }
                else
                {
                    return null;
                }
            }
            catch (OverflowException e)
            {
                Debug.WriteLine(e.StackTrace);
                return null;
            }

        }

        /// <summary> Returns the result of sqauring the Decimal value (To it's second power) e.g 2.2*2.2 or 2.2^2.0 </summary>
        /// <param name="a"> Value to raise to second power. </param> 
        public static double? Sqr(double a)
        {
            try
            {
                if (a < Math.Sqrt(double.MaxValue))
                {
                    double? res = (Math.Pow(a, 2));
                    return res;
                }
                else
                {
                    return null;
                }
            }
            catch (OverflowException e)
            {
                Debug.WriteLine(e.StackTrace);
                return null;
            }
            catch (FormatException e)
            {
                Debug.WriteLine(e.StackTrace);
                return null;
            }

        }

        /// <summary> Returns the result of Cubeing the value (To it's Third power) e.g 2*2*2 or 2^3 </summary>
        /// <param name="a"> Value to raise to Third power. </param> 
        public static int Cube(int a)
        {
            int res = a ^ 3;
            return res;
        }

        /// <summary> Returns the result of raising a given value to a given power </summary>
        /// <param name="x"> Value to be raised by the exponant'</param>
        /// <param name="exponent"> The exponant to raise the value 'x' to. </param>
        public static long Raise(long x, long exponent)
        {
            long res = x ^ exponent;
            return res;
        }

        public string GetDisplay()
        {
            return this.display;
        }

        public void Clear()
        {
            display = "0";
        }


        /// <summary> Evaluate a given expression from the Calculator TextBox.</summary>
        /// <param name="exp">the expression to be evluated</param>
        /// <returns>The result of the evaluated expression</returns>
        public static double? EvaluateD(string exp)
        {
            try
            {
                return Convert.ToDouble(dt.Compute(exp, ""));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                return null;
            }

        }


        /// <summary> Evaluate a given expression from the Calculator TextBox.</summary>
        /// <param name="exp">the expression to be evluated</param>
        /// <returns>The result of the evaluated expression</returns>
        public static int? EvaluateI(string exp)
        {
            try
            {
                return Convert.ToInt32(dt.Compute(exp, ""));
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);
                return null;
            }
        }
    }
}


