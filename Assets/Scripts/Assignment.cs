using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*As01_CheckNumberSign();
        As02_GetDayName();
        As03_ValidatePassword();
        As04_GetGrade();
        As05_IsLeapYear();
        As06_Calculate();
        As07_GetSeason();*/
        // As08_PurchasingSystemExample();
        // As09_RockPaperScissorsExample();

        As10_CalculateWeaponDamage();
        // As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        // TODO: Implement logic to determine sign
        // Example: Debug.Log("Positive");
        //throw new System.NotImplementedException();

        if (as01Number > 0)
        {
            Debug.Log("Positive");
        }
        else if (as01Number < 0)
        {
            Debug.Log("Negative");
        }
        else
        {
            Debug.Log("Zero");
        }
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        // TODO: Implement logic to return day name
        // Example: Debug.Log("Monday");
        //throw new System.NotImplementedException();

        if (as02Day == 1)
        {
            Debug.Log("Monday");
        }
        else if (as02Day == 2)
        {
            Debug.Log("Tuseday");
        }
        else if (as02Day == 3)
        {
            Debug.Log("Wednesday");
        }
        else if (as02Day == 4)
        {
            Debug.Log("Thursday");
        }
        else if (as02Day == 5)
        {
            Debug.Log("Friday");
        }
        else if (as02Day == 6)
        {
            Debug.Log("Saturday");
        }
        else if (as02Day == 7)
        {
            Debug.Log("Sunday");
        }
        else
        {
            Debug.Log("Invalid day");
        }
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        // TODO: Implement password validation logic
        // Example: Debug.Log("True");
        //throw new System.NotImplementedException();

        if (as03InputPassword == as03CorrectPassword)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        // TODO: Implement logic to return grade
        // Example: Debug.Log("A");
        //throw new System.NotImplementedException();

        if (as04Score >= 80)
        {
            Debug.Log("A");
        }
        else if (as04Score >= 70)
        {
            Debug.Log("B");
        }
        else if (as04Score >= 60)
        {
            Debug.Log("C");
        }
        else if (as04Score >= 50)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        // TODO: Implement leap year check logic
        // Example: Debug.Log("True");
        //throw new System.NotImplementedException();
        if (as05Year % 400 == 0)
        {
            Debug.Log("True");
        }
        else if (as05Year % 100 == 0)
        {
            Debug.Log("False");
        }
        else if (as05Year % 4 == 0)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        // TODO: Implement calculator logic
        // Example: Debug.Log("Result: 42");
        //throw new System.NotImplementedException();
        switch (as06Op)
        {
            case '+': Debug.Log(as06Num1 + as06Num2); break;
            case '-': Debug.Log(as06Num1 - as06Num2); break;
            case '*': Debug.Log(as06Num1 * as06Num2); break;
            case '/':
                if (as06Num2 == 0)
                {
                    Debug.Log("Error: Cannot divide by zero");
                }
                else
                {
                    Debug.Log(as06Num1 / as06Num2); break;
                }
                break;
            default: Debug.Log("Invalid operator. Please use +, -, *, /"); break;
        }
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        // TODO: Implement logic to return season
        // Example: Debug.Log("Summer");
        //throw new System.NotImplementedException();
        if (as07Month <= 12)
        {
            if (as07Month == 12 || as07Month == 1 || as07Month == 2)
            {
                Debug.Log("Winter");
            }
            else if (as07Month >= 3 && as07Month <= 5)
            {
                Debug.Log("Spring");
            }
            else if (as07Month >= 6 && as07Month <= 8)
            {
                Debug.Log("Summer");
            }
            else if (as07Month >= 9 && as07Month <= 11)
            {
                Debug.Log("Fall");
            }
        }
        else
        {
            Debug.Log("Invalid month number. Please enter a number 1 - 12");
        }
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        //throw new System.NotImplementedException();
        if (as08Quantity <= 0)
        {
            Debug.Log("Out of stock");
        }
        else
        {
            if (as08Payment >= as08Price)
            {
                Debug.Log("You have received the product.");
                if (as08Payment > as08Price)
                {
                    Debug.Log($"You received your change. {as08Payment - as08Price} Bath");
                }
            }
            else
            {
                Debug.Log("You don't have enough money.");
            }
        }
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        //throw new System.NotImplementedException();
        if (as09UserChoice >= 0 && as09UserChoice <= 2)
        {
            if (as09UserChoice == 0 && as09ComputerChoice == 1)
            {
                Debug.Log("You Lose");
            }
            else if (as09UserChoice == 0 && as09ComputerChoice == 2)
            {
                Debug.Log("You Win");
            }
            else if (as09UserChoice == 1 && as09ComputerChoice == 0)
            {
                Debug.Log("You Win");
            }
            else if (as09UserChoice == 1 && as09ComputerChoice == 2)
            {
                Debug.Log("You Lose");
            }
            else if (as09UserChoice == 2 && as09ComputerChoice == 0)
            {
                Debug.Log("You Lose");
            }
            else if (as09UserChoice == 2 && as09ComputerChoice == 1)
            {
                Debug.Log("You Win");
            }
            else
            {
                Debug.Log("Tie");
            }
        }
        else
        {
            Debug.Log("Invalid number, Please Choose number 0 - 2");
        }
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        //throw new System.NotImplementedException();
        switch (as10WeaponType)
        {
            case "sword": Debug.Log(((int)(as10BaseDamage * 1.3)).ToString()); break;
            case "axe": Debug.Log(((int)(as10BaseDamage * 1.4)).ToString()); break;
            case "bow": Debug.Log(((int)(as10BaseDamage * 1.2)).ToString()); break;
            case "staff": Debug.Log(((int)(as10BaseDamage * 1.5)).ToString()); break;
            case "dagger": Debug.Log(((int)(as10BaseDamage * 1.1)).ToString()); break;
            default: Debug.Log(as10BaseDamage.ToString()); break;
        }
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        throw new System.NotImplementedException();
    }
}
