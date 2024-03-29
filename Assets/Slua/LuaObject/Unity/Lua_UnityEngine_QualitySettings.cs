﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_QualitySettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.QualitySettings o;
			o=new UnityEngine.QualitySettings();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetQualityLevel_s(IntPtr l) {
		try {
			var ret=UnityEngine.QualitySettings.GetQualityLevel();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetQualityLevel_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.QualitySettings.SetQualityLevel(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				UnityEngine.QualitySettings.SetQualityLevel(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IncreaseLevel_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==0){
				UnityEngine.QualitySettings.IncreaseLevel();
				pushValue(l,true);
				return 1;
			}
			else if(argc==1){
				System.Boolean a1;
				checkType(l,1,out a1);
				UnityEngine.QualitySettings.IncreaseLevel(a1);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DecreaseLevel_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==0){
				UnityEngine.QualitySettings.DecreaseLevel();
				pushValue(l,true);
				return 1;
			}
			else if(argc==1){
				System.Boolean a1;
				checkType(l,1,out a1);
				UnityEngine.QualitySettings.DecreaseLevel(a1);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_names(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.QualitySettings.names);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelLightCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.QualitySettings.pixelLightCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelLightCount(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.QualitySettings.pixelLightCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowProjection(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.QualitySettings.shadowProjection);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowProjection(IntPtr l) {
		try {
			UnityEngine.ShadowProjection v;
			checkEnum(l,2,out v);
			UnityEngine.QualitySettings.shadowProjection=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowCascades(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.QualitySettings.shadowCascades);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowCascades(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.QualitySettings.shadowCascades=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowDistance(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.QualitySettings.shadowDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowDistance(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.QualitySettings.shadowDistance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_masterTextureLimit(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.QualitySettings.masterTextureLimit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_masterTextureLimit(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.QualitySettings.masterTextureLimit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anisotropicFiltering(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.QualitySettings.anisotropicFiltering);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anisotropicFiltering(IntPtr l) {
		try {
			UnityEngine.AnisotropicFiltering v;
			checkEnum(l,2,out v);
			UnityEngine.QualitySettings.anisotropicFiltering=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lodBias(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.QualitySettings.lodBias);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lodBias(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.QualitySettings.lodBias=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maximumLODLevel(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.QualitySettings.maximumLODLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maximumLODLevel(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.QualitySettings.maximumLODLevel=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleRaycastBudget(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.QualitySettings.particleRaycastBudget);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_particleRaycastBudget(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.QualitySettings.particleRaycastBudget=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_softVegetation(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.QualitySettings.softVegetation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_softVegetation(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.QualitySettings.softVegetation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxQueuedFrames(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.QualitySettings.maxQueuedFrames);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxQueuedFrames(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.QualitySettings.maxQueuedFrames=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vSyncCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.QualitySettings.vSyncCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_vSyncCount(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.QualitySettings.vSyncCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_antiAliasing(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.QualitySettings.antiAliasing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_antiAliasing(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.QualitySettings.antiAliasing=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_desiredColorSpace(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.QualitySettings.desiredColorSpace);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activeColorSpace(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.QualitySettings.activeColorSpace);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_blendWeights(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.QualitySettings.blendWeights);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_blendWeights(IntPtr l) {
		try {
			UnityEngine.BlendWeights v;
			checkEnum(l,2,out v);
			UnityEngine.QualitySettings.blendWeights=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.QualitySettings");
		addMember(l,GetQualityLevel_s);
		addMember(l,SetQualityLevel_s);
		addMember(l,IncreaseLevel_s);
		addMember(l,DecreaseLevel_s);
		addMember(l,"names",get_names,null,false);
		addMember(l,"pixelLightCount",get_pixelLightCount,set_pixelLightCount,false);
		addMember(l,"shadowProjection",get_shadowProjection,set_shadowProjection,false);
		addMember(l,"shadowCascades",get_shadowCascades,set_shadowCascades,false);
		addMember(l,"shadowDistance",get_shadowDistance,set_shadowDistance,false);
		addMember(l,"masterTextureLimit",get_masterTextureLimit,set_masterTextureLimit,false);
		addMember(l,"anisotropicFiltering",get_anisotropicFiltering,set_anisotropicFiltering,false);
		addMember(l,"lodBias",get_lodBias,set_lodBias,false);
		addMember(l,"maximumLODLevel",get_maximumLODLevel,set_maximumLODLevel,false);
		addMember(l,"particleRaycastBudget",get_particleRaycastBudget,set_particleRaycastBudget,false);
		addMember(l,"softVegetation",get_softVegetation,set_softVegetation,false);
		addMember(l,"maxQueuedFrames",get_maxQueuedFrames,set_maxQueuedFrames,false);
		addMember(l,"vSyncCount",get_vSyncCount,set_vSyncCount,false);
		addMember(l,"antiAliasing",get_antiAliasing,set_antiAliasing,false);
		addMember(l,"desiredColorSpace",get_desiredColorSpace,null,false);
		addMember(l,"activeColorSpace",get_activeColorSpace,null,false);
		addMember(l,"blendWeights",get_blendWeights,set_blendWeights,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.QualitySettings),typeof(UnityEngine.Object));
	}
}
