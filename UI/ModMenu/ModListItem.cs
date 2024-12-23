using Godot;
using System;
using GunsNStuf.Data.Models;

public partial class ModListItem : PanelContainer
{
	[Export]
	public string ModName
	{
		get=> _name;
		set
		{
			_name = value;
			Label.SetText(value);
		}
	}

	public void From(Attachment details)
	{
		this.ModName = details.Name;
	}

	private String _name = String.Empty;
	[Export] public Label Label;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//Label.SetText(_name);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
