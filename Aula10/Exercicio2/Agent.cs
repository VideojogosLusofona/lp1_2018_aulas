namespace Exercicio2
{
    /// <summary>
    /// This class represents an Agent which has a name and can move around.
    /// </summary>
    public abstract class Agent
    {

        /// <summary>
        /// A read-only property which represents the agent name.
        /// </summary>
        /// <value>The agent name.</value>
        public string Name { get; }

        /// <summary>
        /// Possible directions for the agent to follow. Derived classes can
        /// use this string to check for valid directions.
        /// </summary>
        protected const string directions = "NSWE";

        /// <summary>
        /// Agent constructor. Since Agent is an abstract class, this
        /// constructor is only a helper for derived classes.
        /// </summary>
        /// <param name="name">The name of the agent.</param>
        public Agent(string name)
        {
            // Keep the name of the agent.
            Name = name;
        }

        /// <summary>
        /// Order the agent to move. This is an abstract method, and as such,
        /// derived classes decide how to really move.
        /// </summary>
        /// <returns>
        /// The direction in which the agent moved, which can be 'N', 'S', 'W'
        /// or 'E'. Derived classes should follow this rule.
        /// </returns>
        public abstract char Move();
    }
}
