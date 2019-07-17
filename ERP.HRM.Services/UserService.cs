using System.Collections.Generic;
using System.Linq;
using ERP.HRM.DTO;
using ERP.HRM.Services.Interfaces;
using ERP.Repositories.Interfaces;
using ERP.Shared.Entities;


namespace ERP.HRM.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


       

        #region Datatable Paging

        public IQueryable<UserListDTO> GetUserPersonList()
        {
             var userPersonList=(from user in _unitOfWork.Repository<User>().Query()
                                 join person in _unitOfWork.Repository<Personel>().Query() on user.PersonelId equals person.Id
                                     into result
                                 from finalResult in result.DefaultIfEmpty()
                                 select  new UserListDTO
                                 {
                                     Id = user.Id,
                                     Status = user.Status,
                                     UserName = user.Username,
                                     //Fullname = finalResult==null?null:finalResult.Fullname,
                                     Fullname =finalResult.Fullname,
                                     PersonelId = user.PersonelId
                                 }).OrderByDescending(x => x.Id);

             return userPersonList;
        }



        #endregion


        #region Get Users /return UserID ,Username
        public IQueryable<UserForComboBoxDTO> GetUsers()
        {
            var userList=(from user in _unitOfWork.Repository<User>().Query()
                          select new UserForComboBoxDTO
                          {
                              Id = user.Id,
                              Username =user.Username
                          }).OrderByDescending(x => x.Id);

            return userList;
        }
        #endregion
    }
}
