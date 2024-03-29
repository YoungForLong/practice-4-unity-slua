﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PhysicMaterial : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.PhysicMaterial o;
			if(argc==1){
				o=new UnityEngine.PhysicMaterial();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,2,out a1);
				o=new UnityEngine.PhysicMaterial(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dynamicFriction(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dynamicFriction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dynamicFriction(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.dynamicFriction=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_staticFriction(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.staticFriction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_staticFriction(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.staticFriction=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounciness(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bounciness);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bounciness(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.bounciness=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frictionDirection2(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.frictionDirection2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_frictionDirection2(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.frictionDirection2=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dynamicFriction2(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dynamicFriction2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dynamicFriction2(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.dynamicFriction2=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_staticFriction2(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.staticFriction2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_staticFriction2(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.staticFriction2=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frictionCombine(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.frictionCombine);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_frictionCombine(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			UnityEngine.PhysicMaterialCombine v;
			checkEnum(l,2,out v);
			self.frictionCombine=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounceCombine(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.bounceCombine);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bounceCombine(IntPtr l) {
		try {
			UnityEngine.PhysicMaterial self=(UnityEngine.PhysicMaterial)checkSelf(l);
			UnityEngine.PhysicMaterialCombine v;
			checkEnum(l,2,out v);
			self.bounceCombine=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PhysicMaterial");
		addMember(l,"dynamicFriction",get_dynamicFriction,set_dynamicFriction,true);
		addMember(l,"staticFriction",get_staticFriction,set_staticFriction,true);
		addMember(l,"bounciness",get_bounciness,set_bounciness,true);
		addMember(l,"frictionDirection2",get_frictionDirection2,set_frictionDirection2,true);
		addMember(l,"dynamicFriction2",get_dynamicFriction2,set_dynamicFriction2,true);
		addMember(l,"staticFriction2",get_staticFriction2,set_staticFriction2,true);
		addMember(l,"frictionCombine",get_frictionCombine,set_frictionCombine,true);
		addMember(l,"bounceCombine",get_bounceCombine,set_bounceCombine,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.PhysicMaterial),typeof(UnityEngine.Object));
	}
}
