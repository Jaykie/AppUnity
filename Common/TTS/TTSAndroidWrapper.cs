﻿#if UNITY_ANDROID && !UNITY_EDITOR
using UnityEngine;
using System.Collections;
 
internal class TTSAndroidWrapper : TTSBasePlatformWrapper
	{
		public const string JAVA_CLASS_TTS = "com.moonma.tts.TTSBaidu";
        public override void Speek(string text)
		{ 
		Debug.Log("AndroidWrapper:InitAd");

				using(var javaClass = new AndroidJavaClass(JAVA_CLASS_TTS))
				{
					Debug.Log("TTSAndroidWrapper:Speek CallStatic");
					javaClass.CallStatic("speakText",text);
				}
		}

		 

    }
#endif

