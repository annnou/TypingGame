using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class WordGame : MonoBehaviour
{
    [SerializeField,Header("random Num")]
    private GameObject UI_Prefab_Random = null;

    [SerializeField,Header("Answer")]
    private GameObject UI_Prefab_Answer = null;

    [SerializeField,Header("image")]
    private Sprite sprite = null;

    [SerializeField, Header("UI_image")]
    private Image UI_Image = null;

    [SerializeField, Header("inputfield unmber")]
    private InputField inputField = null;

    [SerializeField, Header("inputfield name")]
    private InputField inputFieldName = null;

    public class T
    {
        public string[] name { get; set; }
        public int[] Hnumber { get; set; }

        public T()
        {
            name = new string[100];
            Hnumber = new int[100];
        }
    }

    private Text text = null;
    private T info = new T();
    private string number = null;
    private string namep = "";
    private bool first = false;

    void Start()
    {
        UI_Image.sprite = sprite;
    }

    // input word set
    public void InputString()
    {
        namep = inputFieldName.text;
    }

    async public void PushButton()
    {
        if (!first)
        {
            SetRandomNUM();
            first = true;
        }

        await Task.Delay(1000);
        first = false;
    }

    public void PushButton_Answer()
    {
        GameObject g = Instantiate(UI_Prefab_Answer);
        text = GameObject.Find("AnswerText__").GetComponent<Text>();
        text.text = "";

        for (int i = 0; i < count; i++)
        {
            for(int j = i; j < count; j++)
            {
                if (i != j && info.Hnumber[i] > info.Hnumber[j])
                {
                    var temp = info.Hnumber[i];
                    var temp2 = info.name[i];
                    info.Hnumber[i] = info.Hnumber[j];
                    info.name[i] = info.name[j];
                    info.Hnumber[j] = temp;
                    info.name[j] = temp2;
                }
            }
        }

        for (int i = 0;i < count;i++)
            text.text += info.name[i] + "ÇÃî‘çÜÇÕ : " + info.Hnumber[i] + "Ç≈Ç∑\n";
    }

    int count = 0;

    // next 
    public void SetRandomNUM()
    {
        GameObject g = Instantiate(UI_Prefab_Random);
        int N = Random.Range(1, 100 + 1);
        text = GameObject.Find("NumberText").GetComponent<Text>();
        text.text = namep + "ÇÃî‘çÜÇÕ\n" + N + "Ç≈Ç∑";
        info.name[count] = namep;
        info.Hnumber[count] = N;
        count++;
    }

    private void Update()
    {
        
    }
}
