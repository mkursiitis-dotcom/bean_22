using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameScript : MonoBehaviour
{

    private string text;
    private string[] sampleText = { "Hello", "Have a nice day", "Nice to see you", "Look what's here", "Goodbye" };
    int randomIx;

    public GameObject inputField;
    public GameObject outputField;
    public GameObject reverseTextToggle;

    public void GetText()
    {
        randomIx = Random.Range(0, sampleText.Length);
        text = inputField.GetComponent<TMP_InputField>().text;
        outputField.GetComponent<TMP_Text>().text = sampleText[randomIx] + " " + text.ToUpper() + "!";
        reverseTextToggle.GetComponent<Toggle>().interactable = true;
        if (reverseTextToggle.GetComponent<Toggle>().isOn)
        {
            ReverseText();
        }
    }

    public void ReverseText()
    {
        char[] charArray = outputField.GetComponent<TMP_Text>().text.ToCharArray();
        System.Array.Reverse(charArray);
        outputField.GetComponent<TMP_Text>().text = new string(charArray);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}