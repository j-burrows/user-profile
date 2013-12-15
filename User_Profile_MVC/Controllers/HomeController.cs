using System.Web.Mvc;
using InfastructureLib;
using User_Profile.Models;
using UserProfileLib;
using UserProfileLib.Business;
using UserProfileLib.Data.Entities;
using System.Linq;
namespace User_Profile.Controllers{
    [Authorize]
    public class HomeController : Controller{
        private IProfileService service;
        private IInfastructureService infastructure;

        public HomeController() {
            service = new ProfileService();
            infastructure = new InfastructureService();
        }

        public ActionResult Index(){
            return View(HomeIndexViewModel.ForUserPage(User.Identity.Name, 35));
        }

        public ActionResult ViewList(){
            return View(UserListViewModel.ForUserPage(User.Identity.Name, 35));
        }

        public ActionResult ViewBlockedUserList(string blockedUsername) {
            return View("ViewList", BlockedUserListViewModel.ForUserPage(blockedUsername, 35));
        }

        public ActionResult ViewUsersBlockedList(string username) {
            return View("ViewList", UsersBlockedListView.ForUserPage(username, 35));
        }

        public ActionResult ViewFriendedUserList(string friendedUsername) {
            return View("ViewList", FriendedUserListViewModel.ForUserPage(friendedUsername, 35));
        }

        public ActionResult ViewUsersFriendedList(string username) {
            return View("ViewList", UsersFriendedListViewModel.ForUserPage(username, 35));
        }

        public ActionResult Update(DUser_Profile updating) {
            HomeIndexViewModel model = new HomeIndexViewModel { 
                avatars = service.Avatar_GetList(),
                profile = service.Profile_Update(updating, User.Identity.Name),
                navSection = infastructure.PageStructure_GetBySelected(35)
            };
            return View(model);            
        }

        [HttpPost]
        public ActionResult Avatar_Create(DAvatar creating) {
            return View("Index");
        }

        [HttpPost]
        public ActionResult Avatar_Update(DAvatar updating) {
            return View("Index");
        }

        [HttpPost]
        public ActionResult Avatar_Delete(DAvatar deleting) {
            return View("Index");
        }
         
        [HttpPost]
        public ActionResult UserProfile_Create(DUser_Profile creating, string returnView = "Index") {
            string returnUrl = returnView.Equals("Index") ?
                "http://www.jonathan-burrows.com/profile/home" :
                "http://www.jonathan-burrows.com/profile/Update";
            
            HomeIndexViewModel model = new HomeIndexViewModel { 
                avatars = service.Avatar_GetList(),
                profile = service.Profile_Create(creating, User.Identity.Name),
                navSection = infastructure.PageStructure_GetBySelected(35)
            };
            return View(returnView, model);
        }

        [HttpPost]
        public ActionResult UserProfile_Update(DUser_Profile updating) {
            return View("Index");
        }

        [HttpPost]
        public ActionResult UserProfile_Delete(DUser_Profile deleting) {
            return View("Index");
        }

        [HttpPost]
        public ActionResult BlockedUser_Create(DBlocked_User creating) {
            service.Blocked_User_Create(creating, User.Identity.Name);
            return View("Index");
        }

        [HttpPost]
        public ActionResult BlockedUser_Delete(DBlocked_User deleting) {
            service.Blocked_User_Delete(deleting, User.Identity.Name);
            return View("Index");
        }

        [HttpPost]
        public ActionResult FriendedUser_Create(DFriended_User creating) {
            service.Friended_User_Create(creating, User.Identity.Name);
            return View("Index"); 
        }

        [HttpPost]
        public ActionResult FriendedUser_Delete(DFriended_User deleting) {
            service.Friended_User_Delete(deleting, User.Identity.Name);
            return View("Index");
        }

    }
}
