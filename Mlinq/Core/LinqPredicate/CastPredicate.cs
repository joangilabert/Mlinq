﻿using Mlinq.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mlinq.Core.LinqPredicate
{
    public sealed class CastPredicate : UnaryPredicate
    {
        public override void Accept(PredicateVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public override TResultType Accept<TResultType>(PredicateVisitor<TResultType> visitor)
        {
            throw new NotImplementedException();
        }
    }
}
