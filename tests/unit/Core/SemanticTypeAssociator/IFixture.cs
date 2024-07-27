﻿namespace Paraminter.Semantic.Type.Apheleia;

using Paraminter.Associators.Queries;
using Paraminter.Queries.Handlers;
using Paraminter.Semantic.Type.Apheleia.Queries;
using Paraminter.Semantic.Type.Queries.Collectors;

internal interface IFixture
{
    public abstract IQueryHandler<IAssociateArgumentsQuery<IAssociateSemanticTypeData>, IInvalidatingAssociateSemanticTypeQueryResponseCollector> Sut { get; }
}