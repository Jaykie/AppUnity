using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//拼图
public class SpellPhotoViewController : NaviViewController
{

    UISpellPhoto uiPrefab;
    UISpellPhoto ui;
    public int index;
    static private SpellPhotoViewController _main = null;
    public static SpellPhotoViewController main
    {
        get
        {
            if (_main == null)
            {
                _main = new SpellPhotoViewController();
                _main.Init();
            }
            return _main;
        }
    }


    void Init()
    {

        string strPrefab = "App/Prefab/Spell/UISpellPhoto";
        GameObject obj = PrefabCache.main.Load(strPrefab);
        if (obj != null)
        {
            uiPrefab = obj.GetComponent<UISpellPhoto>();
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
        ui = (UISpellPhoto)GameObject.Instantiate(uiPrefab);
        ui.SetController(this);
        UIViewController.ClonePrefabRectTransform(uiPrefab.gameObject, ui.gameObject);
    }
}

