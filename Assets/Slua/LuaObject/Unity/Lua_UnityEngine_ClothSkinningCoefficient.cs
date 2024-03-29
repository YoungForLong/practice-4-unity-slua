﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ClothSkinningCoefficient : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ClothSkinningCoefficient o;
			o=new UnityEngine.ClothSkinningCoefficient();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxDistance(IntPtr l) {
		try {
			UnityEngine.ClothSkinningCoefficient self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.maxDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxDistance(IntPtr l) {
		try {
			UnityEngine.ClothSkinningCoefficient self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.maxDistance=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxDistanceBias(IntPtr l) {
		try {
			UnityEngine.ClothSkinningCoefficient self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.maxDistanceBias);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxDistanceBias(IntPtr l) {
		try {
			UnityEngine.ClothSkinningCoefficient self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.maxDistanceBias=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collisionSphereRadius(IntPtr l) {
		try {
			UnityEngine.ClothSkinningCoefficient self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.collisionSphereRadius);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collisionSphereRadius(IntPtr l) {
		try {
			UnityEngine.ClothSkinningCoefficient self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.collisionSphereRadius=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collisionSphereDistance(IntPtr l) {
		try {
			UnityEngine.ClothSkinningCoefficient self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.collisionSphereDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collisionSphereDistance(IntPtr l) {
		try {
			UnityEngine.ClothSkinningCoefficient self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.collisionSphereDistance=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ClothSkinningCoefficient");
		addMember(l,"maxDistance",get_maxDistance,set_maxDistance,true);
		addMember(l,"maxDistanceBias",get_maxDistanceBias,set_maxDistanceBias,true);
		addMember(l,"collisionSphereRadius",get_collisionSphereRadius,set_collisionSphereRadius,true);
		addMember(l,"collisionSphereDistance",get_collisionSphereDistance,set_collisionSphereDistance,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ClothSkinningCoefficient),typeof(System.ValueType));
	}
}
