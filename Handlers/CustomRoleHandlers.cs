using Exiled.CustomRoles.API;
using Exiled.Loader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilinsAdditions.CustomRoles.Handlers
{
    public class CustomRoleHandlers
    {
        public static void RegisterRoles()
        {
            LilinsAdditionsCR.Instance.Config.riotOperator.Register();

            LilinsAdditionsCR.Instance.Config.kamikazeZombie.Register();

            LilinsAdditionsCR.Instance.Config.luckyMan.Register();

            LilinsAdditionsCR.Instance.Config.thief.Register();
        }

        public static void UnregisterRoles()
        {
            LilinsAdditionsCR.Instance.Config.riotOperator.Unregister();

            LilinsAdditionsCR.Instance.Config.kamikazeZombie.Unregister();

            LilinsAdditionsCR.Instance.Config.luckyMan.Unregister();

            LilinsAdditionsCR.Instance.Config.thief.Unregister();
        }
    }
}
