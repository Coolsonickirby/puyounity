﻿using System;
using System.Collections.Generic;
using System.Linq;

public class PuyoGroup
{
    public PuyoGroup(IEnumerable<Puyo> puyos)
    {
        this.Puyos = puyos;
    }

    public IEnumerable<Puyo> Puyos { get; set; }

    public bool ContainPuyo(Puyo puyo)
    {
        if (puyo == null)
            throw new ArgumentNullException("puyo");

        return Puyos.Any(p => p.Row == puyo.Row && p.Column == puyo.Column);
    }
}