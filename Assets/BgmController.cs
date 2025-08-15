using UnityEngine;
using UnityEngine.Audio;

public class BgmController : MonoBehaviour
{

    [SerializeField] private AudioMixer audioMixer;
    private const string LOWPASS_PARAM = "Cutoff";

    // 通常時のカットオフ周波数（高め）
    private float normalCutoff = 22000f;

    // くぐもった時のカットオフ周波数（低め）
    private float muffledCutoff = 500f;

    public void OnDialogOpen()
    {
        audioMixer.SetFloat(LOWPASS_PARAM, muffledCutoff);
    }

    public void OnDialogClose()
    {
        audioMixer.SetFloat(LOWPASS_PARAM, normalCutoff);
    }
}
