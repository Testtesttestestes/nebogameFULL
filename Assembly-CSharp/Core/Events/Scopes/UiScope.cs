using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using UI.Tabs;
using UI.ToolTip;
using UI.Windows;

namespace Core.Events.Scopes
{
	// Token: 0x02001036 RID: 4150
	[Token(Token = "0x2001036")]
	public class UiScope : AbstractEventBusScope
	{
		// Token: 0x060061E3 RID: 25059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061E3")]
		[Address(RVA = "0xAE0E", Offset = "0xAE0E", VA = "0xAE0E", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060061E4 RID: 25060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061E4")]
		[Address(RVA = "0xAE0F", Offset = "0xAE0F", VA = "0xAE0F")]
		public UiScope()
		{
		}

		// Token: 0x040034B1 RID: 13489
		[Token(Token = "0x40034B1")]
		[FieldOffset(Offset = "0x8")]
		public Action<UiScope.WindowOpenedEventArgs> WindowOpenedEvent;

		// Token: 0x040034B2 RID: 13490
		[Token(Token = "0x40034B2")]
		[FieldOffset(Offset = "0xC")]
		public Action<UiScope.WindowClosedEventArgs> WindowClosedEvent;

		// Token: 0x040034B3 RID: 13491
		[Token(Token = "0x40034B3")]
		[FieldOffset(Offset = "0x10")]
		public Action<UiScope.ToolTipShownEventArgs> ToolTipShownEvent;

		// Token: 0x040034B4 RID: 13492
		[Token(Token = "0x40034B4")]
		[FieldOffset(Offset = "0x14")]
		public Action<UiScope.FxActivatedEventArgs> FxActivatedEvent;

		// Token: 0x040034B5 RID: 13493
		[Token(Token = "0x40034B5")]
		[FieldOffset(Offset = "0x18")]
		public Action<UiScope.OfferSelectionChangedArgs> OfferSelectionChangedEvent;

		// Token: 0x040034B6 RID: 13494
		[Token(Token = "0x40034B6")]
		[FieldOffset(Offset = "0x1C")]
		public Action<UiScope.BankTabChangedArgs> BankTabChangedEvent;

		// Token: 0x02001037 RID: 4151
		[Token(Token = "0x2001037")]
		public class WindowOpenedEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700139C RID: 5020
			// (get) Token: 0x060061E5 RID: 25061 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700139C")]
			public string WindowId
			{
				[Token(Token = "0x60061E5")]
				[Address(RVA = "0xAE10", Offset = "0xAE10", VA = "0xAE10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700139D RID: 5021
			// (get) Token: 0x060061E6 RID: 25062 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700139D")]
			public BaseWindowArgs WindowArgs
			{
				[Token(Token = "0x60061E6")]
				[Address(RVA = "0xAE11", Offset = "0xAE11", VA = "0xAE11")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060061E7 RID: 25063 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061E7")]
			[Address(RVA = "0xAE12", Offset = "0xAE12", VA = "0xAE12")]
			public WindowOpenedEventArgs(App app, IGame game, string windowId, BaseWindowArgs windowArgs)
			{
			}
		}

		// Token: 0x02001038 RID: 4152
		[Token(Token = "0x2001038")]
		public class WindowClosedEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700139E RID: 5022
			// (get) Token: 0x060061E8 RID: 25064 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700139E")]
			public string WindowId
			{
				[Token(Token = "0x60061E8")]
				[Address(RVA = "0xAE13", Offset = "0xAE13", VA = "0xAE13")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700139F RID: 5023
			// (get) Token: 0x060061E9 RID: 25065 RVA: 0x000122B8 File Offset: 0x000104B8
			[Token(Token = "0x1700139F")]
			public WindowCloseReason WindowCloseReason
			{
				[Token(Token = "0x60061E9")]
				[Address(RVA = "0xAE14", Offset = "0xAE14", VA = "0xAE14")]
				[CompilerGenerated]
				get
				{
					return WindowCloseReason.unknown;
				}
			}

			// Token: 0x060061EA RID: 25066 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061EA")]
			[Address(RVA = "0xAE15", Offset = "0xAE15", VA = "0xAE15")]
			public WindowClosedEventArgs(App app, IGame game, string windowId, WindowCloseReason windowCloseReason)
			{
			}
		}

		// Token: 0x02001039 RID: 4153
		[Token(Token = "0x2001039")]
		public class ToolTipShownEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x170013A0 RID: 5024
			// (get) Token: 0x060061EB RID: 25067 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170013A0")]
			public IToolTipSource ToolTipSource
			{
				[Token(Token = "0x60061EB")]
				[Address(RVA = "0xAE16", Offset = "0xAE16", VA = "0xAE16")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060061EC RID: 25068 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061EC")]
			[Address(RVA = "0xAE17", Offset = "0xAE17", VA = "0xAE17")]
			public ToolTipShownEventArgs(App app, IGame game, IToolTipSource toolTipSource)
			{
			}
		}

		// Token: 0x0200103A RID: 4154
		[Token(Token = "0x200103A")]
		public class FxActivatedEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x170013A1 RID: 5025
			// (get) Token: 0x060061ED RID: 25069 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170013A1")]
			public string FxName
			{
				[Token(Token = "0x60061ED")]
				[Address(RVA = "0xAE18", Offset = "0xAE18", VA = "0xAE18")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170013A2 RID: 5026
			// (get) Token: 0x060061EE RID: 25070 RVA: 0x000122D0 File Offset: 0x000104D0
			[Token(Token = "0x170013A2")]
			public bool LongTapped
			{
				[Token(Token = "0x60061EE")]
				[Address(RVA = "0xAE19", Offset = "0xAE19", VA = "0xAE19")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060061EF RID: 25071 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061EF")]
			[Address(RVA = "0xAE1A", Offset = "0xAE1A", VA = "0xAE1A")]
			public FxActivatedEventArgs(App app, IGame game, string fxName, bool longTapped)
			{
			}
		}

		// Token: 0x0200103B RID: 4155
		[Token(Token = "0x200103B")]
		public class OfferSelectionChangedArgs : BaseEventBusEventArgs
		{
			// Token: 0x170013A3 RID: 5027
			// (get) Token: 0x060061F0 RID: 25072 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170013A3")]
			public BankOptionData BankOptionData
			{
				[Token(Token = "0x60061F0")]
				[Address(RVA = "0xAE1B", Offset = "0xAE1B", VA = "0xAE1B")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060061F1 RID: 25073 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061F1")]
			[Address(RVA = "0xAE1C", Offset = "0xAE1C", VA = "0xAE1C")]
			public OfferSelectionChangedArgs(IApp app, IGame game, BankOptionData bankOptionData)
			{
			}
		}

		// Token: 0x0200103C RID: 4156
		[Token(Token = "0x200103C")]
		public class BankTabChangedArgs : BaseEventBusEventArgs
		{
			// Token: 0x170013A4 RID: 5028
			// (get) Token: 0x060061F2 RID: 25074 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170013A4")]
			public TabBarItemData<BankTabData> TabBarItemData
			{
				[Token(Token = "0x60061F2")]
				[Address(RVA = "0xAE1D", Offset = "0xAE1D", VA = "0xAE1D")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060061F3 RID: 25075 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061F3")]
			[Address(RVA = "0xAE1E", Offset = "0xAE1E", VA = "0xAE1E")]
			public BankTabChangedArgs(IApp app, IGame game, TabBarItemData<BankTabData> tabBarItemData)
			{
			}
		}
	}
}
