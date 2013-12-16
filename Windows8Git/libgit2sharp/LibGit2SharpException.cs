using System;
using System.Globalization;
using System.Runtime.Serialization;
using LibGit2Sharp.Core;

namespace LibGit2Sharp
{
    /// <summary>
    /// The exception that is thrown when an error occurs during application execution.
    /// </summary>
    public class LibGit2SharpException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibGit2SharpException"/> class.
        /// </summary>
        public LibGit2SharpException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibGit2SharpException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public LibGit2SharpException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibGit2SharpException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException"/> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
        public LibGit2SharpException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        internal LibGit2SharpException(string message, GitErrorCode code, GitErrorCategory category) : this(FormatMessage(message, code, category))
        {
            Data.Add("libgit2.code", (int)code);
            Data.Add("libgit2.category", (int)category);

        }

        private static string FormatMessage(string message, GitErrorCode code, GitErrorCategory category)
        {
            return String.Format(CultureInfo.InvariantCulture, "An error was raised by libgit2. Category = {0} ({1}).{2}{3}",
                          category,
                          code,
                          Environment.NewLine,
                          message);
        }
    }
}
