using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Preface : MonoBehaviour
{
    [SerializeField]
    private List<Sprite> sprite = new List<Sprite>();

    [SerializeField]
    private Image image = null;

    enum NowPos
    {
        classRoom,
        bonePlain,
        mashroomPlain,
        cliffLoad,
        cliffLoad2,
        forestLoad,
        dungeon,
        dungeonOutback,
        dungeonSideHole,
        cryOfTheSoul,
        deamonCastle,
        deamonWorld,
        deamonLoad,
    }

    NowPos nowPos = NowPos.classRoom;

    void Start()
    {
        image.sprite = sprite[1];
    }

    void Update()
    {
        switch(nowPos)
        {
            #region Update State case devide
            case NowPos.classRoom:
                UpdateClassRoomState();
                break;
            case NowPos.bonePlain:
                UpdateBonePlainState();
                break;
            case NowPos.mashroomPlain:
                UpdateMashroomPlainState();
                break;
            case NowPos.cliffLoad:
                UpdateCliffLoadState();
                break;
            case NowPos.cliffLoad2:
                UpdateCliffLoad2State();
                break;
            case NowPos.forestLoad:
                UpdateForestLoadState();
                break;
            case NowPos.dungeon:
                UpdateDungeonState();
                break;
            case NowPos.dungeonOutback:
                UpdateDungeonOutbackState();
                break;
            case NowPos.dungeonSideHole:
                UpdateDungeonSideHoleState();
                break;
            case NowPos.cryOfTheSoul:
                UpdateCryOfTheSoulState();
                break;
            case NowPos.deamonCastle:
                UpdateDeamonCastleState();
                break;
            case NowPos.deamonWorld:
                UpdateDeamonWorldState();
                break;
            case NowPos.deamonLoad:
                UpdateDeamonLoadState();
                break;
            #endregion
            default:
                break;
        }
    }
    
    #region SetState
    void SetClassRoomState()
    {
        nowPos = NowPos.classRoom;
    }

    void SetBonePlainState()
    {
        nowPos = NowPos.bonePlain;
    }

    void SetMashroomPlainState()
    {
        nowPos = NowPos.mashroomPlain;
    }

    void SetCliffLoadState()
    {
        nowPos = NowPos.cliffLoad;
    }

    void SetCliffLoad2State()
    {
        nowPos = NowPos.cliffLoad2;
    }

    void SetForestLoadState()
    {
        nowPos = NowPos.forestLoad;
    }

    void SetDungeonState()
    {
        nowPos = NowPos.dungeon;
    }

    void SetDungeonOutbackState()
    {
        nowPos = NowPos.dungeonOutback;
    }

    void SetDungeonSideHoleState()
    {
        nowPos = NowPos.dungeonSideHole;
    }

    void SetCryOfTheSoulState()
    {
        nowPos = NowPos.cryOfTheSoul;
    }

    void SetDeamonCastleState()
    {
        nowPos = NowPos.deamonCastle;
    }

    void SetDeamonWorldState()
    {
        nowPos = NowPos.deamonWorld;
    }

    void SetDeamonLoadState()
    {
        nowPos = NowPos.deamonLoad;
    }

    #endregion

    #region UpdateState
    void UpdateClassRoomState()
    {

    }

    void UpdateBonePlainState()
    {

    }

    void UpdateMashroomPlainState()
    {

    }

    void UpdateCliffLoadState()
    {

    }

    void UpdateCliffLoad2State()
    {

    }

    void UpdateForestLoadState()
    {

    }

    void UpdateDungeonState()
    {

    }

    void UpdateDungeonOutbackState()
    {

    }

    void UpdateDungeonSideHoleState()
    {

    }

    void UpdateCryOfTheSoulState()
    {

    }

    void UpdateDeamonCastleState()
    {

    }

    void UpdateDeamonWorldState()
    {

    }

    void UpdateDeamonLoadState()
    {

    }

    #endregion

    IEnumerator Stop()
    {
        for(int i = 0; i < sprite.Count; i++)
        {
            yield return new WaitForSeconds(1.0f);

            image.sprite = sprite[i];
        }

        yield return null;
    }
}
