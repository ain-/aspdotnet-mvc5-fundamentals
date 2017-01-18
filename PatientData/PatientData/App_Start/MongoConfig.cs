using MongoDB.Driver;
using PatientData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientData.App_Start
{
    public static class MongoConfig
    {
        public static void Seed()
        {
            var patients = PatientDb.Open();

            if (!patients.AsQueryable().Any(p => p.Name == "Scott"))
            {
                var data = new List<Patient>()
                {
                    new Patient
                    {
                        Name = "Scott",
                        Ailments = new List<Ailment>()
                        {
                            new Ailment { Name = "Scott's Ailment" }
                        },
                        Medications = new List<Medication>()
                        {
                            new Medication { Name = "Scott's Medication", Doses = 1 }
                        }
                    },
                    new Patient
                    {
                        Name = "Joy",
                        Ailments = new List<Ailment>()
                        {
                            new Ailment { Name = "Joy's Ailment" }
                        },
                        Medications = new List<Medication>()
                        {
                            new Medication { Name = "Joy's Medication", Doses = 2 }
                        }
                    },
                };
                patients.InsertMany(data);
            }
        }
    }
}