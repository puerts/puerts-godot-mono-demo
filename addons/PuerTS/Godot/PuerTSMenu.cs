using System.Reflection;
using System.IO;
using System;
using System.Diagnostics;
using Puerts.Editor.Generator;

class PuerTSMenu: Godot.Node
{
	public string saveTo = Godot.ProjectSettings.GlobalizePath("res://addons/PuerTS/Gen/");
	public void GenV1()
	{
		GenerateCode();
		GenerateDTS(); 
	}

	public void GenerateCode()
	{
		var start = DateTime.Now;
		Directory.CreateDirectory(saveTo);

		FileExporter.ExportWrapper(saveTo, new GodotDefaultLoader());
		GenRegisterInfo();
		System.Diagnostics.Debug.WriteLine("finished! use " + (DateTime.Now - start).TotalMilliseconds + " ms");

		Utils.SetFilters(null);
	}

	public void GenerateDTS()
	{
		var start = DateTime.Now;
		Directory.CreateDirectory(saveTo);
		Directory.CreateDirectory(Path.Combine(saveTo, "Typing/csharp"));
		FileExporter.ExportDTS(saveTo, new GodotDefaultLoader());
		System.Diagnostics.Debug.WriteLine("finished! use " + (DateTime.Now - start).TotalMilliseconds + " ms");

		Utils.SetFilters(null);
	}

	public void ClearAll()
	{
		if (Directory.Exists(saveTo))
		{
			Directory.Delete(saveTo, true);
		}
	}
	public void GenRegisterInfo()
	{
		var start = DateTime.Now;
		Directory.CreateDirectory(saveTo);
		FileExporter.GenRegisterInfo(saveTo, new GodotDefaultLoader());
		System.Diagnostics.Debug.WriteLine("finished! use " + (DateTime.Now - start).TotalMilliseconds + " ms Outputed to " + saveTo);
	}
}
