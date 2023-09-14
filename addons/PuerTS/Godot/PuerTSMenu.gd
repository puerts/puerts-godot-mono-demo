tool
extends EditorPlugin


# A class member to hold the dock during the plugin life cycle.
var dock


func _enter_tree():
	# Initialization of the plugin goes here.
	# Load the dock scene and instance it.
	dock = preload("res://addons/PuerTS/PuerTSMenu.tscn").instance()
	dock.name = "PuerTS"
	
	var buttonGen = Button.new();
	buttonGen.text = "Generate All"
	buttonGen.connect('pressed', self, "_generate_all")
	buttonGen.margin_top = 0
	
	var buttonGenDTS = Button.new();
	buttonGenDTS.text = "Generate d.ts only"
	buttonGenDTS.connect('pressed', self, "_generate_dts")
	buttonGenDTS.margin_top = 50
	
	var buttonClear = Button.new();
	buttonClear.text = "Clear Generated"
	buttonClear.connect('pressed', self, "_clear_generated")
	buttonClear.margin_top = 100
	
	dock.add_child(buttonGen)
	dock.add_child(buttonGenDTS)
	dock.add_child(buttonClear)
	
	# Add the loaded scene to the docks.
	add_control_to_dock(DOCK_SLOT_LEFT_UL, dock)
	# Note that LEFT_UL means the left of the editor, upper-left dock.


func _exit_tree():
	# Clean-up of the plugin goes here.
	# Remove the dock.
	remove_control_from_docks(dock)
	# Erase the control from the memory.
	dock.free()

var PuerTSMenuCSharp = load("res://addons/PuerTS/Godot/PuerTSMenu.cs")
var PuerTSMenuCSharpNode = PuerTSMenuCSharp.new()

func _generate_all():
	PuerTSMenuCSharpNode.GenV1();
	
func _generate_dts():
	PuerTSMenuCSharpNode.GenerateDTS();
	
func _clear_generated():
	PuerTSMenuCSharpNode.ClearAll();
