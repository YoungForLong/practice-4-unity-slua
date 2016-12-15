import "UnityEngine"

if not UnityEngine.GameObject or not  UnityEngine.UI then
	error("Click Make/All to generate lua wrap file")
end

local sphere = {}

function main()
    print("main start")
    sphere.root = GameObject("root")
    return sphere
end