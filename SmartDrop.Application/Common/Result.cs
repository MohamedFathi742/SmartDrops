using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDrop.Application.Common;

public class Result
{
    public bool Success { get; set; }
    public string? Message { get; set; }

    public static Result Ok(string? message = null) =>
        new Result { Success = true, Message = message };

    public static Result Fail(string message) =>
        new Result { Success = false, Message = message };
}
