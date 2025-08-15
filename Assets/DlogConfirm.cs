using UnityEngine;
using UnityEngine.UI;

public class DlogConfirmOptions
{
    public System.Action OkDelegete;
    public System.Action CancelDelegete;
    public string OkBtnLavel = "OK";
    public string CancelBtnLavel = "Cancel"; // ここを""にするとボタンは表示されない
    public string Description = "";
}

public class DlogConfirm : MonoBehaviour
{
    private DlogConfirmOptions myOptions;
    public static GameObject prefab;

    [SerializeField] GameObject CancelBtn;
    [SerializeField] Text OkBtnLabel;
    [SerializeField] Text CancelBtnLabel;
    [SerializeField] Text Description;

    public static DlogConfirm Show(DlogConfirmOptions op)
    { 

        if(prefab == null){
            prefab = Resources.Load<GameObject>("Canvas_Comfirm");
        }

        GameObject myObj = Instantiate(prefab);
        DlogConfirm me = myObj.GetComponent<DlogConfirm>();
        me.ShowContent(op);
        return me;

    }


    void ShowContent(DlogConfirmOptions op)
    {
        myOptions = op;

        //ボタンが一つしか入らないときに左のボタンを消す。
        if(myOptions.CancelBtnLavel == "")
        {
            CancelBtn.SetActive(false);
        }
        else
        {
            CancelBtnLabel.text = myOptions.CancelBtnLavel;
        }

        OkBtnLabel.text = myOptions.OkBtnLavel;
        Description.text = myOptions.Description;

    }

    public void OnTapOK()
    {
        myOptions.OkDelegete?.Invoke();
        Destroy(gameObject);
    }


    public void OnTapCancel()
    {
        myOptions.CancelDelegete?.Invoke();
        Destroy(gameObject);
    }



}
