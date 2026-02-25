using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers;
using Core.GameTime;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Dic;
using Protocol.Services;

namespace Gameplay.EndlessPaymentOptionsList.Model
{
	// Token: 0x02000847 RID: 2119
	[Token(Token = "0x2000847")]
	public class EndlessPaymentOptionsListModel : AbstractModel
	{
		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060031CB RID: 12747 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009D4")]
		public Dictionaries Dict
		{
			[Token(Token = "0x60031CB")]
			[Address(RVA = "0x8222", Offset = "0x8222", VA = "0x8222")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x0000A200 File Offset: 0x00008400
		// (set) Token: 0x060031CD RID: 12749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D5")]
		public bool RequestedShowList
		{
			[Token(Token = "0x60031CC")]
			[Address(RVA = "0x8223", Offset = "0x8223", VA = "0x8223")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60031CD")]
			[Address(RVA = "0x8224", Offset = "0x8224", VA = "0x8224")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x0000A218 File Offset: 0x00008418
		// (set) Token: 0x060031CF RID: 12751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D6")]
		public bool IsAwaiteShowDiscountOffer
		{
			[Token(Token = "0x60031CE")]
			[Address(RVA = "0x8225", Offset = "0x8225", VA = "0x8225")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60031CF")]
			[Address(RVA = "0x8226", Offset = "0x8226", VA = "0x8226")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x0000A230 File Offset: 0x00008430
		// (set) Token: 0x060031D1 RID: 12753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D7")]
		public int EntryPointShownCount
		{
			[Token(Token = "0x60031D0")]
			[Address(RVA = "0x8227", Offset = "0x8227", VA = "0x8227")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60031D1")]
			[Address(RVA = "0x8228", Offset = "0x8228", VA = "0x8228")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060031D3 RID: 12755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D8")]
		public PopupScheduleManager.Args EndlessOptionsPopupScheduleArgs
		{
			[Token(Token = "0x60031D2")]
			[Address(RVA = "0x8229", Offset = "0x8229", VA = "0x8229")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031D3")]
			[Address(RVA = "0x822A", Offset = "0x822A", VA = "0x822A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x060031D4 RID: 12756 RVA: 0x0000A248 File Offset: 0x00008448
		// (set) Token: 0x060031D5 RID: 12757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D9")]
		public bool IsDiscountEnabled
		{
			[Token(Token = "0x60031D4")]
			[Address(RVA = "0x822B", Offset = "0x822B", VA = "0x822B")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60031D5")]
			[Address(RVA = "0x822C", Offset = "0x822C", VA = "0x822C")]
			set
			{
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x060031D6 RID: 12758 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009DA")]
		[CanBeNull]
		public EndlessPaymentOptionListData LastList
		{
			[Token(Token = "0x60031D6")]
			[Address(RVA = "0x822D", Offset = "0x822D", VA = "0x822D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x060031D7 RID: 12759 RVA: 0x0000A260 File Offset: 0x00008460
		[Token(Token = "0x170009DB")]
		public bool IsAvail
		{
			[Token(Token = "0x60031D7")]
			[Address(RVA = "0x822E", Offset = "0x822E", VA = "0x822E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x060031D8 RID: 12760 RVA: 0x0000A278 File Offset: 0x00008478
		[Token(Token = "0x170009DC")]
		public bool IsFree
		{
			[Token(Token = "0x60031D8")]
			[Address(RVA = "0x822F", Offset = "0x822F", VA = "0x822F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x060031D9 RID: 12761 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009DD")]
		public List<CardData> AllCards
		{
			[Token(Token = "0x60031D9")]
			[Address(RVA = "0x8230", Offset = "0x8230", VA = "0x8230")]
			get
			{
				return null;
			}
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031DA")]
		[Address(RVA = "0x8231", Offset = "0x8231", VA = "0x8231")]
		public EndlessPaymentOptionsListModel(int multipleLobbyVisitForEntryPointWidget, int minDisplayOptionCount, IGame game, ICurrentTimeProvider currentTimeProvider, IDictProvider dictProvider, BankManager bank, UserData user)
		{
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031DB")]
		[Address(RVA = "0x8232", Offset = "0x8232", VA = "0x8232")]
		private void HandleIsDiscountEnabledChanged()
		{
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x0000A290 File Offset: 0x00008490
		[Token(Token = "0x60031DC")]
		[Address(RVA = "0x1B0A", Offset = "0x1B0A", VA = "0x1B0A")]
		private bool TryConstructCard(EndlessPaymentOptionListData list, ProtoGetEndlessPaymentOptionsAns.Types.EndlessPaymentOptionInfo info, bool isLock, out CardData result)
		{
			return default(bool);
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031DD")]
		[Address(RVA = "0x8233", Offset = "0x8233", VA = "0x8233")]
		private void UpdateCards(ProtoGetEndlessPaymentOptionsAns optionInfos)
		{
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031DE")]
		[Address(RVA = "0x8234", Offset = "0x8234", VA = "0x8234")]
		private void CreateCards(ProtoGetEndlessPaymentOptionsAns optionInfos)
		{
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031DF")]
		[Address(RVA = "0x8235", Offset = "0x8235", VA = "0x8235")]
		public void SetInfo(ProtoGetEndlessPaymentOptionsAns optionInfos)
		{
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031E0")]
		[Address(RVA = "0x8236", Offset = "0x8236", VA = "0x8236")]
		public void ReLink()
		{
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60031E1")]
		[Address(RVA = "0x8237", Offset = "0x8237", VA = "0x8237")]
		public List<CardData> GetCards()
		{
			return null;
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60031E2")]
		[Address(RVA = "0x8238", Offset = "0x8238", VA = "0x8238")]
		public List<CardData> GetCardForDisplay()
		{
			return null;
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x0000A2A8 File Offset: 0x000084A8
		[Token(Token = "0x60031E3")]
		[Address(RVA = "0x8239", Offset = "0x8239", VA = "0x8239")]
		public bool TryGetCurrentList(out EndlessPaymentOptionListData result)
		{
			return default(bool);
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x0000A2C0 File Offset: 0x000084C0
		[Token(Token = "0x60031E4")]
		[Address(RVA = "0x823A", Offset = "0x823A", VA = "0x823A")]
		public bool TryGetCard(BankOptionData option, out CardData result)
		{
			return default(bool);
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031E5")]
		[Address(RVA = "0x823B", Offset = "0x823B", VA = "0x823B")]
		public void ResetList()
		{
		}

		// Token: 0x04001B50 RID: 6992
		[Token(Token = "0x4001B50")]
		[FieldOffset(Offset = "0xC")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04001B51 RID: 6993
		[Token(Token = "0x4001B51")]
		[FieldOffset(Offset = "0x10")]
		public readonly IGame Game;

		// Token: 0x04001B52 RID: 6994
		[Token(Token = "0x4001B52")]
		[FieldOffset(Offset = "0x14")]
		public readonly BankManager Bank;

		// Token: 0x04001B53 RID: 6995
		[Token(Token = "0x4001B53")]
		[FieldOffset(Offset = "0x18")]
		public readonly int MultipleLobbyVisitForEntryPointWidget;

		// Token: 0x04001B54 RID: 6996
		[Token(Token = "0x4001B54")]
		[FieldOffset(Offset = "0x1C")]
		private readonly ICurrentTimeProvider _currentTimeProvider;

		// Token: 0x04001B55 RID: 6997
		[Token(Token = "0x4001B55")]
		[FieldOffset(Offset = "0x20")]
		private readonly int _minDisplayOptionCount;

		// Token: 0x04001B56 RID: 6998
		[Token(Token = "0x4001B56")]
		[FieldOffset(Offset = "0x24")]
		private readonly List<CardData> _cards;

		// Token: 0x04001B57 RID: 6999
		[Token(Token = "0x4001B57")]
		[FieldOffset(Offset = "0x28")]
		private EndlessPaymentOptionListData _currentList;

		// Token: 0x04001B58 RID: 7000
		[Token(Token = "0x4001B58")]
		[FieldOffset(Offset = "0x2C")]
		private bool _isDiscountEnabled;

		// Token: 0x04001B59 RID: 7001
		[Token(Token = "0x4001B59")]
		[FieldOffset(Offset = "0x30")]
		private ProtoGetEndlessPaymentOptionsAns _optionInfos;
	}
}
