using System;
using System.Runtime.Serialization;

namespace LibGit2Sharp
{
    /// <summary>
    /// The exception that is thrown when the provided specification cannot uniquely identify a reference, an object or a path.
    /// </summary>
    public class AmbiguousSpecificationException : LibGit2SharpException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmbiguousSpecificationException"/> class.
        /// </summary>
        public AmbiguousSpecificationException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmbiguousSpecificationException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public AmbiguousSpecificationException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmbiguousSpecificationException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException"/> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
        public AmbiguousSpecificationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
