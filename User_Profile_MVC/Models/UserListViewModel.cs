using System.Collections.Generic;
using InfastructureLib;
using UserProfileLib;
using UserProfileLib.Data.Entities;
using System.Linq;
namespace User_Profile.Models{
    public class UserListViewModel : HomeIndexViewModel{
        public IEnumerable<User_ProfileInfo> allUsers { get; set; }

        new public static UserListViewModel ForUserPage(string username, int Page_ID){
            IInfastructureService infastructure = new InfastructureService();
            IProfileService service = new ProfileService();

            var allUsers = new List<User_ProfileInfo>();
            var profiles = service.Profile_GetList();
            foreach (var profile in profiles) {
                var info = new User_ProfileInfo { 
                    profile = profile,
                    enemies = service.Profile_GetUserWhoHaveBlocked(profile.username).Count(),
                    friendlies = service.Profile_GetUserWhoHaveFriended(profile.username).Count(),
                    friended = service.Profile_GetFriended(profile.username).Count(),
                    hated = service.Profile_GetBlocked(profile.username).Count()
                };
                allUsers.Add(info);
            }

            return new UserListViewModel {
                allUsers = allUsers,
                navSection = infastructure.PageStructure_GetBySelected(Page_ID),
                avatars = service.Avatar_GetList(),
                profile = service.Profile_GetByUser(username)
            };
            
        }
    }

    public class User_ProfileInfo {
        public DUser_Profile profile { get; set; }
        public int enemies { get; set; }
        public int friendlies { get; set; }
        public int hated { get; set; }
        public int friended { get; set; }
    }
}
