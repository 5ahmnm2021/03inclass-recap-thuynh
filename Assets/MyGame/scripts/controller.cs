using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class controller : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
    public Text error;
    public Color red = Color.red;
    public Color white = Color.white;
    //private int inputAInt;
    //private int inputBInt;
    public bool num1 = true;
    public bool num2 = true;

    public void AddNumbers()
    {
       int inputAInt = 0;
       int inputBInt = 0;

        try
        {
            inputAInt = int.Parse(a.text);
            num1 = true;
            a.image.color = white;
        }

        catch(System.Exception)
        {
            num1 = false;
            a.image.color = red;
            error.text = "Please enter a number";
        }

        try
        {
            inputBInt = int.Parse(b.text);
            num2 = true;
            b.image.color = white;
        }

        catch (System.Exception)
        {
            num2 = false;
            b.image.color = red;
            error.text = "Please enter a number";
        }

        Debug.Log("a" + inputAInt + " b" + inputBInt);

        Debug.Log(num1+" "+num2);
        if (num1 && num2)
        {
            result = inputAInt + inputBInt;
            Debug.Log(result);
            txtResult.text = result.ToString();
        }
        
        //Result = int.Parse(a.text) + int.Parse(B.text);
        

    }



}
