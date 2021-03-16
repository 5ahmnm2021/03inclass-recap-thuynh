using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Controller : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("01ColorScene");
    }
    public void ChangeScenetoNum()
    {
        SceneManager.LoadScene("02NumberScene");

    }
    public void ChangeScenetoWelcome()
    {
        SceneManager.LoadScene("00WelcomeScene");

    }

    public InputField a;
    public InputField b;
    public int result;
    public Text txtResult;
    public bool num1 = true;
    public bool num2 = true;

    public void AddNumbers()
    {
       int inputAInt = 0;
       int inputBInt = 0;
       string errorMsg = "Enter two valid numbers";

        try
        {
            inputAInt = int.Parse(a.text);
            num1 = true;
            a.image.color = Color.white;
        }

        catch(System.Exception)
        {
            num1 = false;
            a.image.color = Color.red;
            a.text = errorMsg;
        }

        try
        {
            inputBInt = int.Parse(b.text);
            num2 = true;
            b.image.color = Color.white;
        }

        catch (System.Exception)
        {
            num2 = false;
            b.image.color = Color.red;
            b.text = errorMsg;
        }

        Debug.Log("a" + inputAInt + " b" + inputBInt);

        Debug.Log(num1+" "+num2);
        if (num1 && num2)
        {
            result = inputAInt + inputBInt;
            Debug.Log(result);
            txtResult.text = result.ToString();
        }
        
        

    }



}
