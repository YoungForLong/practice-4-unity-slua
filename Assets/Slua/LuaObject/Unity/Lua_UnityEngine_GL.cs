﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GL : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.GL o;
			o=new UnityEngine.GL();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Vertex3_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.GL.Vertex3(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Vertex_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.GL.Vertex(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Color_s(IntPtr l) {
		try {
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			UnityEngine.GL.Color(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TexCoord_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.GL.TexCoord(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TexCoord2_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.GL.TexCoord2(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TexCoord3_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.GL.TexCoord3(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MultiTexCoord2_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.GL.MultiTexCoord2(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MultiTexCoord3_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			UnityEngine.GL.MultiTexCoord3(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MultiTexCoord_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.GL.MultiTexCoord(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Begin_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.GL.Begin(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int End_s(IntPtr l) {
		try {
			UnityEngine.GL.End();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadOrtho_s(IntPtr l) {
		try {
			UnityEngine.GL.LoadOrtho();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadPixelMatrix_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==0){
				UnityEngine.GL.LoadPixelMatrix();
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.GL.LoadPixelMatrix(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
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
	static public int Viewport_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.GL.Viewport(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadProjectionMatrix_s(IntPtr l) {
		try {
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,1,out a1);
			UnityEngine.GL.LoadProjectionMatrix(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadIdentity_s(IntPtr l) {
		try {
			UnityEngine.GL.LoadIdentity();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MultMatrix_s(IntPtr l) {
		try {
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,1,out a1);
			UnityEngine.GL.MultMatrix(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PushMatrix_s(IntPtr l) {
		try {
			UnityEngine.GL.PushMatrix();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PopMatrix_s(IntPtr l) {
		try {
			UnityEngine.GL.PopMatrix();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGPUProjectionMatrix_s(IntPtr l) {
		try {
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.GL.GetGPUProjectionMatrix(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetRevertBackfacing_s(IntPtr l) {
		try {
			System.Boolean a1;
			checkType(l,1,out a1);
			UnityEngine.GL.SetRevertBackfacing(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.Boolean a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				UnityEngine.GL.Clear(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				System.Boolean a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.GL.Clear(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
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
	static public int ClearWithSkybox_s(IntPtr l) {
		try {
			System.Boolean a1;
			checkType(l,1,out a1);
			UnityEngine.Camera a2;
			checkType(l,2,out a2);
			UnityEngine.GL.ClearWithSkybox(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int InvalidateState_s(IntPtr l) {
		try {
			UnityEngine.GL.InvalidateState();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IssuePluginEvent_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.GL.IssuePluginEvent(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_TRIANGLES(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.GL.TRIANGLES);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_TRIANGLE_STRIP(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.GL.TRIANGLE_STRIP);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_QUADS(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.GL.QUADS);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_LINES(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.GL.LINES);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_modelview(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.GL.modelview);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_modelview(IntPtr l) {
		try {
			UnityEngine.Matrix4x4 v;
			checkValueType(l,2,out v);
			UnityEngine.GL.modelview=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wireframe(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.GL.wireframe);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wireframe(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.GL.wireframe=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sRGBWrite(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.GL.sRGBWrite);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sRGBWrite(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.GL.sRGBWrite=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GL");
		addMember(l,Vertex3_s);
		addMember(l,Vertex_s);
		addMember(l,Color_s);
		addMember(l,TexCoord_s);
		addMember(l,TexCoord2_s);
		addMember(l,TexCoord3_s);
		addMember(l,MultiTexCoord2_s);
		addMember(l,MultiTexCoord3_s);
		addMember(l,MultiTexCoord_s);
		addMember(l,Begin_s);
		addMember(l,End_s);
		addMember(l,LoadOrtho_s);
		addMember(l,LoadPixelMatrix_s);
		addMember(l,Viewport_s);
		addMember(l,LoadProjectionMatrix_s);
		addMember(l,LoadIdentity_s);
		addMember(l,MultMatrix_s);
		addMember(l,PushMatrix_s);
		addMember(l,PopMatrix_s);
		addMember(l,GetGPUProjectionMatrix_s);
		addMember(l,SetRevertBackfacing_s);
		addMember(l,Clear_s);
		addMember(l,ClearWithSkybox_s);
		addMember(l,InvalidateState_s);
		addMember(l,IssuePluginEvent_s);
		addMember(l,"TRIANGLES",get_TRIANGLES,null,false);
		addMember(l,"TRIANGLE_STRIP",get_TRIANGLE_STRIP,null,false);
		addMember(l,"QUADS",get_QUADS,null,false);
		addMember(l,"LINES",get_LINES,null,false);
		addMember(l,"modelview",get_modelview,set_modelview,false);
		addMember(l,"wireframe",get_wireframe,set_wireframe,false);
		addMember(l,"sRGBWrite",get_sRGBWrite,set_sRGBWrite,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.GL));
	}
}
