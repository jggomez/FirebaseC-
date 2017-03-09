using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using TestFirebase.auth;

namespace TestFirebase.data
{
    public class ManageDataPacient
    {

        private FirebaseClient firebaseClient;

        public ManageDataPacient()
        {
            Auth.getInstance().InitAuth();
            firebaseClient = Auth.getInstance().FirebaseClient;
        }

        public void SaveValidationList(string idArchivo, List<Pacient> lstPacient)
        {
            try
            {
                foreach (var pacient in lstPacient)
                {
                    firebaseClient
                     .Child(idArchivo)
                     .Child("Validation")
                     .Child(pacient.Identification)
                     .PutAsync(pacient);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveValidation(string idArchivo, Pacient pacient)
        {
            try
            {
                List<Pacient> lstPacient = new List<Pacient>();
                lstPacient.Add(pacient);
                SaveValidationList(idArchivo, lstPacient);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveData(string idArchivo, List<Pacient> lstPacient)
        {
            try
            {
                foreach (var pacient in lstPacient)
                {
                    firebaseClient
                     .Child(idArchivo)
                     .Child("Data")
                     .Child(pacient.Identification)
                     .PutAsync(pacient);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
