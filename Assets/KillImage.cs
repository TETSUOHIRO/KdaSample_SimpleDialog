using UnityEngine;
using UnityEngine.UI;

public class KillImage : MonoBehaviour
{
    void Start()
    {
        Image myImage = GetComponent<Image>();
        if (myImage != null)
            myImage.enabled = false;

    }

}