﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimatorTransitionInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AnimatorTransitionInfo o;
			o=new UnityEngine.AnimatorTransitionInfo();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsName(IntPtr l) {
		try {
			UnityEngine.AnimatorTransitionInfo self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.IsName(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsUserName(IntPtr l) {
		try {
			UnityEngine.AnimatorTransitionInfo self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.IsUserName(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nameHash(IntPtr l) {
		try {
			UnityEngine.AnimatorTransitionInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.nameHash);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_userNameHash(IntPtr l) {
		try {
			UnityEngine.AnimatorTransitionInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.userNameHash);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalizedTime(IntPtr l) {
		try {
			UnityEngine.AnimatorTransitionInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.normalizedTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimatorTransitionInfo");
		addMember(l,IsName);
		addMember(l,IsUserName);
		addMember(l,"nameHash",get_nameHash,null,true);
		addMember(l,"userNameHash",get_userNameHash,null,true);
		addMember(l,"normalizedTime",get_normalizedTime,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimatorTransitionInfo),typeof(System.ValueType));
	}
}
