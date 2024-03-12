using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventCenter
{
    #region 事件广播主体
    //此处的代码可以不做修改直接使用

    //设置新的委托列表
    private static Dictionary<EventTypeI, Delegate> EventTable = new Dictionary<EventTypeI, Delegate>();

    /// <summary>
    /// 添加监听
    /// 可以理解为：添加号码
    /// </summary>
    /// <param name="EventTypeI"></param>
    /// <param name="callBack"></param>
    private static void OnListenerAdding(EventTypeI EventTypeI, Delegate callBack)
    {
        if (!EventTable.ContainsKey(EventTypeI))//是否有事件编码
        {
            //如果没有就添加
            EventTable.Add(EventTypeI, null);
        }
        Delegate d = EventTable[EventTypeI];
        if (d != null && d.GetType() != callBack.GetType())//d不为空，且，d的类型不为获取到的类型
        {
            //报错
            throw new Exception(string.Format("尝试为事件{0}添加不同类型的委托，当前事件所对应的委托是{1}，要添加的委托类型为{2}", EventTypeI, d.GetType(), callBack.GetType()));
            //↑请检查号码是否正确，并重新输入
        }
    }

    /// <summary>
    /// 移除监听
    /// 可以理解为：删除号码
    /// </summary>
    /// <param name="EventTypeI"></param>
    /// <param name="callBack"></param>
    private static void OnListenerRemoving(EventTypeI EventTypeI, Delegate callBack)
    {
        if (EventTable.ContainsKey(EventTypeI))
        {
            Delegate d = EventTable[EventTypeI];
            if (d == null)
            {
                //没有对应号码，或者号码已被删除
                throw new Exception(string.Format("移除监听错误：事件{0}没有对应的委托", EventTypeI));
            }
            else if (d.GetType() != callBack.GetType())
            {
                //请检查号码是否正确，并重新输入
                throw new Exception(string.Format("移除监听错误：尝试为事件{0}移除不同类型的委托，当前委托类型为{1}，要移除的委托类型为{2}", EventTypeI, d.GetType(), callBack.GetType()));
            }
        }
        else
        {
            //没有事件码（sim卡都没了）
            throw new Exception(string.Format("移除监听错误：没有事件码{0}", EventTypeI));
        }
    }
    private static void OnListenerRemoved(EventTypeI EventTypeI)
    {
        if (EventTable[EventTypeI] == null)//如果号码已经被删除
        {
            EventTable.Remove(EventTypeI);
        }
    }
    #endregion

    #region 0号广播类型(可复制修改)
    public static void AddListener(EventTypeI EventTypeI, CallBack callBack)
    {
        OnListenerAdding(EventTypeI, callBack);//在基站里添加
        EventTable[EventTypeI] = (CallBack)EventTable[EventTypeI] + callBack;//在手机里添加号码，+xx，xxx
    }

    public static void RemoveListener(EventTypeI EventTypeI, CallBack callBack)
    {
        OnListenerRemoving(EventTypeI, callBack);//在基站里删除
        EventTable[EventTypeI] = (CallBack)EventTable[EventTypeI] - callBack;
        OnListenerRemoved(EventTypeI);//中止通讯
    }

    public static void Broadcast(EventTypeI EventTypeI)
    {
        Delegate d;
        if (EventTable.TryGetValue(EventTypeI, out d))
        {
            CallBack callBack = d as CallBack;
            if (callBack != null)
            {
                callBack();//拨号
            }
            else
            {
                //打错电话了
                throw new Exception(string.Format("广播事件错误：事件{0}对应委托具有不同的类型", EventTypeI));
            }
        }
    }
    #endregion

    #region 1号广播类型(可复制修改)
    public static void AddListener<T>(EventTypeI EventTypeI, CallBack<T> callBack)
    {
        OnListenerAdding(EventTypeI, callBack);//在基站里添加
        EventTable[EventTypeI] = (CallBack<T>)EventTable[EventTypeI] + callBack;//在手机里添加号码，+xx，xxx
    }

    public static void RemoveListener<T>(EventTypeI EventTypeI, CallBack<T> callBack)
    {
        OnListenerRemoving(EventTypeI, callBack);//在基站里删除
        EventTable[EventTypeI] = (CallBack<T>)EventTable[EventTypeI] - callBack;
        OnListenerRemoved(EventTypeI);//中止通讯
    }

    public static void Broadcast<T>(EventTypeI EventTypeI, T arg)
    {
        Delegate d;
        if (EventTable.TryGetValue(EventTypeI, out d))
        {
            CallBack<T> callBack = d as CallBack<T>;
            if (callBack != null)
            {
                callBack(arg);//拨号
            }
            else
            {
                //打错电话了
                throw new Exception(string.Format("广播事件错误：事件{0}对应委托具有不同的类型", EventTypeI));
            }
        }
    }
    #endregion

    #region 2号广播类型(可复制修改)
    public static void AddListener<T,X>(EventTypeI EventTypeI, CallBack<T,X> callBack)
    {
        OnListenerAdding(EventTypeI, callBack);//在基站里添加
        EventTable[EventTypeI] = (CallBack<T,X>)EventTable[EventTypeI] + callBack;//在手机里添加号码，+xx，xxx
    }

    public static void RemoveListener<T,X>(EventTypeI EventTypeI, CallBack<T,X> callBack)
    {
        OnListenerRemoving(EventTypeI, callBack);//在基站里删除
        EventTable[EventTypeI] = (CallBack<T,X>)EventTable[EventTypeI] - callBack;
        OnListenerRemoved(EventTypeI);//中止通讯
    }

    public static void Broadcast<T,X>(EventTypeI EventTypeI, T arg1,X arg2)
    {
        Delegate d;
        if (EventTable.TryGetValue(EventTypeI, out d))
        {
            CallBack<T,X> callBack = d as CallBack<T,X>;
            if (callBack != null)
            {
                callBack(arg1,arg2);//拨号
            }
            else
            {
                //打错电话了
                throw new Exception(string.Format("广播事件错误：事件{0}对应委托具有不同的类型", EventTypeI));
            }
        }
    }
    #endregion

    #region 3号广播类型(可复制修改)
    public static void AddListener<T, X,Z>(EventTypeI EventTypeI, CallBack<T, X,Z> callBack)
    {
        OnListenerAdding(EventTypeI, callBack);//在基站里添加
        EventTable[EventTypeI] = (CallBack<T, X,Z>)EventTable[EventTypeI] + callBack;//在手机里添加号码，+xx，xxx
    }

    public static void RemoveListener<T, X,Z>(EventTypeI EventTypeI, CallBack<T, X,Z> callBack)
    {
        OnListenerRemoving(EventTypeI, callBack);//在基站里删除
        EventTable[EventTypeI] = (CallBack<T, X,Z>)EventTable[EventTypeI] - callBack;
        OnListenerRemoved(EventTypeI);//中止通讯
    }

    public static void Broadcast<T, X,Z>(EventTypeI EventTypeI, T arg1, X arg2, Z arg3)
    {
        Delegate d;
        if (EventTable.TryGetValue(EventTypeI, out d))
        {
            CallBack<T, X,Z> callBack = d as CallBack<T, X,Z>;
            if (callBack != null)
            {
                callBack(arg1, arg2,arg3);//拨号
            }
            else
            {
                //打错电话了
                throw new Exception(string.Format("广播事件错误：事件{0}对应委托具有不同的类型", EventTypeI));
            }
        }
    }
    #endregion

    #region 3号广播类型(可复制修改)
    public static void AddListener<T, X, Z,A>(EventTypeI EventTypeI, CallBack<T, X, Z,A> callBack)
    {
        OnListenerAdding(EventTypeI, callBack);//在基站里添加
        EventTable[EventTypeI] = (CallBack<T, X, Z,A>)EventTable[EventTypeI] + callBack;//在手机里添加号码，+xx，xxx
    }

    public static void RemoveListener<T, X, Z,A>(EventTypeI EventTypeI, CallBack<T, X, Z,A> callBack)
    {
        OnListenerRemoving(EventTypeI, callBack);//在基站里删除
        EventTable[EventTypeI] = (CallBack<T, X, Z,A>)EventTable[EventTypeI] - callBack;
        OnListenerRemoved(EventTypeI);//中止通讯
    }

    public static void Broadcast<T, X, Z,A>(EventTypeI EventTypeI, T arg1, X arg2, Z arg3, A arg4)
    {
        Delegate d;
        if (EventTable.TryGetValue(EventTypeI, out d))
        {
            CallBack<T, X, Z,A> callBack = d as CallBack<T, X, Z,A>;
            if (callBack != null)
            {
                callBack(arg1, arg2, arg3,arg4);//拨号
            }
            else
            {
                //打错电话了
                throw new Exception(string.Format("广播事件错误：事件{0}对应委托具有不同的类型", EventTypeI));
            }
        }
    }
    #endregion
}
