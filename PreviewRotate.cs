using Godot;
using System;

public partial class PreviewRotate : Node3D
{
	[Export] public int RotationFactor { get; set; } = 200;

	private bool _mousePressed = false;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void DoRotate(Vector2 move) {
		GlobalRotate(Vector3.Up, move.X/RotationFactor);
		GlobalRotate(Vector3.Right, move.Y/RotationFactor);
	}
    public override void _Input(InputEvent @event)
    { 
		if (@event is InputEventMouseMotion eventMouseMotion && _mousePressed) {
			Vector2 deltaMouse = eventMouseMotion.Relative;
			DoRotate(deltaMouse);
		} else if (@event is InputEventMouseButton eventMouseButton)
		{
			_mousePressed = eventMouseButton.Pressed;
		}
    }
}
