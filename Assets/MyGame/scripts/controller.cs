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

    public InputField A;
    public InputField B;
    public int Result;
    public Text TxtResult;
    public Text Error;
    public Color Red = Color.red;
    public Color White = Color.white;
    public float InputAFl;
    public float InputBFl;

    public void AddNumbers()
    {
        try
        {
            InputAFl = float.Parse(A.text);
            A.image.color = White;
        }

        catch(System.Exception)
        {
            A.image.color = Red;
            Error.text = "Please enter a number";
        }

        try
        {
            InputBFl = float.Parse(B.text);
            B.image.color = White;
        }

        catch (System.Exception)
        {
            B.image.color = Red;
            Error.text = "Please enter a number";
        }

        Result = int.Parse(A.text) + int.Parse(B.text);
        Debug.Log(Result);
        TxtResult.text = Result.ToString();

    }



}
