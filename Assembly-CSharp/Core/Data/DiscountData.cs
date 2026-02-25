using System;
using System.Collections.Generic;
using Core.Gameplay.Managers;
using Core.Gameplay.Managers.GameActivityRouting;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;
using Utils;

namespace Core.Data
{
	// Token: 0x020010BC RID: 4284
	[Token(Token = "0x20010BC")]
	public class DiscountData
	{
		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x060063E2 RID: 25570 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001414")]
		private static GameFeatureRouterManager _routerManager
		{
			[Token(Token = "0x60063E2")]
			[Address(RVA = "0xAFDF", Offset = "0xAFDF", VA = "0xAFDF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x060063E3 RID: 25571 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001415")]
		private static AccountsManager _accountsManager
		{
			[Token(Token = "0x60063E3")]
			[Address(RVA = "0xAFE0", Offset = "0xAFE0", VA = "0xAFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x060063E4 RID: 25572 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001416")]
		private static BankManager _bankManager
		{
			[Token(Token = "0x60063E4")]
			[Address(RVA = "0xAFE1", Offset = "0xAFE1", VA = "0xAFE1")]
			get
			{
				return null;
			}
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E5")]
		[Address(RVA = "0xAFE2", Offset = "0xAFE2", VA = "0xAFE2")]
		private static void TryOpenBuilding(UserBuildingTypes type)
		{
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E6")]
		[Address(RVA = "0xAFE3", Offset = "0xAFE3", VA = "0xAFE3")]
		private DiscountData(float backTime, DiscountsDic dic)
		{
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60063E7")]
		[Address(RVA = "0xAFE4", Offset = "0xAFE4", VA = "0xAFE4")]
		public static DiscountData Create(uint discountId, float backTimer, Dictionaries dict)
		{
			return null;
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E8")]
		[Address(RVA = "0xAFE5", Offset = "0xAFE5", VA = "0xAFE5")]
		private static void ShowFeatureInDevelopmentToast()
		{
		}

		// Token: 0x060063E9 RID: 25577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E9")]
		[Address(RVA = "0xAFE6", Offset = "0xAFE6", VA = "0xAFE6")]
		private static void ShowUserWindow(UserInfoWindow.DependentView dependent = UserInfoWindow.DependentView.NOTHING)
		{
		}

		// Token: 0x04003572 RID: 13682
		[Token(Token = "0x4003572")]
		[FieldOffset(Offset = "0x8")]
		public readonly DiscountsDic Dic;

		// Token: 0x04003573 RID: 13683
		[Token(Token = "0x4003573")]
		[FieldOffset(Offset = "0xC")]
		public readonly Action Action;

		// Token: 0x04003574 RID: 13684
		[Token(Token = "0x4003574")]
		[FieldOffset(Offset = "0x10")]
		public BackTime BackTime;

		// Token: 0x04003575 RID: 13685
		[Token(Token = "0x4003575")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<DiscountTargets, Action> _targetActions;
	}
}
