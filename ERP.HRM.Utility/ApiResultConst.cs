using System;

namespace ERP.HRM.Utility
{
    public static class ApiResultConst
    {
        
        #region Global Error
        public const string Success = "Uğurla əlavə edildi.!";
        public const string OperationSuccessed = "Əməliyyat uğurla başa çatdı.!";

        public const string Error = "Xəta baş verdi.!";

        public const string ModelNotValid = "Zəhmət olmasa bütün xanaları doldurun!";
        #endregion

        #region Personel Crud Error
        public const string NotFoundPersonel = "Axtardığınız şəxs sistemdə mövcud deyil!";

        public const string AleadyTakenPin = "Daxil etdiyiniz Fin kod artiq sistemde mövcuddur.!";
        #endregion


        #region User Crud Error
        public const string AleadyTakenUsername = "Daxil etdiyiniz istifadəçi adı artiq sistemde mövcuddur.!";

        public const string NotFoundUser = "Axtardığınız istifadəçi sistemdə mövcud deyil!";

        #endregion



    }
}
