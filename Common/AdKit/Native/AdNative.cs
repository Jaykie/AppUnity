﻿using UnityEngine;
using System.Collections;
 
namespace Moonma.AdKit.AdNative
{
  public class AdNative  
	{
		 public static void SetObjectInfo(string objName, string objMethod)
        {
					 BasePlatformWrapper platformWrapper = PlatformWrapper.platform;
            platformWrapper.SetObjectInfo( objName,objMethod);
        }
        	public static void InitAd(string source)
		{
            BasePlatformWrapper platformWrapper = PlatformWrapper.platform;
            platformWrapper.InitAd( source);
		}


		public static void ShowAd()
		{
			   BasePlatformWrapper platformWrapper = PlatformWrapper.platform;
            platformWrapper.ShowAd();
		}
		public static void OnClickAd()
		{
			   BasePlatformWrapper platformWrapper = PlatformWrapper.platform;
            platformWrapper.OnClickAd();
		}
		

    }
}