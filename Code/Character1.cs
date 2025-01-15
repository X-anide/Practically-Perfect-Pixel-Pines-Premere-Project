using Godot;
using System;

public partial class Character1 : CharacterBody2D
{
    public override void _PhysicsProcess(double delta) {
        var direction = Input.GetVector("move_left", "move_right", "move_up", "move_down");
        this.Velocity = direction  * 200;
        MoveAndSlide();
    }
}
