using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookFeaturesLogic
{
    public class AnalyzedFriendsCollection : IEnumerable
    {
        private readonly ICollection<User> r_FriendsCollection;

        public AnalyzedFriendsCollection(ICollection<User> i_FriendsCollection)
        {
            r_FriendsCollection = i_FriendsCollection;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (User friend in r_FriendsCollection)
            {
                yield return friend.Name;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (from friend in r_FriendsCollection
                    select friend.Name)
                    .GetEnumerator();
        }
    }
}
