using TMPro;
using UnityEngine;

public class TextFormatter : MonoBehaviour
{
    public string formatterString;
    private TextMeshProUGUI tmp;
    private TextMeshProUGUI Tmp
    {
        get
        {
            if (tmp == null)
                tmp = GetComponentInChildren<TextMeshProUGUI>();
            return tmp;
        }
    }

    private void Awake()
    {
        tmp = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void Format(int arg)
    {
        Tmp.SetText(formatterString, arg);
    }

    public void SetText(string text)
    {
        Tmp.SetText(text);
    }
}
