using System;
using System.Collections.Generic;

namespace MadLibs.Models
{
    public class Story
    {
        private string _name;
        private string _city;
        private string _state;
        private string _sport;
        private string _verb1;
        private string _verb2;
        private string _feeling;
        private string _family1;
        private string _family2;
        private string _place;
        private string _gender;
        private string _gender2;
        private string _royalty;

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetCity(string city)
        {
            _city = city;
        }

        public string GetCity()
        {
            return _city;
        }

        public void SetState(string state)
        {
            _state = state;
        }

        public string GetState()
        {
            return _state;
        }

        public void SetSport(string sport)
        {
            _sport = sport;
        }

        public string GetSport()
        {
            return _sport;
        }

        public void SetVerb1(string verb1)
        {
            _verb1 = verb1;
        }

        public string GetVerb1()
        {
            return _verb1;
        }

        public void SetVerb2(string verb2)
        {
            _verb2 = verb2;
        }

        public string GetVerb2()
        {
            return _verb2;
        }

        public void SetFeeling(string feeling)
        {
            _feeling = feeling;
        }

        public string GetFeeling()
        {
            return _feeling;
        }

        public void SetFamily1(string family1)
        {
            _family1 = family1;
        }

        public string GetFamily1()
        {
            return _family1;
        }

        public void SetFamily2(string family2)
        {
            _family2 = family2;
        }

        public string GetFamily2()
        {
            return _family2;
        }

        public void SetPlace(string place)
        {
            _place = place;
        }

        public string GetPlace()
        {
            return _place;
        }

        public void IsMale(string gender)
        {
            if (gender == "male")
            {
                _gender = "he";
                _gender2 = "his";
                _royalty = "Prince";
            }
            else
            {
                _gender = "she";
                _gender2 = "her";
                _royalty = "Princess";
            }
        }

        public string GetGender()
        {
            return _gender;
        }

        public string GetGender2()
        {
            return _gender2;
        }

        public string GetRoyalty()
        {
            return _royalty;
        }
    }
}
