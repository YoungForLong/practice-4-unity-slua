﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointDrive : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.JointDrive o;
			o=new UnityEngine.JointDrive();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mode(IntPtr l) {
		try {
			UnityEngine.JointDrive self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.mode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mode(IntPtr l) {
		try {
			UnityEngine.JointDrive self;
			checkValueType(l,1,out self);
			UnityEngine.JointDriveMode v;
			checkEnum(l,2,out v);
			self.mode=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_positionSpring(IntPtr l) {
		try {
			UnityEngine.JointDrive self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.positionSpring);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_positionSpring(IntPtr l) {
		try {
			UnityEngine.JointDrive self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.positionSpring=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_positionDamper(IntPtr l) {
		try {
			UnityEngine.JointDrive self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.positionDamper);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_positionDamper(IntPtr l) {
		try {
			UnityEngine.JointDrive self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.positionDamper=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maximumForce(IntPtr l) {
		try {
			UnityEngine.JointDrive self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.maximumForce);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maximumForce(IntPtr l) {
		try {
			UnityEngine.JointDrive self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.maximumForce=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointDrive");
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"positionSpring",get_positionSpring,set_positionSpring,true);
		addMember(l,"positionDamper",get_positionDamper,set_positionDamper,true);
		addMember(l,"maximumForce",get_maximumForce,set_maximumForce,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.JointDrive),typeof(System.ValueType));
	}
}
