using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryText : MonoBehaviour
{
    [SerializeField]
    private TextAsset textData = null;

    private Text t = null;
    private string textDataBuffer = null;
    private string[] textDataSplit = null;

    void Start()
    {
        TryGetComponent(out t);
        textDataBuffer = textData.text;
        textDataSplit = textDataBuffer.Split(char.Parse("\n"));

        StartCoroutine(PrefaceText());
    }

    IEnumerator PrefaceText()
    {
        t.text = "";

        yield return new WaitForSeconds(5);

        for (int i = 0; i < textDataSplit.Length; i++)
        {
            t.text = textDataSplit[i];
            yield return new WaitForSeconds(5);
        }

        Destroy(gameObject);

        yield return null;
    }
}
