using System;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Auchan;
using Protocol.Portal;
using Protocol.Themeduel;

namespace Protocol
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	public static class ActionInfoAdapter
	{
		// Token: 0x060006FE RID: 1790 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x5AFB", Offset = "0x5AFB", VA = "0x5AFB")]
		public static IActionInfo Create(Protocol.Auchan.ActionInfo actionInfo)
		{
		/* --- GHIDRA: Create ---
		int Protocol_ActionInfoAdapter__Create(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5b814 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_ActionInfoAdapter_PortalAdapter_TypeInfo);
		    DAT_ram_00a5b814 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_ActionInfoAdapter_PortalAdapter_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param1;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: Create ---
		int Protocol_ActionInfoAdapter__Create(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5b814 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_ActionInfoAdapter_PortalAdapter_TypeInfo);
		    DAT_ram_00a5b814 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_ActionInfoAdapter_PortalAdapter_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param1;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: Create ---
		int Protocol_ActionInfoAdapter__Create(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5b814 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_ActionInfoAdapter_PortalAdapter_TypeInfo);
		    DAT_ram_00a5b814 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_ActionInfoAdapter_PortalAdapter_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param1;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x5AFC", Offset = "0x5AFC", VA = "0x5AFC")]
		public static IActionInfo Create(Protocol.Themeduel.ActionInfo actionInfo)
		{
			return null;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x5AFD", Offset = "0x5AFD", VA = "0x5AFD")]
		public static IActionInfo Create(Protocol.Portal.ActionInfo actionInfo)
		{
			return null;
		}

		// Token: 0x020000B6 RID: 182
		[Token(Token = "0x20000B6")]
		private class AuchanAdapter : IActionInfo
		{
			// Token: 0x06000701 RID: 1793 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x5AFE", Offset = "0x5AFE", VA = "0x5AFE")]
			public AuchanAdapter(Protocol.Auchan.ActionInfo actionInfo)
			{
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000702 RID: 1794 RVA: 0x000031B0 File Offset: 0x000013B0
			[Token(Token = "0x170000B7")]
			public bool MarketAccount
			{
				[Token(Token = "0x6000702")]
				[Address(RVA = "0x5AFF", Offset = "0x5AFF", VA = "0x5AFF", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x06000703 RID: 1795 RVA: 0x000031C8 File Offset: 0x000013C8
			// (set) Token: 0x06000704 RID: 1796 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000B8")]
			public uint Quantity
			{
				[Token(Token = "0x6000703")]
				[Address(RVA = "0x5B00", Offset = "0x5B00", VA = "0x5B00", Slot = "5")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x6000704")]
				[Address(RVA = "0x5B01", Offset = "0x5B01", VA = "0x5B01", Slot = "6")]
				set
				{
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x06000705 RID: 1797 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170000B9")]
			public Money NormalPrice
			{
				[Token(Token = "0x6000705")]
				[Address(RVA = "0x5B02", Offset = "0x5B02", VA = "0x5B02", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x06000706 RID: 1798 RVA: 0x000031E0 File Offset: 0x000013E0
			[Token(Token = "0x170000BA")]
			public int State
			{
				[Token(Token = "0x6000706")]
				[Address(RVA = "0x5B03", Offset = "0x5B03", VA = "0x5B03", Slot = "8")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04000256 RID: 598
			[Token(Token = "0x4000256")]
			[FieldOffset(Offset = "0x8")]
			private readonly Protocol.Auchan.ActionInfo _actionInfo;
		}

		// Token: 0x020000B7 RID: 183
		[Token(Token = "0x20000B7")]
		private class ThemeDuelAdapter : IActionInfo
		{
			// Token: 0x06000707 RID: 1799 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x5B04", Offset = "0x5B04", VA = "0x5B04")]
			public ThemeDuelAdapter(Protocol.Themeduel.ActionInfo actionInfo)
			{
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x06000708 RID: 1800 RVA: 0x000031F8 File Offset: 0x000013F8
			[Token(Token = "0x170000BB")]
			public bool MarketAccount
			{
				[Token(Token = "0x6000708")]
				[Address(RVA = "0x5B05", Offset = "0x5B05", VA = "0x5B05", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x06000709 RID: 1801 RVA: 0x00003210 File Offset: 0x00001410
			// (set) Token: 0x0600070A RID: 1802 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000BC")]
			public uint Quantity
			{
				[Token(Token = "0x6000709")]
				[Address(RVA = "0x5B06", Offset = "0x5B06", VA = "0x5B06", Slot = "5")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x600070A")]
				[Address(RVA = "0x5B07", Offset = "0x5B07", VA = "0x5B07", Slot = "6")]
				set
				{
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x0600070B RID: 1803 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170000BD")]
			public Money NormalPrice
			{
				[Token(Token = "0x600070B")]
				[Address(RVA = "0x5B08", Offset = "0x5B08", VA = "0x5B08", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x0600070C RID: 1804 RVA: 0x00003228 File Offset: 0x00001428
			[Token(Token = "0x170000BE")]
			public int State
			{
				[Token(Token = "0x600070C")]
				[Address(RVA = "0x5B09", Offset = "0x5B09", VA = "0x5B09", Slot = "8")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04000257 RID: 599
			[Token(Token = "0x4000257")]
			[FieldOffset(Offset = "0x8")]
			private readonly Protocol.Themeduel.ActionInfo _actionInfo;
		}

		// Token: 0x020000B8 RID: 184
		[Token(Token = "0x20000B8")]
		private class PortalAdapter : IActionInfo
		{
			// Token: 0x0600070D RID: 1805 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x5B0A", Offset = "0x5B0A", VA = "0x5B0A")]
			public PortalAdapter(Protocol.Portal.ActionInfo actionInfo)
			{
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x0600070E RID: 1806 RVA: 0x00003240 File Offset: 0x00001440
			[Token(Token = "0x170000BF")]
			public bool MarketAccount
			{
				[Token(Token = "0x600070E")]
				[Address(RVA = "0x5B0B", Offset = "0x5B0B", VA = "0x5B0B", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x0600070F RID: 1807 RVA: 0x00003258 File Offset: 0x00001458
			// (set) Token: 0x06000710 RID: 1808 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000C0")]
			public uint Quantity
			{
				[Token(Token = "0x600070F")]
				[Address(RVA = "0x5B0C", Offset = "0x5B0C", VA = "0x5B0C", Slot = "5")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x6000710")]
				[Address(RVA = "0x5B0D", Offset = "0x5B0D", VA = "0x5B0D", Slot = "6")]
				set
				{
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x06000711 RID: 1809 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170000C1")]
			public Money NormalPrice
			{
				[Token(Token = "0x6000711")]
				[Address(RVA = "0x5B0E", Offset = "0x5B0E", VA = "0x5B0E", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x06000712 RID: 1810 RVA: 0x00003270 File Offset: 0x00001470
			[Token(Token = "0x170000C2")]
			public int State
			{
				[Token(Token = "0x6000712")]
				[Address(RVA = "0x5B0F", Offset = "0x5B0F", VA = "0x5B0F", Slot = "8")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04000258 RID: 600
			[Token(Token = "0x4000258")]
			[FieldOffset(Offset = "0x8")]
			private readonly Protocol.Portal.ActionInfo _actionInfo;
		}
	}
}
