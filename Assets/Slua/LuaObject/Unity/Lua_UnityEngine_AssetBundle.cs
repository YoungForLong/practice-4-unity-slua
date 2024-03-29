﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AssetBundle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AssetBundle o;
			o=new UnityEngine.AssetBundle();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Contains(IntPtr l) {
		try {
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.Contains(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Load(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.Load(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Type a2;
				checkType(l,3,out a2);
				var ret=self.Load(a1,a2);
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
	static public int LoadAsync(IntPtr l) {
		try {
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Type a2;
			checkType(l,3,out a2);
			var ret=self.LoadAsync(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadAll(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				var ret=self.LoadAll();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.LoadAll(a1);
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
	static public int Unload(IntPtr l) {
		try {
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Unload(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateFromMemory_s(IntPtr l) {
		try {
			System.Byte[] a1;
			checkArray(l,1,out a1);
			var ret=UnityEngine.AssetBundle.CreateFromMemory(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateFromMemoryImmediate_s(IntPtr l) {
		try {
			System.Byte[] a1;
			checkArray(l,1,out a1);
			var ret=UnityEngine.AssetBundle.CreateFromMemoryImmediate(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateFromFile_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.AssetBundle.CreateFromFile(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.AssetBundle.CreateFromFile(a1,a2);
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
	static public int get_mainAsset(IntPtr l) {
		try {
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mainAsset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AssetBundle");
		addMember(l,Contains);
		addMember(l,Load);
		addMember(l,LoadAsync);
		addMember(l,LoadAll);
		addMember(l,Unload);
		addMember(l,CreateFromMemory_s);
		addMember(l,CreateFromMemoryImmediate_s);
		addMember(l,CreateFromFile_s);
		addMember(l,"mainAsset",get_mainAsset,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AssetBundle),typeof(UnityEngine.Object));
	}
}
