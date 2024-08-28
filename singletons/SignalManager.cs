using Godot;
using System;

public partial class SignalManager : Node
{
    [Signal]
    public delegate void FromMainEventHandler();

    [Signal]
    public delegate void FromReceiverEventHandler(int count);


}
