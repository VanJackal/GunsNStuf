using Godot;
using System;

public partial class PreviewRotate : Node3D
{
	[Export] public int RotationFactor { get; set; } = 200;
	[Export] public int ZoomAmount { get; set; } = 4;
	[Export] public int ZoomFovMax { get; set; } = 120;
	[Export] public int ZoomFovMin { get; set; } = 1;
	
	[Export] public Camera3D Camera;

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

	private void ZoomCam(float zoom)
	{
		Camera.Fov -= zoom;
		Camera.Fov = Math.Clamp(Camera.Fov, ZoomFovMin, ZoomFovMax);
	}
    public override void _Input(InputEvent @event)
    { 
		if (@event is InputEventMouseMotion eventMouseMotion && _mousePressed) {
			Vector2 deltaMouse = eventMouseMotion.Relative;
			DoRotate(deltaMouse);
		} 
		else if (@event is InputEventMouseButton  eventMouseButton)
		{
			switch (eventMouseButton.ButtonIndex)
			{
				case MouseButton.Left:
					_mousePressed = eventMouseButton.Pressed;
					break;
				case MouseButton.WheelDown:
					ZoomCam(-ZoomAmount);
					break;
				case MouseButton.WheelUp:
					ZoomCam(ZoomAmount);
					break;
			}
		}
    }
}
