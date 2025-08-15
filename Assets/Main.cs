using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{

    
    public void OnTapOpenDialog01(Button bt)
    {
        bt.interactable = false;

        //このダイアログに何をさせるかを記したインスタンスを作成します。
        DlogConfirmOptions op = new DlogConfirmOptions();
        op.Description = "一番シンプルなダイアログです。";
        op.CancelBtnLavel = "";//この文字列をカラにしておくとCancelBtnが表示されない仕組み
        op.OkDelegete = () =>
        {
            Debug.Log("---> ダイアログを閉じた");
        };

        DlogConfirm.Show(op);


    }
}
