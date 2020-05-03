using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Seven.BaseEntity.EnumInfo
{
    public enum EnumGlobalPermission
    {
        [Description("查看组织")]
        OrgView = 1,
        [Description("添加组织")]
        OrgAdd = 2,
        [Description("编辑组织")]
        OrgEdit = 3,
        [Description("删除组织")]
        OrgDelete = 4,
        [Description("组织统一修改")]
        OrgEditAllChild = 5,

        [Description("查看用户")]
        UserView = 6,
        [Description("添加用户")]
        UserAdd = 7,
        [Description("编辑用户")]
        UserEdit = 8,
        [Description("删除用户")]
        UserDelete = 9,
        [Description("移动用户")]
        UserMove = 10,

        [Description("查看群组")]
        GroupView = 11,
        [Description("添加群组")]
        GroupAdd = 12,
        [Description("编辑群组")]
        GroupEdit = 13,
        [Description("设置群组")]
        GroupMemberEdit = 14,
        [Description("删除群组")]
        GroupDelete = 15,
        [Description("移动群组")]
        GroupMove = 16,

        [Description("查看组织")]
        GroupCategoryAdd = 17,
        [Description("查看组织")]
        GroupCategoryEdit = 18,
        [Description("查看组织")]
        GroupCategoryDelete = 19,
    }

    public enum EnumOrgPermission
    {
        [Description("查看组织")]
        OrgView = 1,
        [Description("添加组织")]
        OrgAdd = 2,
        [Description("编辑组织")]
        OrgEdit = 3,
        [Description("删除组织")]
        OrgDelete = 4,
        [Description("组织统一修改")]
        OrgEditAllChild = 5,
    }

    public enum EnumGroupPermission
    {
        [Description("查看群组")]
        View = 1,
        [Description("编辑群组")]
        Edit = 2,
        [Description("删除群组")]
        Delete = 3,
        [Description("群组成员设置")]
        MeberEdit = 4,
        [Description("移动群组")]
        Move = 5,
    }

    public enum EnumCategoryPermission
    {
        [Description("查看群组组织")]
        CategoryView = 1,
        [Description("编辑群组组织")]
        CategoryEdit = 2,
        [Description("删除群组组织")]
        CategoryDelete = 3,
        [Description("添加群组组织")]
        CategoryAdd = 4,
        [Description("添加群组")]
        GroupAdd = 5,
        [Description("编辑群组")]
        GroupEdit = 6,
        [Description("删除群组")]
        GroupDelete = 7,
        [Description("群组成员设置")]
        GroupMemberEdit = 16,
        [Description("导入群组")]
        ImporGroup = 9,
        [Description("移动群组")]
        GroupMove = 10,
    }


}
