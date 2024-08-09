﻿namespace Paraminter.Semantic.Type.Apheleia.Commands;

using Paraminter.Recorders.Commands;

internal sealed class InvalidateArgumentAssociationsRecordCommand
    : IInvalidateArgumentAssociationsRecordCommand
{
    public static IInvalidateArgumentAssociationsRecordCommand Instance { get; } = new InvalidateArgumentAssociationsRecordCommand();

    private InvalidateArgumentAssociationsRecordCommand() { }
}