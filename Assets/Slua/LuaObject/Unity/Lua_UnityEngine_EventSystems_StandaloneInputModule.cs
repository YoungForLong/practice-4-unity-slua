﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_StandaloneInputModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateModule(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			self.UpdateModule();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsModuleSupported(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			var ret=self.IsModuleSupported();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ShouldActivateModule(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			var ret=self.ShouldActivateModule();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ActivateModule(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			self.ActivateModule();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DeactivateModule(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			self.DeactivateModule();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Process(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			self.Process();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_allowActivationOnMobileDevice(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.allowActivationOnMobileDevice);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_allowActivationOnMobileDevice(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.allowActivationOnMobileDevice=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inputActionsPerSecond(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.inputActionsPerSecond);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inputActionsPerSecond(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.inputActionsPerSecond=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalAxis(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.horizontalAxis);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalAxis(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.horizontalAxis=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalAxis(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.verticalAxis);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalAxis(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.verticalAxis=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_submitButton(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.submitButton);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_submitButton(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.submitButton=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cancelButton(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cancelButton);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cancelButton(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.cancelButton=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.StandaloneInputModule");
		addMember(l,UpdateModule);
		addMember(l,IsModuleSupported);
		addMember(l,ShouldActivateModule);
		addMember(l,ActivateModule);
		addMember(l,DeactivateModule);
		addMember(l,Process);
		addMember(l,"allowActivationOnMobileDevice",get_allowActivationOnMobileDevice,set_allowActivationOnMobileDevice,true);
		addMember(l,"inputActionsPerSecond",get_inputActionsPerSecond,set_inputActionsPerSecond,true);
		addMember(l,"horizontalAxis",get_horizontalAxis,set_horizontalAxis,true);
		addMember(l,"verticalAxis",get_verticalAxis,set_verticalAxis,true);
		addMember(l,"submitButton",get_submitButton,set_submitButton,true);
		addMember(l,"cancelButton",get_cancelButton,set_cancelButton,true);
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.StandaloneInputModule),typeof(UnityEngine.EventSystems.PointerInputModule));
	}
}
