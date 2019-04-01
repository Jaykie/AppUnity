using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//拼接
public class SplicePhotoViewController : NaviViewController
{

    UISplicePhoto uiPrefab;
    UISplicePhoto ui;
    public int index;
    static private SplicePhotoViewController _main = null;
    public static SplicePhotoViewController main
    {
        get
        {
            if (_main == null)
            {
                _main = new SplicePhotoViewController();
                _main.Init();
            }
            return _main;
        }
    }


    void Init()
    {

        string strPrefab = "App/Prefab/Splice/UISplicePhoto";
        GameObject obj = PrefabCache.main.Load(strPrefab);
        if (obj != null)
        {
            uiPrefab = obj.GetComponent<UISplicePhoto>();
        }

    }

    public override void ViewDidLoad()
    {
        base.ViewDidLoad();
        CreateUI();
    }
    public override void LayOutView()
    {
        base.LayOutView();
        if (ui != null)
        {
            ui.LayOut();
        }
    }
    public void CreateUI()
    {
        ui = (UISplicePhoto)GameObject.Instantiate(uiPrefab);
        ui.SetController(this);
        UIViewController.ClonePrefabRectTransform(uiPrefab.gameObject, ui.gameObject);
    }
}

