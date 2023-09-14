using Godot;
using System;
using System.IO;
using System.Diagnostics;
using Puerts;

public class GodotDefaultLoader : ILoader
{
	public bool FileExists(string filepath)
	{
		var file = new Godot.File();
		return file.FileExists("res://addons/PuerTS/Runtime/Resources/" + filepath) ||
				file.FileExists("res://addons/PuerTS/Editor/Resources/" + filepath);
	}

	public string ReadFile(string filepath, out string debugpath)
	{
		var file = new Godot.File();
		if (file.FileExists("res://addons/PuerTS/Runtime/Resources/" + filepath)) {
			debugpath = Godot.ProjectSettings.GlobalizePath("res://addons/PuerTS/Runtime/Resources/" + filepath);
		} else if (file.FileExists("res://addons/PuerTS/Editor/Resources/" + filepath)) {
			debugpath = Godot.ProjectSettings.GlobalizePath("res://addons/PuerTS/Editor/Resources/" + filepath);
		} else {
			throw new Exception("file not found: " + filepath);
		}

		return System.IO.File.ReadAllText(debugpath);
	}
}
