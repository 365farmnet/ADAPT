﻿/*******************************************************************************
  * Copyright (C) 2015 AgGateway and ADAPT Contributors
  * Copyright (C) 2015 Deere and Company
  * All rights reserved. This program and the accompanying materials
  * are made available under the terms of the Eclipse Public License v1.0
  * which accompanies this distribution, and is available at
  * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
  *
  * Contributors:
  *    Justin Sliekers - creation during Guidance realignment
  *******************************************************************************/

using System.Runtime.InteropServices;

namespace AgGateway.ADAPT.ApplicationDataModel
{
    public class GuidanceAllocation
    {
        public GuidanceAllocation()
        {
            Id = CompoundIdentifierFactory.Instance.Create();
        }

        public CompoundIdentifier Id { get; set; }

        public int GuidanceGroupId { get; set; }

        public TimeScope TimeScope { get; set; }

        public GuidanceShift GuidanceShift { get; set; }
    }
}
