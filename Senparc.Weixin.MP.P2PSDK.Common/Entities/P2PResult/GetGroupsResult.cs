using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK.Common
{
    public class GetGroupsResult : P2PResult<GroupsData>
    {
    }

    public class GroupsData :  IP2PResultData
    {
        public List<GroupData> GroupDataList { get; set; }

        public GroupsData()
        {
            GroupDataList = new List<GroupData>();
        }
    }
}
