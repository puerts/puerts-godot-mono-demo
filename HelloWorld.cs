using Godot;
using System;
using System.IO;
using System.Diagnostics;
using Puerts;
using System.Collections.Generic;

[Configure]
public class ExamplesCfg
{
    [Binding]
    static IEnumerable<Type> Bindings
    {
        get
        {
            return new List<Type>()
            {
                typeof(Vector3),
            };
        }
    }
}

public class HelloWorld : Node
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		JsEnv env = new JsEnv(new GodotDefaultLoader()); 
		env.Eval("CS.System.Diagnostics.Debug.WriteLine('hello puerts')");
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
