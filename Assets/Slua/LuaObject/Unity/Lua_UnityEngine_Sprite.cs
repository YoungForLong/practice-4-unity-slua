﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Sprite : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Sprite o;
			o=new UnityEngine.Sprite();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Create_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkValueType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Sprite.Create(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkValueType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Sprite.Create(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkValueType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.UInt32 a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Sprite.Create(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==6){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkValueType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.UInt32 a5;
				checkType(l,5,out a5);
				UnityEngine.SpriteMeshType a6;
				checkEnum(l,6,out a6);
				var ret=UnityEngine.Sprite.Create(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==7){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkValueType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.UInt32 a5;
				checkType(l,5,out a5);
				UnityEngine.SpriteMeshType a6;
				checkEnum(l,6,out a6);
				UnityEngine.Vector4 a7;
				checkType(l,7,out a7);
				var ret=UnityEngine.Sprite.Create(a1,a2,a3,a4,a5,a6,a7);
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
	static public int get_bounds(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bounds);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rect(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelsPerUnit(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pixelsPerUnit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texture(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.texture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textureRect(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textureRect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textureRectOffset(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textureRectOffset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_packed(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.packed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_packingMode(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.packingMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_packingRotation(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.packingRotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_border(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.border);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Sprite");
		addMember(l,Create_s);
		addMember(l,"bounds",get_bounds,null,true);
		addMember(l,"rect",get_rect,null,true);
		addMember(l,"pixelsPerUnit",get_pixelsPerUnit,null,true);
		addMember(l,"texture",get_texture,null,true);
		addMember(l,"textureRect",get_textureRect,null,true);
		addMember(l,"textureRectOffset",get_textureRectOffset,null,true);
		addMember(l,"packed",get_packed,null,true);
		addMember(l,"packingMode",get_packingMode,null,true);
		addMember(l,"packingRotation",get_packingRotation,null,true);
		addMember(l,"border",get_border,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Sprite),typeof(UnityEngine.Object));
	}
}
