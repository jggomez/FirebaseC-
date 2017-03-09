using System;
using System.Collections.Generic;
using TestFirebase.data;

namespace TestFirebase
{
    public class Program
    {

        static void Main(string[] args)
        {
            string idArchivo = "4455";

            List<Pacient> lstPacient = new List<Pacient>();

            lstPacient.Add(CreatePatient("Juan G", "Gomez", "14638228", "3174498885"));
            lstPacient.Add(CreatePatient("Jose", "Berna", "445555", "558555555"));
            lstPacient.Add(CreatePatient("Pedro Antonio", "Torres", "47855555", "3174498885"));
            lstPacient.Add(CreatePatient("Juan", "Arango", "44485855", "3174498885"));

            ManageDataPacient objManageDataPacient = new ManageDataPacient();

            try
            {
                objManageDataPacient.SaveValidationList(idArchivo, lstPacient);
                objManageDataPacient.SaveData(idArchivo, lstPacient);

                Console.WriteLine("successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }


        private static Pacient CreatePatient(String name, string lastName, String identification, string cellPhoneNumber)
        {
            Pacient pacient = new Pacient();

            pacient.Name = name;
            pacient.LastName = lastName;
            pacient.Identification = identification;
            pacient.CellPhoneNumber = cellPhoneNumber;

            return pacient;
        }


    }
}
