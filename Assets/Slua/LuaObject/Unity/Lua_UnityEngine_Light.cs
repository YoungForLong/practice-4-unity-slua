﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Light : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Light o;
			o=new UnityEngine.Light();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLights_s(IntPtr l) {
		try {
			UnityEngine.LightType a1;
			checkEnum(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Light.GetLights(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			UnityEngine.LightType v;
			checkEnum(l,2,out v);
			self.type=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.color);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.color=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_intensity(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.intensity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_intensity(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.intensity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadows(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.shadows);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadows(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			UnityEngine.LightShadows v;
			checkEnum(l,2,out v);
			self.shadows=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowStrength(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shadowStrength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowStrength(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.shadowStrength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowBias(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shadowBias);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowBias(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.shadowBias=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowSoftness(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shadowSoftness);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowSoftness(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.shadowSoftness=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowSoftnessFade(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shadowSoftnessFade);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowSoftnessFade(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.shadowSoftnessFade=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_range(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.range);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_range(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.range=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spotAngle(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.spotAngle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spotAngle(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.spotAngle=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cookieSize(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cookieSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cookieSize(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.cookieSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cookie(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cookie);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cookie(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			UnityEngine.Texture v;
			checkType(l,2,out v);
			self.cookie=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flare(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.flare);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flare(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			UnityEngine.Flare v;
			checkType(l,2,out v);
			self.flare=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderMode(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.renderMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderMode(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			UnityEngine.LightRenderMode v;
			checkEnum(l,2,out v);
			self.renderMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alreadyLightmapped(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.alreadyLightmapped);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alreadyLightmapped(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.alreadyLightmapped=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cullingMask(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cullingMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cullingMask(IntPtr l) {
		try {
			UnityEngine.Light self=(UnityEngine.Light)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.cullingMask=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Light");
		addMember(l,GetLights_s);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"intensity",get_intensity,set_intensity,true);
		addMember(l,"shadows",get_shadows,set_shadows,true);
		addMember(l,"shadowStrength",get_shadowStrength,set_shadowStrength,true);
		addMember(l,"shadowBias",get_shadowBias,set_shadowBias,true);
		addMember(l,"shadowSoftness",get_shadowSoftness,set_shadowSoftness,true);
		addMember(l,"shadowSoftnessFade",get_shadowSoftnessFade,set_shadowSoftnessFade,true);
		addMember(l,"range",get_range,set_range,true);
		addMember(l,"spotAngle",get_spotAngle,set_spotAngle,true);
		addMember(l,"cookieSize",get_cookieSize,set_cookieSize,true);
		addMember(l,"cookie",get_cookie,set_cookie,true);
		addMember(l,"flare",get_flare,set_flare,true);
		addMember(l,"renderMode",get_renderMode,set_renderMode,true);
		addMember(l,"alreadyLightmapped",get_alreadyLightmapped,set_alreadyLightmapped,true);
		addMember(l,"cullingMask",get_cullingMask,set_cullingMask,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Light),typeof(UnityEngine.Behaviour));
	}
}
