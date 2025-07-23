using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDrop.Domain.Enums;
public enum DropStatus
{
    Pending = 0,
    Assigned = 1,
    InProgress = 2,
    Delivered = 3,
    Failed = 4
}