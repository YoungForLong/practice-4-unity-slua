using UnityEngine;
using System.Collections;
using SLua;

public class AppDelegate : MonoBehaviour {

    private LuaSvr luaSvr;
    private LuaFunction selfUpdate;
    private LuaTable self;

	// Use this for initialization
	void Start () 
    {
        luaSvr = new LuaSvr();
        luaSvr.init(null, () =>
        {
            self = (LuaTable)luaSvr.start("main");
            //selfUpdate = (LuaFunction)self["update"];
        });
	}

    //void Update()
    //{
    //    //保证lua虚拟机启动成功再执行update
    //    if (selfUpdate != null)
    //        selfUpdate.call(self);
    //}
}
