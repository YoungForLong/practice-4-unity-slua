﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Shadow : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ModifyVertices(IntPtr l) {
		try {
			UnityEngine.UI.Shadow self=(UnityEngine.UI.Shadow)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.UIVertex> a1;
			checkType(l,2,out a1);
			self.ModifyVertices(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_effectColor(IntPtr l) {
		try {
			UnityEngine.UI.Shadow self=(UnityEngine.UI.Shadow)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.effectColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_effectColor(IntPtr l) {
		try {
			UnityEngine.UI.Shadow self=(UnityEngine.UI.Shadow)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.effectColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_effectDistance(IntPtr l) {
		try {
			UnityEngine.UI.Shadow self=(UnityEngine.UI.Shadow)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.effectDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_effectDistance(IntPtr l) {
		try {
			UnityEngine.UI.Shadow self=(UnityEngine.UI.Shadow)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.effectDistance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useGraphicAlpha(IntPtr l) {
		try {
			UnityEngine.UI.Shadow self=(UnityEngine.UI.Shadow)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useGraphicAlpha);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useGraphicAlpha(IntPtr l) {
		try {
			UnityEngine.UI.Shadow self=(UnityEngine.UI.Shadow)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useGraphicAlpha=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Shadow");
		addMember(l,ModifyVertices);
		addMember(l,"effectColor",get_effectColor,set_effectColor,true);
		addMember(l,"effectDistance",get_effectDistance,set_effectDistance,true);
		addMember(l,"useGraphicAlpha",get_useGraphicAlpha,set_useGraphicAlpha,true);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.Shadow),typeof(UnityEngine.UI.BaseVertexEffect));
	}
}
