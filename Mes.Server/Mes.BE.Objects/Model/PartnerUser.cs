﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

using MES.Libraries;

namespace Mes.BE.Objects
{
	/// <summary>
	/// 代码工具生成，不可以手工修改。2017-08-28 10:00:11。
	/// </summary>
	[Serializable]
	[DataContract(Name = "PartnerUser")]
	public class PartnerUser
	{
		public PartnerUser()
		{
		}
        /// <summary>
        ///CompanyID
        /// </summary>
        [DataMember(Name = "CompanyID")]
        public Guid CompanyID
        {
            get;
            set;
        }
        /// <summary>
        ///用户ID
        /// </summary>
        [DataMember(Name = "UserID")]
		public Guid UserID
		{
			get;
			set;
		}
		
		/// <summary>
		///
		/// </summary>
		[DataMember(Name = "PartnerID")]
		public Guid PartnerID
		{
			get;
			set;
		}
		
		/// <summary>
		///用户编号
		/// </summary>
		[DataMember(Name = "UserCode")]
		public string UserCode
		{
			get;
			set;
		}
		
		/// <summary>
		///姓名
		/// </summary>
		[DataMember(Name = "UserName")]
		public string UserName
		{
			get;
			set;
		}
		
		/// <summary>
		///性别
		/// </summary>
		[DataMember(Name = "Sex")]
		public string Sex
		{
			get;
			set;
		}
		
		/// <summary>
		///职位
		/// </summary>
		[DataMember(Name = "Position")]
		public string Position
		{
			get;
			set;
		}
		
		/// <summary>
		///电子邮件
		/// </summary>
		[DataMember(Name = "Email")]
		public string Email
		{
			get;
			set;
		}
		
		/// <summary>
		///移动电话
		/// </summary>
		[DataMember(Name = "Mobile")]
		public string Mobile
		{
			get;
			set;
		}
		
		/// <summary>
		///描述
		/// </summary>
		[DataMember(Name = "Description")]
		public string Description
		{
			get;
			set;
		}
		
		/// <summary>
		///登录密码
		/// </summary>
		[DataMember(Name = "Password")]
		public string Password
		{
			get;
			set;
		}
		
		/// <summary>
		///登录错误的次数
		/// </summary>
		[DataMember(Name = "LoginErrorCount")]
		public int LoginErrorCount
		{
			get;
			set;
		}
		
		/// <summary>
		///最后一次登录时间
		/// </summary>
		[DataMember(Name = "LastLoginTime")]
		public DateTime LastLoginTime
		{
			get;
			set;
		}
		
		/// <summary>
		///是否禁用
		/// </summary>
		[DataMember(Name = "IsDisabled")]
		public bool IsDisabled
		{
			get;
			set;
		}
		
		/// <summary>
		///是否锁定
		/// </summary>
		[DataMember(Name = "IsLocked")]
		public bool IsLocked
		{
			get;
			set;
		}
		
		/// <summary>
		///
		/// </summary>
		[DataMember(Name = "IsSystem")]
		public bool IsSystem
		{
			get;
			set;
		}
		
		/// <summary>
		///创建时间
		/// </summary>
		[DataMember(Name = "Created")]
		public DateTime Created
		{
			get;
			set;
		}
		
		/// <summary>
		///创建人
		/// </summary>
		[DataMember(Name = "CreatedBy")]
		public string CreatedBy
		{
			get;
			set;
		}
		
		/// <summary>
		///修改时间
		/// </summary>
		[DataMember(Name = "Modified")]
		public DateTime Modified
		{
			get;
			set;
		}
		
		/// <summary>
		///修改人
		/// </summary>
		[DataMember(Name = "ModifiedBy")]
		public string ModifiedBy
		{
			get;
			set;
		}

        /// <summary>
        /// 是否完善资料
        /// </summary>
        [DataMember(Name = "IsFinishInfo")]
        public bool IsFinishInfo { get; set; }

        /// <summary>
        /// 是否审核  0-待审核 1已审核（已绑定酷家乐账户）
        /// </summary>
        [DataMember(Name = "IsAxamine")]
        public bool IsAxamine { get; set; }

        /// <summary>
		///创建时间
		/// </summary>
		[DataMember(Name = "EndDate")]
        public DateTime EndDate
        {
            get;
            set;
        }

        /// <summary>
		///会员类型
		/// </summary>
		[DataMember(Name = "MemberClass")]
        public int MemberClass
        {
            get;
            set;
        }
    }
}
