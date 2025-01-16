using Godot;
using System;

public partial class Character2Sprite : CharacterBody2D
{
    public override void _PhysicsProcess(double delta) {
        var direction = Input.GetVector("move_left", "move_right", "move_up", "move_down");
        this.Velocity = direction  * 200;
        MoveAndSlide();
        if(Input.IsActionPressed("move_left")) {
            ((Sprite2D)GetNode("Sprite2D")).FlipH = true;
        }
            if(Input.IsActionPressed("move_right")) {
            ((Sprite2D)GetNode("Sprite2D")).FlipH = false;
        }
        if (Velocity.Length() > 0.0)
        {
            PlayWalkAnimation();
        }
        else
        {
            PlayIdleAnimation();
        }
    }
    
    public void PlayIdleAnimation() {

        ((AnimationPlayer)GetNode("AnimationPlayer")).Play("idle");
    }

    public void PlayWalkAnimation() {
        ((AnimationPlayer)GetNode("AnimationPlayer")).Play("walk");
    }
}
