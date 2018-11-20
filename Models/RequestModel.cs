using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using darkHeresyModel;
using darkHeresyModel.DTO;

namespace darkHeresyBack.Models

{
    public class RequestModel
    {
        public TestDTO TestDTO { get; set; }
        public Weapon WeaponDTO { get; set; }

        public object FindCorrectDTO()
        {
            Console.WriteLine("find DTO");
            return new object[] { TestDTO, WeaponDTO }.FirstOrDefault(w => w != null);
        }

    }
}