using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _db;
        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<UserModel>> GetUsers()
        {
            return _db.LoadData<UserModel, dynamic>("dbo.spUser_GetAll", new { });
        }

        public async Task<UserModel?> GetUser(int id)
        {
            var result = await _db.LoadData<UserModel, dynamic>("dbo.spUser_Get", new { Id = id });
            return result.FirstOrDefault();
        }

        public async Task InsertUser(UserModel user)
        {
            await _db.SaveData("dbo.spUser_Insert", new { FirstName = user.FirstName, LastName = user.LastName });
        }

        public async Task UpdateUser(UserModel user)
        {
            await _db.SaveData("dbo.spUser_Update", new { Id = user.Id, FirstName = user.FirstName, LastName = user.LastName });
        }

        public async Task DeleteUser(int id)
        {
            await _db.SaveData("dbo.spUser_Delete", new { Id = id });
        }


    }
}
