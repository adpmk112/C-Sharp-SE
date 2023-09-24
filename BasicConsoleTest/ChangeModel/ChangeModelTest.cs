using BasicConsoleTest.DTOs;
using BasicConsoleTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConsoleTest.ChangeModel
{
    public static class ChangeModelTest
    {
        public static T Change<E, T>(this E dto) where E : PersonInfoDTO where T : PersonInfoResponse, new()
        {
            if (dto == null) return default(T);

            T model = new T
            {
                Name = dto.Name,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email
            };

            return model;
        }
    }
}
