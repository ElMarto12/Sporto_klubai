using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sporto_klubai.Utility;

namespace Sporto_klubai.Class.Client
{
    public class Personal
    {
        private string phoneNumber;
        private string email;
        private string gender;
        private string birthDate;
        private string bankNumber;
        private string personalCode;

        public Personal(string phoneNumber, string email ,string gender, string birthDate, string bankNumber, string personalCode)
        {
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.gender = gender;
            this.birthDate = birthDate;
            this.bankNumber = bankNumber;
            this.personalCode = personalCode;
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string BankNumber
        {
            get { return bankNumber; }
            set { bankNumber = value; }
        }

        public string PersonalCode
        {
            get { return personalCode; }
            set { personalCode = value; }
        }

        public void createPersonalData(string number, string email, string gender, string bDate, string bankNum, string pCode, string lastName) 
        {
            MySqlCommand cmd = null;

            string query = "INSERT INTO `mydb`.`asmeniniai_duomenys` (`tel_nr`, `el_pastas`, `lytis`, `gimimo_data`, `banko_saskaitos_nr`, `asmens_kodas`, `kliento_id`) VALUES ('"+number+"', '"+email+"', '"+gender+"', '"+bDate+"', '"+bankNum+"', '"+pCode+"', (SELECT kliento_id FROM klientas WHERE pavarde = '"+lastName+"'));";

            cmd = MySQLUtility.Query(query);


        }
    }
}
    