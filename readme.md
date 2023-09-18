# Godot PuerTS demo
this demo is for Godot 3.5 mono. It allows you to use [PuerTS](https://github.com/Tencent/puerts.git) as what it likes in Unity3D. So you can use Godot with Typescript

## Is it the best Javascript/Typescript solution in Godot?
No. PuerTS has potential to directly wrap to the Godot C++ code, it can provide better performance and no need to use Mono version Godot anymore. A similar project is https://github.com/Geequlim/ECMAScript, its author is also a member of PuerTS community. PuerTS can provide binding based on V8 instead of QuickJS, and provide D.ts generating. If you interested in it, please contact me.

## Will this repo continue?
You can continue using this repo as what PuerTS-Unity like. But I prefer the better solution I mention above so I will not provide more support of this repo. If you interested in it, go [here](https://github.com/Tencent/puerts/discussions/1525) to vote for it.

------
# Godot PuerTS demo
这个Demo是将PuerTS运行在Godot 3.5 mono的例子。通过这个例子你可以像在Unity里一样使用 [PuerTS](https://github.com/Tencent/puerts.git)

> 只测试了windows，其他平台需要你[按这篇mono文档](https://www.mono-project.com/docs/advanced/pinvoke/)放置普洱的二进制

## 这是最牛逼的Godot Javascript/Typescript 方案吗？
不，PuerTS其实可以直接绑定到Godot的C++层，无需经过mono。这样可以提供更高性能的绑定（更接近于PuerTS UE的方式而不是PuerTS Unity的方式），也无需强制你使用Godot Mono版本。有一个相似的项目是 https://github.com/Geequlim/ECMAScript，其作者也是PuerTS社区的重要贡献者。普洱在他项目的基础之上可以提供更高性能的基于V8的环境，以及d.ts的生成，当然这需要时间开发，如果你对其感兴趣，请联系我。

## 这个项目还会迭代吗
大部分情况下你可以模仿PuerTS-Unity的使用方式进行下去。但最终实现应该使用上述最牛逼方案，如果有足够多人需要Godot-PuerTS，我会提供。你可以前往[这里](https://github.com/Tencent/puerts/discussions/1525)参加新功能调研
