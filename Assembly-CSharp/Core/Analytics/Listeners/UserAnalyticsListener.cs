using System;
using System.Collections.Generic;
using Core.Data;
using Core.Events.Scopes;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012E6 RID: 4838
	[Token(Token = "0x20012E6")]
	public class UserAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x0600731C RID: 29468 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001748")]
		protected override string Theme
		{
			[Token(Token = "0x600731C")]
			[Address(RVA = "0xBD25", Offset = "0xBD25", VA = "0xBD25", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600731D RID: 29469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600731D")]
		[Address(RVA = "0xBD26", Offset = "0xBD26", VA = "0xBD26", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x0600731E RID: 29470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600731E")]
		[Address(RVA = "0xBD27", Offset = "0xBD27", VA = "0xBD27", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x0600731F RID: 29471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600731F")]
		[Address(RVA = "0xBD28", Offset = "0xBD28", VA = "0xBD28")]
		private void UserClanUpdatedEventHandler(UserScope.BaseUserEventArgs e)
		{
		}

		// Token: 0x06007320 RID: 29472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007320")]
		[Address(RVA = "0xBD29", Offset = "0xBD29", VA = "0xBD29")]
		private void BuyTreeLicenceSuccessEvent(UserScope.BaseUserEventArgs e)
		{
		}

		// Token: 0x06007321 RID: 29473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007321")]
		[Address(RVA = "0xBD2A", Offset = "0xBD2A", VA = "0xBD2A")]
		private void TreeLicenceCountChangedEvent(UserScope.BaseUserEventArgs obj)
		{
		}

		// Token: 0x06007322 RID: 29474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007322")]
		[Address(RVA = "0xBD2B", Offset = "0xBD2B", VA = "0xBD2B")]
		private void SetTreeLicenceCount(UserData userData)
		{
		}

		// Token: 0x06007323 RID: 29475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007323")]
		[Address(RVA = "0xBD2C", Offset = "0xBD2C", VA = "0xBD2C")]
		private void AccountsChangedEvent(UserScope.BaseUserEventArgs e)
		{
		}

		// Token: 0x06007324 RID: 29476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007324")]
		[Address(RVA = "0xBD2D", Offset = "0xBD2D", VA = "0xBD2D")]
		private void ExpChangedEvent(UserScope.BaseUserEventArgs e)
		{
		}

		// Token: 0x06007325 RID: 29477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007325")]
		[Address(RVA = "0xBD2E", Offset = "0xBD2E", VA = "0xBD2E")]
		private void SkillsChangedEvent(UserScope.BaseUserEventArgs e)
		{
		}

		// Token: 0x06007326 RID: 29478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007326")]
		[Address(RVA = "0xBD2F", Offset = "0xBD2F", VA = "0xBD2F")]
		private void LevelChangedEvent(UserScope.BaseUserEventArgs e)
		{
		}

		// Token: 0x06007327 RID: 29479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007327")]
		[Address(RVA = "0xBD30", Offset = "0xBD30", VA = "0xBD30")]
		private void GenderChangedEvent(UserScope.BaseUserEventArgs e)
		{
		}

		// Token: 0x06007328 RID: 29480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007328")]
		[Address(RVA = "0xBD31", Offset = "0xBD31", VA = "0xBD31")]
		private void CultChangedEvent(UserScope.BaseUserEventArgs e)
		{
		}

		// Token: 0x06007329 RID: 29481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007329")]
		[Address(RVA = "0xBD32", Offset = "0xBD32", VA = "0xBD32")]
		private void AprChangedEvent(UserScope.BaseUserEventArgs e)
		{
		}

		// Token: 0x0600732A RID: 29482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600732A")]
		[Address(RVA = "0xBD33", Offset = "0xBD33", VA = "0xBD33")]
		private void NickChangedEvent(UserScope.BaseUserEventArgs e)
		{
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600732B")]
		[Address(RVA = "0xBD34", Offset = "0xBD34", VA = "0xBD34")]
		private void TriggersChangedEvent(UserScope.BaseUserEventArgs e)
		{
		}

		// Token: 0x0600732C RID: 29484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600732C")]
		[Address(RVA = "0xBD35", Offset = "0xBD35", VA = "0xBD35")]
		private void SetTriggerProperties(UserData userData, Dictionaries dictionaries)
		{
		}

		// Token: 0x0600732D RID: 29485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600732D")]
		[Address(RVA = "0xBD36", Offset = "0xBD36", VA = "0xBD36")]
		private void UserDataInitializedEvent(UserScope.BaseUserEventArgs e)
		{
		}

		// Token: 0x0600732E RID: 29486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600732E")]
		[Address(RVA = "0xBD37", Offset = "0xBD37", VA = "0xBD37")]
		private void SetAccounts(UserData userData)
		{
		}

		// Token: 0x0600732F RID: 29487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600732F")]
		[Address(RVA = "0xBD38", Offset = "0xBD38", VA = "0xBD38")]
		private void SetRefData(UserData userData)
		{
		}

		// Token: 0x06007330 RID: 29488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007330")]
		[Address(RVA = "0xBD39", Offset = "0xBD39", VA = "0xBD39")]
		private void SetSkills(UserData userData)
		{
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007331")]
		[Address(RVA = "0xBD3A", Offset = "0xBD3A", VA = "0xBD3A")]
		private void SetLevel(UserData userData)
		{
		}

		// Token: 0x06007332 RID: 29490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007332")]
		[Address(RVA = "0xBD3B", Offset = "0xBD3B", VA = "0xBD3B")]
		private void SetExp(UserData userData)
		{
		}

		// Token: 0x06007333 RID: 29491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007333")]
		[Address(RVA = "0xBD3C", Offset = "0xBD3C", VA = "0xBD3C")]
		private void SetCult(UserData userData)
		{
		}

		// Token: 0x06007334 RID: 29492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007334")]
		[Address(RVA = "0xBD3D", Offset = "0xBD3D", VA = "0xBD3D")]
		private void SetApr(UserData userData)
		{
		}

		// Token: 0x06007335 RID: 29493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007335")]
		[Address(RVA = "0xBD3E", Offset = "0xBD3E", VA = "0xBD3E")]
		private void SetGender(UserData userData)
		{
		}

		// Token: 0x06007336 RID: 29494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007336")]
		[Address(RVA = "0xBD3F", Offset = "0xBD3F", VA = "0xBD3F")]
		private void SetNick(UserData userData)
		{
		}

		// Token: 0x06007337 RID: 29495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007337")]
		[Address(RVA = "0xBD40", Offset = "0xBD40", VA = "0xBD40")]
		private void SetRank(UserData userData)
		{
		}

		// Token: 0x06007338 RID: 29496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007338")]
		[Address(RVA = "0xBD41", Offset = "0xBD41", VA = "0xBD41")]
		private void SetClan(UserData userData)
		{
		}

		// Token: 0x06007339 RID: 29497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007339")]
		[Address(RVA = "0xBD42", Offset = "0xBD42", VA = "0xBD42")]
		private void BalanceChangedEvent(UserScope.BaseUserEventArgs e)
		{
		}

		// Token: 0x0600733A RID: 29498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600733A")]
		[Address(RVA = "0xBD43", Offset = "0xBD43", VA = "0xBD43")]
		private void SetBalanceProperties(UserData userData)
		{
		}

		// Token: 0x0600733B RID: 29499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600733B")]
		[Address(RVA = "0xBD44", Offset = "0xBD44", VA = "0xBD44")]
		public UserAnalyticsListener()
		{
		}

		// Token: 0x04003C50 RID: 15440
		[Token(Token = "0x4003C50")]
		private const string NICK_CHANGED = "nick_changed";

		// Token: 0x04003C51 RID: 15441
		[Token(Token = "0x4003C51")]
		public const string LEVEL_CHANGED = "level_changed";

		// Token: 0x04003C52 RID: 15442
		[Token(Token = "0x4003C52")]
		private const string BUY_TREE_LICENCE = "buy_tree_licence";

		// Token: 0x04003C53 RID: 15443
		[Token(Token = "0x4003C53")]
		[FieldOffset(Offset = "0x10")]
		private List<TriggerDic> _loggableTriggers;
	}
}
