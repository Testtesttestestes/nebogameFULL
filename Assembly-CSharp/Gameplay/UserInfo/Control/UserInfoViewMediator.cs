using System;
using Gameplay.UserInfo.Model;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UI;
using UnityEngine.EventSystems;

namespace Gameplay.UserInfo.Control
{
	// Token: 0x0200041D RID: 1053
	[Token(Token = "0x200041D")]
	public class UserInfoViewMediator : AbstractCozyViewMediator<UserInfoModel, UserInfoEvents, UserInfoController, UserInfoView>
	{
		// Token: 0x060018C9 RID: 6345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C9")]
		[Address(RVA = "0x6A68", Offset = "0x6A68", VA = "0x6A68")]
		public UserInfoViewMediator(UserInfoView view, UserInfoModel model, UserInfoEvents events, UserInfoController controller)
		{
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018CA")]
		[Address(RVA = "0x6A69", Offset = "0x6A69", VA = "0x6A69", Slot = "21")]
		protected override void ResetEvents(UserInfoEvents events)
		{
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018CB")]
		[Address(RVA = "0x6A6A", Offset = "0x6A6A", VA = "0x6A6A", Slot = "22")]
		protected override void SetupEvents(UserInfoEvents events)
		{
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018CC")]
		[Address(RVA = "0x6A6B", Offset = "0x6A6B", VA = "0x6A6B", Slot = "23")]
		protected override void ResetView(UserInfoView view)
		{
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018CD")]
		[Address(RVA = "0x6A6C", Offset = "0x6A6C", VA = "0x6A6C", Slot = "24")]
		protected override void SetupView(UserInfoView view)
		{
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018CE")]
		[Address(RVA = "0x6A6D", Offset = "0x6A6D", VA = "0x6A6D")]
		private void UserBasicRequestedEventHandler()
		{
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018CF")]
		[Address(RVA = "0x6A6E", Offset = "0x6A6E", VA = "0x6A6E")]
		private void UserAprChangedEvent()
		{
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D0")]
		[Address(RVA = "0x6A6F", Offset = "0x6A6F", VA = "0x6A6F")]
		private void HandleEditeButtonClickEvent()
		{
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D1")]
		[Address(RVA = "0x6A70", Offset = "0x6A70", VA = "0x6A70")]
		private void HandleRatingButtonClickEvent()
		{
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D2")]
		[Address(RVA = "0x6A71", Offset = "0x6A71", VA = "0x6A71")]
		private void HandleInfoButtonClickEvent()
		{
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D3")]
		[Address(RVA = "0x6A72", Offset = "0x6A72", VA = "0x6A72")]
		private void ShowInfoBox(BaseInfoBox box)
		{
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D4")]
		[Address(RVA = "0x6A73", Offset = "0x6A73", VA = "0x6A73")]
		private void HandleMedalButtonClickEvent(IndexButtonBasic button)
		{
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D5")]
		[Address(RVA = "0x6A74", Offset = "0x6A74", VA = "0x6A74")]
		private void HandleCollectionsButtonClickEvent(IndexButtonBasic button)
		{
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D6")]
		[Address(RVA = "0x6A75", Offset = "0x6A75", VA = "0x6A75")]
		private void HandleAntiqClickEvent(IndexButtonBasic obj)
		{
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D7")]
		[Address(RVA = "0x6A76", Offset = "0x6A76", VA = "0x6A76")]
		private void HandleAddToFriendsButtonClickEvent(object sender, PointerEventData eventData)
		{
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x6A77", Offset = "0x6A77", VA = "0x6A77")]
		private void HandleAprsButtonClickEvent(IndexButtonBasic button)
		{
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D9")]
		[Address(RVA = "0x6A78", Offset = "0x6A78", VA = "0x6A78")]
		private void HandleChatBanButtonClickEvent()
		{
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DA")]
		[Address(RVA = "0x6A79", Offset = "0x6A79", VA = "0x6A79")]
		private void HandleDuelButtonClickEvent()
		{
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DB")]
		[Address(RVA = "0x6A7A", Offset = "0x6A7A", VA = "0x6A7A")]
		private void HandleUserCultGenderChangedEvent()
		{
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DC")]
		[Address(RVA = "0x6A7B", Offset = "0x6A7B", VA = "0x6A7B")]
		private void HandleUserSkillsChangedEvent()
		{
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x6A7C", Offset = "0x6A7C", VA = "0x6A7C")]
		private void HandleInitEvent()
		{
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x6A7D", Offset = "0x6A7D", VA = "0x6A7D")]
		private void HandleUserNickChangedEvent()
		{
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x6A7E", Offset = "0x6A7E", VA = "0x6A7E")]
		private void SetCurrentAvatar()
		{
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x6A7F", Offset = "0x6A7F", VA = "0x6A7F")]
		private void SetAvatar(string assetId)
		{
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x6A80", Offset = "0x6A80", VA = "0x6A80")]
		private void SetNick(string nick)
		{
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E2")]
		[Address(RVA = "0x6A81", Offset = "0x6A81", VA = "0x6A81")]
		private void SetCult(CultDic cultDic)
		{
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E3")]
		[Address(RVA = "0x6A82", Offset = "0x6A82", VA = "0x6A82")]
		private void HandleHideElements()
		{
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E4")]
		[Address(RVA = "0x6A83", Offset = "0x6A83", VA = "0x6A83")]
		private void ShowEditeWindow()
		{
		}
	}
}
