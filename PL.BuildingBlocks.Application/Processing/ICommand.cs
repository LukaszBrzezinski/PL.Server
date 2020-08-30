﻿using System;
using MediatR;

namespace PL.BuildingBlocks.Application
{
    public interface ICommand : IRequest
    {
    }

    public interface ICommand<out TResult> : IRequest<TResult>
    {

    }
}