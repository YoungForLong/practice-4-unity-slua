﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Random : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Random o;
			o=new UnityEngine.Random();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Range_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int),typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Random.Range(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(float))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Random.Range(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
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
	static public int get_seed(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Random.seed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_seed(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.Random.seed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Random.value);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_insideUnitSphere(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Random.insideUnitSphere);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_insideUnitCircle(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Random.insideUnitCircle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onUnitSphere(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Random.onUnitSphere);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotation(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Random.rotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationUniform(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Random.rotationUniform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Random");
		addMember(l,Range_s);
		addMember(l,"seed",get_seed,set_seed,false);
		addMember(l,"value",get_value,null,false);
		addMember(l,"insideUnitSphere",get_insideUnitSphere,null,false);
		addMember(l,"insideUnitCircle",get_insideUnitCircle,null,false);
		addMember(l,"onUnitSphere",get_onUnitSphere,null,false);
		addMember(l,"rotation",get_rotation,null,false);
		addMember(l,"rotationUniform",get_rotationUniform,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Random));
	}
}
