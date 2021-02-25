using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        //Property
        public int Id { get; set; }
        private string _firstName;
        //Ecapsulation //get veya set olayında bir değişiklik istersek bu durumu kullanabiliriz 
        public string FirstName
        {
            get { return "Mr. " + _firstName; }//get ksımı böyle calısacak
            set { _firstName = value; } 
        }
        public string LastName { get; set; }
        private string _city;
        //Encapsulation
        public string City 
        {
            get{ return _city + " Şehri"; }//get kısmı bu şekilde çalısacak yani sehirden sonra şehri ibaresi eklenecek
            set{ _city = value; }
        }
    }
}
