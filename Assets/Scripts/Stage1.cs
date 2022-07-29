using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1 : MonoBehaviour
{
    enum FirstSceneState
    {
        sectionONE,
        sectionTWO,
        sectionTHREE,
        sectionFOUR,
        sectionFIVE,
        CLEAR,
    }
    private FirstSceneState statement_one = FirstSceneState.sectionONE; 

    [SerializeField]
    private GameObject UI_instanceTextBox = null;

    private int sectionCount = 0;
    private const int sectionOne = 3;

    private void Initialized()
    {
        sectionCount = 0;
        Debug.Log("initialize");
    }

    void Start()
    {
        Initialized();
    }

    void Update()
    {
        switch(statement_one)
        {
            case FirstSceneState.sectionONE:
                UpdateStateForSection1();
                break;
            case FirstSceneState.sectionTWO:
                UpdateStateForSection2();
                break;
            case FirstSceneState.sectionTHREE:
                UpdateStateForSection3();
                break;
            case FirstSceneState.sectionFOUR:
                UpdateStateForSection4();
                break;
            case FirstSceneState.sectionFIVE:
                UpdateStateForSection5();
                break;
            case FirstSceneState.CLEAR:
                break;
        }
    }

    #region SetState

    void SetUpdateState1()
    {
        statement_one = FirstSceneState.sectionONE;
    }

    void SetUpdateState2()
    {
        statement_one = FirstSceneState.sectionTWO;
    }

    void SetUpdateState3()
    {
        statement_one = FirstSceneState.sectionTHREE;
    }

    void SetUpdateState4()
    {
        statement_one = FirstSceneState.sectionFOUR;
    }

    void SetUpdateState5()
    {
        statement_one = FirstSceneState.sectionFIVE;
    }

    #endregion

    #region Update State 

    void UpdateStateForSection1()
    {
        if (!SceneManager.instance.textBoxView)
        {
            if (sectionCount < sectionOne)
            {
                sectionCount++;
                Instantiate(UI_instanceTextBox);
            }
            else
            {
                SetUpdateState2();
                Initialized();
            }
        }
    }

    void UpdateStateForSection2()
    {
        if (!SceneManager.instance.textBoxView)
        {
            if (sectionCount < sectionOne)
            {
                sectionCount++;
                Instantiate(UI_instanceTextBox);
            }
            else
            {
                SetUpdateState3();
                Initialized();
            }
        }
    }

    void UpdateStateForSection3()
    {
        if (!SceneManager.instance.textBoxView)
        {
            if (sectionCount < sectionOne)
            {
                sectionCount++;
                Instantiate(UI_instanceTextBox);
            }
            else
            {
                SetUpdateState4();
                Initialized();
            }
        }
    }

    void UpdateStateForSection4()
    {
        if (!SceneManager.instance.textBoxView)
        {
            if (sectionCount < sectionOne)
            {
                sectionCount++;
                Instantiate(UI_instanceTextBox);
            }
            else
            {
                SetUpdateState5();
                Initialized();
            }
        }
    }

    void UpdateStateForSection5()
    {
        if (!SceneManager.instance.textBoxView)
        {
            if (sectionCount < sectionOne)
            {
                sectionCount++;
                Instantiate(UI_instanceTextBox);
            }
            else
            {
                statement_one = FirstSceneState.CLEAR;
                Debug.Log("Clear point");
                Initialized();
            }
        }
    }

    #endregion 

}
