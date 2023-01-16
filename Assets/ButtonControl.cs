using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{

    public Text answerText, history, tempanswer, displayText;

    int operations = 0;
    int counter = 0;
    bool selector = false;
    double firstnum, secondnum, sum, difference, product, quotient, a, b;

    // Start is called before the first frame update
    void Start()
    {
        //displayText.text = "0";
    }

    public void btn1()
    {
        if (displayText.text != "0")
        {
            displayText.text += "1";
        }
        else { displayText.text = "1"; }

    }

    public void btn2()
    {
        if (displayText.text != "0")
        {
            displayText.text += "2";
        }
        else { displayText.text = "2"; }
    }

    public void btn3()
    {
        if (displayText.text != "0")
        {
            displayText.text += "3";
        }
        else { displayText.text = "3"; }
    }

    public void btn4()
    {
        if (displayText.text != "0")
        {
            displayText.text += "4";
        }
        else { displayText.text = "4"; }
    }

    public void btn5()
    {
        if (displayText.text != "0")
        {
            displayText.text += "5";
        }
        else { displayText.text = "5"; }
    }
    public void btn6()
    {
        if (displayText.text != "0")
        {
            displayText.text += "6";
        }
        else { displayText.text = "6"; }
    }

    public void btn7()
    {
        if (displayText.text != "0")
        {
            displayText.text += "7";
        }
        else { displayText.text = "7"; }
    }

    public void btn8()
    {
        if (displayText.text != "0")
        {
            displayText.text += "8";
        }
        else { displayText.text = "8"; }
    }

    public void btn9()
    {
        if (displayText.text != "0")
        {
            displayText.text += "9";
        }
        else { displayText.text = "9"; }
    }
    public void btn0()
    {
            displayText.text += "0";
    }
    public void pointBtn()
    {
        if (!displayText.text.Contains("."))
        {
            displayText.text += ".";
        }
    }

    public void addition()
    {
        if (history.text == "")
        {
            history.text = displayText.text + " +";
        }
        else if (history.text != "" && !history.text.Contains("="))
        {
            history.text = history.text + displayText.text + " +";
        }
        else if (history.text.Contains("="))
        {
            history.text = answerText.text + " + ";
        }

        if (operations == 2)
        {
            a = firstnum;
            b = Convert.ToDouble(displayText.text);
            difference = a - b;
            firstnum = difference;
            answerText.text = Convert.ToString(difference);
            tempanswer.text = Convert.ToString(difference);
            counter = 0;



        }
        if (operations == 3)
        {
            a = firstnum;
            b = Convert.ToDouble(displayText.text);
            product = a * b;
            firstnum = product;
            answerText.text = Convert.ToString(product);
            tempanswer.text = Convert.ToString(product);
            counter = 0;



        }
        if (operations == 4)
        {
            a = firstnum;
            b = Convert.ToDouble(displayText.text);
            quotient = a / b;
            firstnum = quotient;
            answerText.text = Convert.ToString(quotient);
            tempanswer.text = Convert.ToString(quotient);
            counter = 0;



        }
        if (selector == false)
        {
            if (counter == 0)
            {

                firstnum = Convert.ToDouble(displayText.text);
                displayText.text = "0";
                selector = true;
                operations = 1;

            }
            if (counter > 0)
            {
                secondnum = Convert.ToDouble(displayText.text);

                sum = firstnum + secondnum;
                firstnum = sum;
                answerText.text = Convert.ToString(firstnum);
                tempanswer.text = Convert.ToString(firstnum);
                displayText.text = "0";
                selector = true;
                operations = 1;
            }

            counter++;

        }
        else
        {
            if (counter == 0)
            {
                displayText.text = "0";
                firstnum = Convert.ToDouble(answerText.text);
                displayText.text = "0";
                selector = true;
                operations = 1;
            }
            if (counter > 0)
            {
                secondnum = Convert.ToDouble(displayText.text);

                sum = firstnum + secondnum;
                firstnum = sum;
                answerText.text = Convert.ToString(firstnum);
                tempanswer.text = Convert.ToString(firstnum);
                displayText.text = "0";
                selector = true;
                operations = 1;
            }

            counter++;
        }
    }

    public void subtraction()
    {
        if (history.text == "")
        {
            history.text = displayText.text + " -";
        }
        else if (history.text != "" && !history.text.Contains("="))
        {
            history.text = history.text + displayText.text + " -";
        }
        else if (history.text.Contains("="))
        {
            history.text = answerText.text + " - ";
        }
        if (operations == 1)
        {
            a = firstnum;
            b = Convert.ToDouble(displayText.text);
            sum = a + b;
            firstnum = sum;
            answerText.text = Convert.ToString(sum);
            tempanswer.text = Convert.ToString(sum);
            counter = 0;



        }
        if (operations == 3)
        {
            a = firstnum;
            b = Convert.ToDouble(displayText.text);
            product = a * b;
            firstnum = product;
            answerText.text = Convert.ToString(product);
            tempanswer.text = Convert.ToString(product);
            counter = 0;



        }
        if (operations == 4)
        {
            a = firstnum;
            b = Convert.ToDouble(displayText.text);
            quotient = a / b;
            firstnum = quotient;
            answerText.text = Convert.ToString(quotient);
            tempanswer.text = Convert.ToString(quotient);
            counter = 0;



        }
        if (selector == false)
        {
            if (displayText.text == "")
            {
                displayText.text = "-";
            }
            else
            {
                if (counter == 0)
                {

                    firstnum = Convert.ToDouble(displayText.text);
                    displayText.text = "0";
                    selector = true;
                    operations = 2;
                }
                if (counter > 0)
                {


                    secondnum = Convert.ToDouble(displayText.text);

                    difference = firstnum - secondnum;
                    answerText.text = Convert.ToString(difference);
                    tempanswer.text = Convert.ToString(difference);
                    firstnum = difference;

                    displayText.text = "0";
                    selector = true;
                    operations = 2;
                }

                counter++;
            }

        }
        else
        {
            if (counter == 0)
            {
                displayText.text = "0";
                firstnum = Convert.ToDouble(answerText.text);
                displayText.text = "0";
                selector = true;
                operations = 2;
            }
            if (counter > 0)
            {


                secondnum = Convert.ToDouble(displayText.text);

                difference = firstnum - secondnum;
                answerText.text = Convert.ToString(difference);
                tempanswer.text = Convert.ToString(difference);
                firstnum = difference;

                displayText.text = "0";
                selector = true;
                operations = 2;
            }

            counter++;
        }
    }

    public void multiplication()
    {
        if (history.text == "")
        {
            history.text = displayText.text + " x";
        }
        else if (history.text != "" && !history.text.Contains("="))
        {
            history.text = history.text + displayText.text + " x";
        }
        else if (history.text.Contains("="))
        {
            history.text = answerText.text + " x ";
        }
        if (operations == 1)
        {
            a = firstnum;
            b = Convert.ToDouble(displayText.text);
            sum = a + b;
            firstnum = sum;
            answerText.text = Convert.ToString(firstnum);
            tempanswer.text = Convert.ToString(firstnum);
            counter = 0;



        }
        if (operations == 2)
        {
            a = firstnum;
            b = Convert.ToDouble(displayText.text);
            difference = a - b;
            firstnum = difference;
            answerText.text = Convert.ToString(difference);
            tempanswer.text = Convert.ToString(difference);
            counter = 0;



        }
        if (operations == 4)
        {
            a = firstnum;
            b = Convert.ToDouble(displayText.text);
            quotient = a / b;
            firstnum = quotient;
            answerText.text = Convert.ToString(quotient);
            tempanswer.text = Convert.ToString(quotient);
            counter = 0;



        }
        if (selector == false)
        {
            if (counter == 0)
            {
                firstnum = Convert.ToDouble(displayText.text);
                displayText.text = "0";
                selector = true;
                operations = 3;
            }
            if (counter > 0)
            {
                secondnum = Convert.ToDouble(displayText.text);

                product = firstnum * secondnum;
                answerText.text = Convert.ToString(product);
                tempanswer.text = Convert.ToString(product);
                firstnum = product;

                displayText.text = "0";
                selector = true;
                operations = 3;
            }
            counter++;
        }
        else
        {
            if (counter == 0)
            {
                displayText.text = "0";
                firstnum = Convert.ToDouble(answerText.text);
                displayText.text = "0";
                selector = true;
                operations = 3;
            }
            if (counter > 0)
            {
                secondnum = Convert.ToDouble(displayText.text);

                product = firstnum * secondnum;
                answerText.text = Convert.ToString(product);
                tempanswer.text = Convert.ToString(product);
                firstnum = product;

                displayText.text = "0";
                selector = true;
                operations = 3;
            }
            counter++;
        }
    }

    public void division()
    {
        if (history.text == "")
        {
            history.text = displayText.text + " ÷ ";
        }
        else if (history.text != "" && !history.text.Contains("="))
        {
            history.text = history.text + displayText.text + " ÷ ";
        }
        else if (history.text.Contains("="))
        {
            history.text = answerText.text + " ÷ ";
        }
        if (operations == 1)
        {
            a = firstnum;
            b = Convert.ToDouble(displayText.text);
            sum = a + b;
            firstnum = sum;
            answerText.text = Convert.ToString(firstnum);
            tempanswer.text = Convert.ToString(firstnum);
            counter = 0;



        }
        if (operations == 3)
        {
            a = firstnum;
            b = Convert.ToDouble(displayText.text);
            product = a * b;
            firstnum = product;
            answerText.text = Convert.ToString(product);
            tempanswer.text = Convert.ToString(product);
            counter = 0;



        }
        if (operations == 2)
        {
            a = firstnum;
            b = Convert.ToDouble(displayText.text);
            difference = a - b;
            firstnum = difference;
            answerText.text = Convert.ToString(difference);
            tempanswer.text = Convert.ToString(difference);
            counter = 0;



        }
        if (selector == false)
        {
            if (counter == 0)
            {
                firstnum = Convert.ToDouble(displayText.text);
                displayText.text = "0";
                selector = true;
                operations = 4;
            }
            if (counter > 0)
            {
                secondnum = Convert.ToDouble(displayText.text);

                quotient = firstnum / secondnum;
                answerText.text = Convert.ToString(quotient);
                tempanswer.text = Convert.ToString(quotient);
                firstnum = quotient;


                displayText.text = "0";
                selector = true;
                operations = 4;
            }
            counter++;
        }
        else
        {
            if (counter == 0)
            {
                displayText.text = "0";
                firstnum = Convert.ToDouble(answerText.text);
                displayText.text = "0";
                selector = true;
                operations = 4;
            }
            if (counter > 0)
            {
                secondnum = Convert.ToDouble(displayText.text);

                quotient = firstnum / secondnum;
                answerText.text = Convert.ToString(quotient);
                tempanswer.text = Convert.ToString(quotient);
                firstnum = quotient;


                displayText.text = "0";
                selector = true;
                operations = 4;
            }
            counter++;
        }
    }

    public void equal()
    {
        history.text = history.text + displayText.text + " " + "=";


        if (selector == true)
        {
            secondnum = Convert.ToDouble(displayText.text);

        }
        if (operations == 1)
        {
            answerText.text = Convert.ToString(firstnum + secondnum);


        }
        else if (operations == 2)
        {

            answerText.text = Convert.ToString(firstnum - secondnum);

        }
        else if (operations == 3)
        {

            answerText.text = Convert.ToString(firstnum * secondnum);

        }
        else if (operations == 4)
        {

            answerText.text = Convert.ToString(firstnum / secondnum);

        }




    }

    public void clear()
    {
        displayText.text = "0";
        answerText.text = "";
        tempanswer.text = "";
        selector = false;
        operations = 0;
        counter = 0;
        history.text = "";
    }

    public void delete()
    {
        if (displayText.text != "")
        {
            displayText.text = displayText.text.Substring(0, displayText.text.Length - 1);
        }

    }
}