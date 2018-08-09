using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOnclickListener
{
    void OnClick(MyButton b);
}
public class MyButton : IOnclickListener
{
    public void OnClick()
    {
        if(onClickListener!=null)
        onClickListener.OnClick(this);
    }
    IOnclickListener onClickListener;
    public void SetClickListener(IOnclickListener o )
    {
        this.onClickListener = o;
    }

    public void OnClick(MyButton b)
    {
        Debug.Log("111");
    }
}
