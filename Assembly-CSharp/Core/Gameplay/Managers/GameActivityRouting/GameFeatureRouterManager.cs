using System;
using System.Runtime.CompilerServices;
using CloudsFly.Movement;
using Core.Data;
using Gameplay.Discounts.Controller;
using Gameplay.Rating.View;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;
using UI.Windows;

namespace Core.Gameplay.Managers.GameActivityRouting
{
	// Token: 0x020011C4 RID: 4548
	[Token(Token = "0x20011C4")]
	public class GameFeatureRouterManager : IGameManager, IBaseManager
	{
		// Token: 0x140002C9 RID: 713
		// (add) Token: 0x06006C4F RID: 27727 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C50 RID: 27728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C9")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006C4F")]
			[Address(RVA = "0xB73C", Offset = "0xB73C", VA = "0xB73C", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C50")]
			[Address(RVA = "0xB73D", Offset = "0xB73D", VA = "0xB73D", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002CA RID: 714
		// (add) Token: 0x06006C51 RID: 27729 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C52 RID: 27730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002CA")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006C51")]
			[Address(RVA = "0xB73E", Offset = "0xB73E", VA = "0xB73E", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C52")]
			[Address(RVA = "0xB73F", Offset = "0xB73F", VA = "0xB73F", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006C53 RID: 27731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C53")]
		[Address(RVA = "0xB740", Offset = "0xB740", VA = "0xB740", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C54")]
		[Address(RVA = "0xB741", Offset = "0xB741", VA = "0xB741", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06006C55 RID: 27733 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001625")]
		public string Name
		{
			[Token(Token = "0x6006C55")]
			[Address(RVA = "0xB742", Offset = "0xB742", VA = "0xB742", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006C56 RID: 27734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C56")]
		[Address(RVA = "0xB743", Offset = "0xB743", VA = "0xB743")]
		public void ShowBank(OptionTypesDic.Types.OptionType optionType, WindowOpenReasonSource source = WindowOpenReasonSource.DefaultSource)
		{
		}

		// Token: 0x06006C57 RID: 27735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C57")]
		[Address(RVA = "0xB744", Offset = "0xB744", VA = "0xB744")]
		public void ShowBank(Resources resId, WindowOpenReasonSource source = WindowOpenReasonSource.DefaultSource)
		{
		}

		// Token: 0x06006C58 RID: 27736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C58")]
		[Address(RVA = "0xB745", Offset = "0xB745", VA = "0xB745")]
		public void ShowAuchan()
		{
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C59")]
		[Address(RVA = "0xB746", Offset = "0xB746", VA = "0xB746")]
		public void ShowGifts(UserData user)
		{
		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C5A")]
		[Address(RVA = "0xB747", Offset = "0xB747", VA = "0xB747")]
		public void ShowMyShopBuilding(UserData user)
		{
		}

		// Token: 0x06006C5B RID: 27739 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006C5B")]
		[Address(RVA = "0xB748", Offset = "0xB748", VA = "0xB748")]
		public RatingWindow ShowRatingWindow()
		{
			return null;
		}

		// Token: 0x06006C5C RID: 27740 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006C5C")]
		[Address(RVA = "0xB749", Offset = "0xB749", VA = "0xB749")]
		public RatingWindow ShowRatingWindow(RatingWindow.RatingWindowArgs args)
		{
			return null;
		}

		// Token: 0x06006C5D RID: 27741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C5D")]
		[Address(RVA = "0xB74A", Offset = "0xB74A", VA = "0xB74A")]
		public void ShowCraft(uint schemeId = 0U)
		{
		}

		// Token: 0x06006C5E RID: 27742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C5E")]
		[Address(RVA = "0xB74B", Offset = "0xB74B", VA = "0xB74B")]
		public void ShowUserWindow(UserInfoWindow.UserInfoWindowArgs args)
		{
		}

		// Token: 0x06006C5F RID: 27743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C5F")]
		[Address(RVA = "0xB74C", Offset = "0xB74C", VA = "0xB74C")]
		public void ShowDiscountsWindow(DiscountsController controller)
		{
		}

		// Token: 0x06006C60 RID: 27744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C60")]
		[Address(RVA = "0xB74D", Offset = "0xB74D", VA = "0xB74D")]
		public void ShowAccountsListWindow()
		{
		}

		// Token: 0x06006C61 RID: 27745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C61")]
		[Address(RVA = "0xB74E", Offset = "0xB74E", VA = "0xB74E")]
		public void ShowClanSpells(UserData user)
		{
		}

		// Token: 0x06006C62 RID: 27746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C62")]
		[Address(RVA = "0xB74F", Offset = "0xB74F", VA = "0xB74F")]
		private void HandleMoveToClanIsleCompleteEvent(WorldMovementTypes obj)
		{
		}

		// Token: 0x06006C63 RID: 27747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C63")]
		[Address(RVA = "0xB750", Offset = "0xB750", VA = "0xB750")]
		public void ShowClanIsleBuildings(UserData user)
		{
		}

		// Token: 0x06006C64 RID: 27748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C64")]
		[Address(RVA = "0xB751", Offset = "0xB751", VA = "0xB751")]
		public void ShowMarketWindow(uint artikulId = 0U)
		{
		}

		// Token: 0x06006C65 RID: 27749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C65")]
		[Address(RVA = "0xB752", Offset = "0xB752", VA = "0xB752")]
		private void HandleMoveToClanIsleCompleteEvent2(WorldMovementTypes obj)
		{
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C66")]
		[Address(RVA = "0xB753", Offset = "0xB753", VA = "0xB753")]
		public GameFeatureRouterManager()
		{
		}
	}
}
