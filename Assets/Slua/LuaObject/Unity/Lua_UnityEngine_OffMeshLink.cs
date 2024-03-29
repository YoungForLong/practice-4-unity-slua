﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_OffMeshLink : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.OffMeshLink o;
			o=new UnityEngine.OffMeshLink();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdatePositions(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			self.UpdatePositions();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activated(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.activated);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_activated(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.activated=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_occupied(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.occupied);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_costOverride(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.costOverride);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_costOverride(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.costOverride=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_biDirectional(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.biDirectional);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_biDirectional(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.biDirectional=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_navMeshLayer(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.navMeshLayer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_navMeshLayer(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.navMeshLayer=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoUpdatePositions(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoUpdatePositions);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoUpdatePositions(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autoUpdatePositions=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startTransform(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.startTransform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startTransform(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			UnityEngine.Transform v;
			checkType(l,2,out v);
			self.startTransform=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_endTransform(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.endTransform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_endTransform(IntPtr l) {
		try {
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
			UnityEngine.Transform v;
			checkType(l,2,out v);
			self.endTransform=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.OffMeshLink");
		addMember(l,UpdatePositions);
		addMember(l,"activated",get_activated,set_activated,true);
		addMember(l,"occupied",get_occupied,null,true);
		addMember(l,"costOverride",get_costOverride,set_costOverride,true);
		addMember(l,"biDirectional",get_biDirectional,set_biDirectional,true);
		addMember(l,"navMeshLayer",get_navMeshLayer,set_navMeshLayer,true);
		addMember(l,"autoUpdatePositions",get_autoUpdatePositions,set_autoUpdatePositions,true);
		addMember(l,"startTransform",get_startTransform,set_startTransform,true);
		addMember(l,"endTransform",get_endTransform,set_endTransform,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.OffMeshLink),typeof(UnityEngine.Component));
	}
}
