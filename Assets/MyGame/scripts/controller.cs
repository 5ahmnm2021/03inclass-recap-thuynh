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
        string errorMsg = "Enter valid number";

        try
        {
            inputAInt = int.Parse(a.text);
            num1 = true;
            a.image.color = Color.white;
        }
        catch (System.Exception)
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

        if (num1 && num2)
        {
            result = inputAInt + inputBInt;
            txtResult.text = result.ToString();
        } 

    }

    public Image colorField;
    public void ChangeColor()
    {
        Color[] colors =
        {
            new Color32(255, 205, 25, 100),
            new Color32(95, 34, 0, 100),
            new Color32(207, 63, 21, 100),
            new Color32(102, 47, 84, 100),
        };

        if (Input.GetKeyDown("space"))
        {
            colorField.color = colors[Random.Range(0, colors.Length)];
        }
    }
    void Update()
    {
        ChangeColor();
    }

}
