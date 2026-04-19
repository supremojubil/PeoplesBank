using FerPROJ.Web.Libraries.BaseModels;

namespace PeoplesBank.Models {
    public class UserModel : BaseModel {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public override bool DataValidation() {
            throw new NotImplementedException();
        }
    }
}
