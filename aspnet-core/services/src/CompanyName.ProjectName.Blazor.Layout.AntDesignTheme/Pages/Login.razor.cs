using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Blazor.Layout.AntDesignTheme.Pages
{
    public partial class Login 
    {
        public SysUser SysLoginUserData { get; set; } = new SysUser() { UserName = "admin", Password = "123456" };

        public async void SubmitLogin()
        {
            await Task.CompletedTask;
        }
    }

    public class SysUser
    {

        public string UserName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>

        public string Password { get; set; }
    }
}
