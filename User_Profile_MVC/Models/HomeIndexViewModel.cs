using System.Collections.Generic;
using InfastructureLib;
using InfastructureLib.Data.Entities;
using UserProfileLib;
using UserProfileLib.Data.Entities;
namespace User_Profile.Models{
    public class HomeIndexViewModel{
        public IEnumerable<IEnumerable<DPage>> navSection { get; set; }
        public IEnumerable<DAvatar> avatars { get; set; }
        public DUser_Profile profile { get; set; }

        public HomeIndexViewModel() {}

        public static HomeIndexViewModel ForUserPage(string username, int Page_ID){
            IInfastructureService infastructure = new InfastructureService();
            IProfileService service = new ProfileService();
            
            return new HomeIndexViewModel {
                navSection = infastructure.PageStructure_GetBySelected(Page_ID),
                avatars = service.Avatar_GetList(),
                profile = service.Profile_GetByUser(username)
            };
        }
    }
}