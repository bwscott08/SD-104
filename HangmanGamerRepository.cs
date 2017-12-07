using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_GUI
{
    class HangmanGamerRepository
    {
        HangmanDBContext _db = new HangmanDBContext();


        /// <summary>
        /// Returns a list of all HangmanGamer objects in the database.
        /// </summary>
        /// <returns></returns>
        public List<HangmanGamer> GetHangmanGamers()
        {
            return _db.HangmanGamers.ToList();
        }


        /// <summary>
        /// Returns first hangmanGamet object from the db with a name equal to "string name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public HangmanGamer GetGamerByName(string name)
        {
            return _db.HangmanGamers.FirstOrDefault(g => g.Name == name);
        }


        /// <summary>
        /// Adds the passed Hangman gamer to the database
        /// </summary>
        /// <param name="gamer"></param>
        public void AddGamer(HangmanGamer gamer)
        {
            _db.HangmanGamers.Add(gamer);
        }


        /// <summary>
        /// Saves all the changes to the collection of the gamers to the database.
        /// </summary>
        public void Save()
        {
            _db.SaveChanges();
        }

        public void UpdateGamer(HangmanGamer gamer)
        {
            _db.Entry(gamer).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
