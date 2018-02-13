namespace ThirdPartyPersistenceEngine
{
    /// <summary>
    /// Provides basic Create, Read, Update, and Delete operations for a given type.
    /// </summary>
    public abstract class Persister<T>
    {
        /// <summary>
        /// Inserts the object into the database or updates the existing record if record.Id already exists in the
        /// underlying database.
        /// </summary>
        /// <param name="record">Record (object) to insert into the database.</param>
        /// <returns>The ID created by the underlying database.</returns>
        public abstract string Save(T record);

        /// <summary>
        /// Looks up an object in the database or returns null if it is not found.
        /// </summary>
        /// <param name="id">The ID of the object to look for.</param>
        /// <returns></returns>
        public abstract T Get(string id);
    }
}