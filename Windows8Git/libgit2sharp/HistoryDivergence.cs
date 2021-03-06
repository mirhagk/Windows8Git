using LibGit2Sharp.Core;
using LibGit2Sharp.Core.Compat;
using System;

namespace LibGit2Sharp
{
    /// <summary>
    /// Holds information about the potential ancestor
    /// and distance from it and two specified <see cref="Commit"/>s.
    /// </summary>
    public class HistoryDivergence
    {
        private readonly Lazy<Commit> commonAncestor;

        /// <summary>
        /// Needed for mocking purposes.
        /// </summary>
        protected HistoryDivergence()
        { }

        internal HistoryDivergence(Repository repo, Commit one, Commit another)
        {
            commonAncestor = new Lazy<Commit>(() => repo.Commits.FindCommonAncestor(one, another));
            Tuple<int?, int?> div = Proxy.git_graph_ahead_behind(repo.Handle, another, one);

            One = one;
            Another = another;
            AheadBy = div.Item1;
            BehindBy = div.Item2;
        }

        /// <summary>
        /// Gets the <see cref="Commit"/> being used as a reference.
        /// </summary>
        public virtual Commit One { get; private set; }

        /// <summary>
        /// Gets the <see cref="Commit"/> being compared against <see cref="One"/>.
        /// </summary>
        public virtual Commit Another { get; private set; }

        /// <summary>
        /// Gets the number of commits that are reachable from <see cref="One"/>,
        /// but not from <see cref="Another"/>.
        /// <para>
        ///   This property will return <c>null</c> when <see cref="One"/>
        ///   and <see cref="Another"/> do not share a common ancestor.
        /// </para>
        /// </summary>
        public virtual int? AheadBy { get; private set; }

        /// <summary>
        /// Gets the number of commits that are reachable from <see cref="Second"/>,
        /// but not from <see cref="One"/>.
        /// <para>
        ///   This property will return <c>null</c> when <see cref="One"/>
        ///   and <see cref="Another"/> do not share a common ancestor.
        /// </para>
        /// </summary>
        public virtual int? BehindBy { get; private set; }

        /// <summary>
        /// Returns the best possible common ancestor <see cref="Commit"/> of <see cref="One"/>
        /// and <see cref="Another"/> or null if none found.
        /// </summary>
        public virtual Commit CommonAncestor
        {
            get
            {
                return commonAncestor.Value;
            }
        }
    }

    internal class NullHistoryDivergence : HistoryDivergence
    {
        public override Commit CommonAncestor
        {
            get { return null; }
        }
    }
}
