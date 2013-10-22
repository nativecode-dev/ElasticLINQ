﻿// Copyright (c) Tier 3 Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. 

namespace ElasticLinq.Request.Filters
{
    /// <summary>
    /// Filter that selects documents if they have any value
    /// in the specified field.
    /// </summary>
    internal class ExistsFilter : SingleFieldFilter, INegatableFilter
    {
        public ExistsFilter(string field)
            : base(field)
        {
        }

        public override string Name
        {
            get { return "exists"; }
        }

        public IFilter Negate()
        {
            return new MissingFilter(Field);
        }
    }
}