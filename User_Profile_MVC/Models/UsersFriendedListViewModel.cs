using System.Collections.Generic;
using InfastructureLib;
using UserProfileLib;
using System.Linq;

namespace User_Profile.Models{
    public class UsersFriendedListViewModel : UserListViewModel{
        new public static UsersFriendedListViewModel ForUserPage(string username, int Page_ID){
            IInfastructureService infastructure = new InfastructureService();
            IProfileService service = new ProfileService();

            var _base = UserListViewModel.ForUserPage(username, Page_ID);
            var profiles = service.Profile_GetFriended(username);
            List<User_ProfileInfo> profileInfos = new List<User_ProfileInfo>();

            foreach (var profile in _base.allUsers) { 
                if(profiles.Any(x => x.User_Profile_ID == profile.profile.User_Profile_ID)){
                    profileInfos.Add(profile);
                }
            }

            return new UsersFriendedListViewModel {
                allUsers = profileInfos,
                navSection = _base.navSection,
                avatars = _base.avatars,
                profile = _base.profile
            };
        }
    }
}