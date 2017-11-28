using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperWorkFlow.Models.Domain
{
    public enum PositionType
    {
        Owner = 1,
        Partner = 2,
        Manager = 3,
        Staff = 4
    }

    public enum PermissionType
    {
        ViewAssigned = 1,
        ViewAll = 2,
        Create = 3,
        Update = 4,
        Delete = 5,
        Complete = 6,
        Import = 7,
        AssignTemplate = 8,
        Review = 9,
        Archive = 10
    }
}