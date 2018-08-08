using System;
using System.Collections.Generic;
using System.Text;

namespace PNGMask_Core
{
    public class PNGMask_CoreException : Exception { public PNGMask_CoreException(string msg) : base(msg) { } };
    public class NotEnoughSpaceException : PNGMask_CoreException { public NotEnoughSpaceException(string msg) : base(msg) { } };
    public class InvalidPasswordException : PNGMask_CoreException { public InvalidPasswordException(string msg = "Invalid password") : base(msg) { } };
}
