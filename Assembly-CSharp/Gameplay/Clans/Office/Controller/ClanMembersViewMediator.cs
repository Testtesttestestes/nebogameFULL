using System;
using Core.Money;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanMembersTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Rating;
using UI.Elements.RatingElements.SubRatings;
using UI.Windows;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A6A RID: 2666
	[Token(Token = "0x2000A6A")]
	public class ClanMembersViewMediator : AbstractViewMediator<ClanInfoModel, ClanInfoEvents, ClanInfoController, ClanMembersView>, IHideableMediator
	{
		// Token: 0x06003F19 RID: 16153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F19")]
		[Address(RVA = "0x8DD4", Offset = "0x8DD4", VA = "0x8DD4")]
		public ClanMembersViewMediator(ClanInfoModel model, ClanInfoEvents events, ClanInfoController controller)
		{
		}

		// Token: 0x17000C9C RID: 3228
		// (set) Token: 0x06003F1A RID: 16154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9C")]
		public override ClanMembersView View
		{
			[Token(Token = "0x6003F1A")]
			[Address(RVA = "0x8DD5", Offset = "0x8DD5", VA = "0x8DD5", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1B")]
		[Address(RVA = "0x8DD6", Offset = "0x8DD6", VA = "0x8DD6")]
		private void Init()
		{
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1C")]
		[Address(RVA = "0x8DD7", Offset = "0x8DD7", VA = "0x8DD7")]
		private void OpenClanToggleChangedEventHandler(bool enable)
		{
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1D")]
		[Address(RVA = "0x8DD8", Offset = "0x8DD8", VA = "0x8DD8")]
		private void UpdateAddVacancyPrice()
		{
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1E")]
		[Address(RVA = "0x8DD9", Offset = "0x8DD9", VA = "0x8DD9")]
		private void AddVacancyButtonClickedEventHandler()
		{
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1F")]
		[Address(RVA = "0x8DDA", Offset = "0x8DDA", VA = "0x8DDA")]
		private void SetupLeftRightButtons()
		{
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F20")]
		[Address(RVA = "0x8DDB", Offset = "0x8DDB", VA = "0x8DDB")]
		private void AssignLeaderButtonClickedEventHandler()
		{
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F21")]
		[Address(RVA = "0x8DDC", Offset = "0x8DDC", VA = "0x8DDC")]
		private void KickButtonClickedEventHandler()
		{
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F22")]
		[Address(RVA = "0x8DDD", Offset = "0x8DDD", VA = "0x8DDD")]
		private void ToUserIsleButtonClickedEventHandler()
		{
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F23")]
		[Address(RVA = "0x8DDE", Offset = "0x8DDE", VA = "0x8DDE")]
		private void UserInfoButtonClickedEventHandler()
		{
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F24")]
		[Address(RVA = "0x8DDF", Offset = "0x8DDF", VA = "0x8DDF")]
		private void WithdrawButtonClickedEventHandler()
		{
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F25")]
		[Address(RVA = "0x8DE0", Offset = "0x8DE0", VA = "0x8DE0")]
		private void JoinButtonClickedEventHandler()
		{
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F26")]
		[Address(RVA = "0x8DE1", Offset = "0x8DE1", VA = "0x8DE1")]
		private void SubRatingSelectedEventHandler(SubRatingListElementArgs subRating)
		{
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F27")]
		[Address(RVA = "0x8DE2", Offset = "0x8DE2", VA = "0x8DE2")]
		private void FilterSelectedEventHandler(object obj)
		{
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F28")]
		[Address(RVA = "0x8DE3", Offset = "0x8DE3", VA = "0x8DE3")]
		private void RedrawMembersList()
		{
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F29")]
		[Address(RVA = "0x8DE4", Offset = "0x8DE4", VA = "0x8DE4")]
		private void DrawMembersList()
		{
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2A")]
		[Address(RVA = "0x8DE5", Offset = "0x8DE5", VA = "0x8DE5")]
		private void UpdateJoinCost()
		{
		}

		// Token: 0x17000C9D RID: 3229
		// (set) Token: 0x06003F2B RID: 16171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9D")]
		public override ClanInfoEvents Events
		{
			[Token(Token = "0x6003F2B")]
			[Address(RVA = "0x8DE6", Offset = "0x8DE6", VA = "0x8DE6", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2C")]
		[Address(RVA = "0x8DE7", Offset = "0x8DE7", VA = "0x8DE7")]
		private void ClanStateFlagsChangedEventHandler()
		{
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2D")]
		[Address(RVA = "0x8DE8", Offset = "0x8DE8", VA = "0x8DE8")]
		private void VacancyAddedEventHandler()
		{
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2E")]
		[Address(RVA = "0x8DE9", Offset = "0x8DE9", VA = "0x8DE9")]
		private void MembersChangedEventHandler()
		{
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2F")]
		[Address(RVA = "0x8DEA", Offset = "0x8DEA", VA = "0x8DEA")]
		private void JoinRequestCancelledEventHandler()
		{
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F30")]
		[Address(RVA = "0x8DEB", Offset = "0x8DEB", VA = "0x8DEB")]
		private void JoinRequestSentEventHandler()
		{
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F31")]
		[Address(RVA = "0x8DEC", Offset = "0x8DEC", VA = "0x8DEC")]
		private void InitEventHandler()
		{
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F32")]
		[Address(RVA = "0x8DED", Offset = "0x8DED", VA = "0x8DED")]
		private void MembersRequestedEventHandler()
		{
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F33")]
		[Address(RVA = "0x8DEE", Offset = "0x8DEE", VA = "0x8DEE")]
		private void SelectArgs(ClanMemberListElement.ClanMemberListElementArgs args)
		{
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F34")]
		[Address(RVA = "0x8DEF", Offset = "0x8DEF", VA = "0x8DEF")]
		private void DisbandButtonClickedEventHandler()
		{
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F35")]
		[Address(RVA = "0x8DF0", Offset = "0x8DF0", VA = "0x8DF0")]
		private void LeaveButtonClickedEventHandler()
		{
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F36")]
		[Address(RVA = "0x8DF1", Offset = "0x8DF1", VA = "0x8DF1")]
		private void RequestInjectCallbackEventHandler()
		{
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F37")]
		[Address(RVA = "0x8DF2", Offset = "0x8DF2", VA = "0x8DF2")]
		private void MemberButtonClickedEventHandler(ClanMemberListElement element)
		{
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F38")]
		[Address(RVA = "0x8DF3", Offset = "0x8DF3", VA = "0x8DF3")]
		private DialogWindow ShowLeaveConfirmationWindow()
		{
			return null;
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F39")]
		[Address(RVA = "0x8DF4", Offset = "0x8DF4", VA = "0x8DF4")]
		private DialogWindow ShowDisbandConfirmationWindow()
		{
			return null;
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F3A")]
		[Address(RVA = "0x8DF5", Offset = "0x8DF5", VA = "0x8DF5")]
		private DialogWindow ShowBuyPlaceConfirmationWindow(Money price)
		{
			return null;
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F3B")]
		[Address(RVA = "0x8DF6", Offset = "0x8DF6", VA = "0x8DF6", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x04002390 RID: 9104
		[Token(Token = "0x4002390")]
		[FieldOffset(Offset = "0x18")]
		private ClanMemberListElement.ClanMemberListElementArgs _selectedArgs;

		// Token: 0x04002391 RID: 9105
		[Token(Token = "0x4002391")]
		[FieldOffset(Offset = "0x1C")]
		private RatingPeriods _ratingPeriod;

		// Token: 0x04002392 RID: 9106
		[Token(Token = "0x4002392")]
		[FieldOffset(Offset = "0x20")]
		private UserRatingTypes _ratingType;
	}
}
