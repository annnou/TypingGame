using UnityEngine;
using UnityEngine.UI;

public class CloseUI : MonoBehaviour
{
    public void PushButtonClose()
    {
        Destroy(gameObject);
    }
}
