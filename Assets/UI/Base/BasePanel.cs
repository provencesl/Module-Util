using UnityEngine;
using System.Collections;

public class BasePanel : MonoBehaviour {
    protected UIManager uiMgr;
    public UIPanelType uIPanelType;

    public UIManager UIMgr
    {
        set { uiMgr = value; }

    }

    protected void Awake()
    {

        UIManager.Instance.AddPanelDic(uIPanelType,this.GetComponent<BasePanel>());
    
    }

    /// <summary>
    /// 界面被显示出来
    /// </summary>
    public virtual void OnEnter()
    {
        this.transform.GetChild(0).gameObject.SetActive(true);
    }

    /// <summary>
    /// 界面暂停
    /// </summary>
    public virtual void OnPause()
    {

    }

    /// <summary>
    /// 界面继续
    /// </summary>
    public virtual void OnResume()
    {

    }

    /// <summary>
    /// 界面不显示,退出这个界面，界面被关系
    /// </summary>
    public virtual void OnExit()
    {

    }
}
