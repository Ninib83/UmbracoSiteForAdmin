//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Zbu.ModelsBuilder v2.1.5.54
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Zbu.ModelsBuilder;
using Zbu.ModelsBuilder.Umbraco;

namespace UnderlakareCmsDialogue.Models
{
	/// <summary>Dialogue Member</summary>
	[PublishedContentModel("DialogueMember")]
	public partial class DialogueMember : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "DialogueMember";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public DialogueMember(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<DialogueMember, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		///Avatar
		///</summary>
		[ImplementPropertyType("avatar")]
		public object Avatar
		{
			get { return this.GetPropertyValue("avatar"); }
		}

		///<summary>
		///Can Edit Other Members
		///Enable this and the user can edit other members posts, their profiles and ban members (Usually use in conjunction with moderate permissions).
		///</summary>
		[ImplementPropertyType("canEditOtherMembers")]
		public bool CanEditOtherMembers
		{
			get { return this.GetPropertyValue<bool>("canEditOtherMembers"); }
		}

		///<summary>
		///Disable Email Notifications
		///</summary>
		[ImplementPropertyType("disableEmailNotifications")]
		public bool DisableEmailNotifications
		{
			get { return this.GetPropertyValue<bool>("disableEmailNotifications"); }
		}

		///<summary>
		///Disable File Uploads
		///</summary>
		[ImplementPropertyType("disableFileUploads")]
		public bool DisableFileUploads
		{
			get { return this.GetPropertyValue<bool>("disableFileUploads"); }
		}

		///<summary>
		///Disable Posting
		///</summary>
		[ImplementPropertyType("disablePosting")]
		public bool DisablePosting
		{
			get { return this.GetPropertyValue<bool>("disablePosting"); }
		}

		///<summary>
		///Disable Private Messages
		///</summary>
		[ImplementPropertyType("disablePrivateMessages")]
		public bool DisablePrivateMessages
		{
			get { return this.GetPropertyValue<bool>("disablePrivateMessages"); }
		}

		///<summary>
		///Email
		///This is a bit rubbish, but it's the only way to get the email from the new member service at the current time
		///</summary>
		[ImplementPropertyType("email")]
		public string Email
		{
			get { return this.GetPropertyValue<string>("email"); }
		}

		///<summary>
		///Facebook Access Token
		///</summary>
		[ImplementPropertyType("facebookAccessToken")]
		public string FacebookAccessToken
		{
			get { return this.GetPropertyValue<string>("facebookAccessToken"); }
		}

		///<summary>
		///Facebook Id
		///</summary>
		[ImplementPropertyType("facebookId")]
		public string FacebookId
		{
			get { return this.GetPropertyValue<string>("facebookId"); }
		}

		///<summary>
		///Google Access Token
		///</summary>
		[ImplementPropertyType("googleAccessToken")]
		public string GoogleAccessToken
		{
			get { return this.GetPropertyValue<string>("googleAccessToken"); }
		}

		///<summary>
		///Google Id
		///</summary>
		[ImplementPropertyType("googleId")]
		public string GoogleId
		{
			get { return this.GetPropertyValue<string>("googleId"); }
		}

		///<summary>
		///Last Active Date
		///</summary>
		[ImplementPropertyType("lastActiveDate")]
		public DateTime LastActiveDate
		{
			get { return this.GetPropertyValue<DateTime>("lastActiveDate"); }
		}

		///<summary>
		///Post Count
		///The users post count. This is kept like this to help reduce SQL queries and improve performance of the forum
		///</summary>
		[ImplementPropertyType("postCount")]
		public int PostCount
		{
			get { return this.GetPropertyValue<int>("postCount"); }
		}

		///<summary>
		///Signature
		///</summary>
		[ImplementPropertyType("signature")]
		public string Signature
		{
			get { return this.GetPropertyValue<string>("signature"); }
		}

		///<summary>
		///Slug
		///This is what we use to look up the member in the front end
		///</summary>
		[ImplementPropertyType("slug")]
		public string Slug
		{
			get { return this.GetPropertyValue<string>("slug"); }
		}

		///<summary>
		///Twitter
		///</summary>
		[ImplementPropertyType("twitter")]
		public string Twitter
		{
			get { return this.GetPropertyValue<string>("twitter"); }
		}

		///<summary>
		///Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		///Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		///Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		///Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		///Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		///Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		///Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		///Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		///Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}

		///<summary>
		///Website
		///</summary>
		[ImplementPropertyType("website")]
		public string Website
		{
			get { return this.GetPropertyValue<string>("website"); }
		}
	}
}