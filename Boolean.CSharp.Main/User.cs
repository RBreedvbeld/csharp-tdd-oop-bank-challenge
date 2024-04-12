using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class User
    {
        private Dictionary<int, Account> _userAccounts;
        private int _id;
        private string _name;
        private string _password;

        // Getters
        public Dictionary<int, Account> UserAccounts => _userAccounts;
        public int Id => _id;
        public string Name => _name;
        public string Password => _password;

        /*
        public User(int id, string name)
        {
            _id = id;
            _name = name;

        }

        //User user = new User(000, "Rose Breedveld");

        */
    }
}
