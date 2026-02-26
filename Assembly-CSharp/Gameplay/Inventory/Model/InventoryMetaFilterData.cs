using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.Model
{
	// Token: 0x020006A4 RID: 1700
	[Token(Token = "0x20006A4")]
	public class InventoryMetaFilterData
	{
		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600292D RID: 10541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D3")]
		public ArtikulTypeMetaFilterDic MetaFilterDic
		{
			[Token(Token = "0x600292C")]
			[Address(RVA = "0x7A38", Offset = "0x7A38", VA = "0x7A38")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600292D")]
			[Address(RVA = "0x7A39", Offset = "0x7A39", VA = "0x7A39")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x00007CE0 File Offset: 0x00005EE0
		[Token(Token = "0x170007D4")]
		public uint FilterId
		{
			[Token(Token = "0x600292E")]
			[Address(RVA = "0x1F1C", Offset = "0x1F1C", VA = "0x1F1C")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x0600292F RID: 10543 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007D5")]
		public string Title
		{
			[Token(Token = "0x600292F")]
			[Address(RVA = "0x1F1D", Offset = "0x1F1D", VA = "0x1F1D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x00007CF8 File Offset: 0x00005EF8
		[Token(Token = "0x170007D6")]
		public uint SortOrder
		{
			[Token(Token = "0x6002930")]
			[Address(RVA = "0x1CC7", Offset = "0x1CC7", VA = "0x1CC7")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06002931 RID: 10545 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002932 RID: 10546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D7")]
		public List<ArtikulTypeFilters> ArtikulTypeFilters
		{
			[Token(Token = "0x6002931")]
			[Address(RVA = "0x7A3A", Offset = "0x7A3A", VA = "0x7A3A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002932")]
			[Address(RVA = "0x7A3B", Offset = "0x7A3B", VA = "0x7A3B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002933")]
		[Address(RVA = "0x7A3C", Offset = "0x7A3C", VA = "0x7A3C")]
		private InventoryMetaFilterData(ArtikulTypeMetaFilterDic metaFilterDic)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_Model_InventoryMetaFilterData___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8)
		
		{
		  Gameplay_Inventory_Model_InventoryBaseModel__get_TotalSlotsAvailable
		            (param1,param3,param4,param5,param6,param7,param1);
		  *(undefined4 *)(param1 + 0x58) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06002934 RID: 10548 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002934")]
		[Address(RVA = "0x1F19", Offset = "0x1F19", VA = "0x1F19")]
		public static InventoryMetaFilterData Create(ArtikulTypeMetaFilterDic metaFilterDic, Dictionaries dictionaries)
		{
		/* --- GHIDRA: Create ---
		int * Gameplay_Inventory_Model_InventoryMetaFilterData__Create(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x040016EF RID: 5871
		[Token(Token = "0x40016EF")]
		[FieldOffset(Offset = "0x10")]
		public List<uint> AllArtikulTypes;

		// Token: 0x040016F0 RID: 5872
		[Token(Token = "0x40016F0")]
		[FieldOffset(Offset = "0x14")]
		public Dictionary<uint, ArtikulTypeFilters> ArtikulFilterById;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_FilterId ---
		undefined4
		Gameplay_Inventory_Model_InventoryMetaFilterData__get_FilterId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_ArtikulTypeMenuActionDicExt__GetRequirementMessage
		                    (*(undefined4 *)(param1 + 8),0);
		  return uVar1;
		}
		*/

}
