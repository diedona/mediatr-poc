using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.MediatrPOC.Domain.Command
{
    public class CommandResult
    {
        public CommandResult()
        {

        }

        public CommandResult(bool isOk, string message = null)
        {
            IsOk = isOk;
            Message = message;
        }

        public bool IsOk { get; set; }
        public string Message { get; set; }
    }
}
