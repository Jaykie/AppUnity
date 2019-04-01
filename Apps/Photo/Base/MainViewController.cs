using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainViewController : TabBarViewController
{
    static private MainViewController _main = null;
    public static MainViewController main
    {
        get
        {
            if (_main == null)
            {
                _main = new MainViewController();

            }
            return _main;
        }
    }

    void Init()
    {
        {
            TabBarItemInfo info = new TabBarItemInfo();
            info.controller = LayOutPhotoViewController.main;
            info.title = "Layout";
            AddItem(info);
        }

        {
            TabBarItemInfo info = new TabBarItemInfo();
            info.controller = SpellPhotoViewController.main;
            info.title = "Spell";
            AddItem(info);
        }
        {
            TabBarItemInfo info = new TabBarItemInfo();
            info.controller = SplicePhotoViewController.main;
            info.title = "Splice";
            AddItem(info);
        }


        SelectItem(0);
    }

    public override void ViewDidLoad()
    {
        //必须先调用基类方法以便初始化
        base.ViewDidLoad();
        Init();
        Debug.Log("MainViewController ViewDidLoad");
    }
    public override void ViewDidUnLoad()
    {
        //必须先调用基类方法
        base.ViewDidUnLoad();
    }

}
