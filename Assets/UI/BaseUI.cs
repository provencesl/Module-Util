using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseUI : MonoBehaviour {

    protected virtual void Awake()
    {
        InitData();
    }
    protected virtual void Start() { }

    /// <summary>
    /// 面板初始化
    /// </summary>
    public abstract void InitData();

    /// <summary>
    /// 面板进入
    /// </summary>
    public virtual void OnEnter()
    {

    }

    /// <summary>
    /// 面板暂停
    /// </summary>
    public virtual void OnPause()
    {

    }

    /// <summary>
    /// 面板恢复
    /// </summary>
    public virtual void OnResume()
    {

    }

    /// <summary>
    /// 面板退出
    /// </summary>
    public virtual void OnExit()
    {

    }


    protected virtual void OnEvent(EventData eventData)
    {

    }

}

public class EventData
{
    public string UIType;
    public object[] data;

}
