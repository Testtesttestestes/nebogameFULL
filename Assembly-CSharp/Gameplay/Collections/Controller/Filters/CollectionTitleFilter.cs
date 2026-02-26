using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Collections.Controller.Filters
{
	// Token: 0x020009EC RID: 2540
	[Token(Token = "0x20009EC")]
	public class CollectionTitleFilter : ICollectionFilter
	{
		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06003CAC RID: 15532 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003CAD RID: 15533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF2")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6003CAC")]
			[Address(RVA = "0x8B73", Offset = "0x8B73", VA = "0x8B73", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CAD")]
			[Address(RVA = "0x8B74", Offset = "0x8B74", VA = "0x8B74", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x0000C360 File Offset: 0x0000A560
		[Token(Token = "0x6003CAE")]
		[Address(RVA = "0x8B75", Offset = "0x8B75", VA = "0x8B75", Slot = "6")]
		public bool Filter(CollectionData collectionData)
		{
			return default(bool);
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAF")]
		[Address(RVA = "0x8B76", Offset = "0x8B76", VA = "0x8B76")]
		public CollectionTitleFilter()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Collections_Controller_Filters_CollectionTitleFilter___ctor
		              (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a57eec == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_ClanRestrictionDic___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_ClanRestrictionDic__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_ClanRestrictionDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12528);
		    DAT_ram_00a57eec = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_ClanRestrictionDic__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12528,Method_UI_ToolTip_ToolTipData_ClanRestrictionDic___ctor__
		            );
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(*(int *)(param1 + 0x14) + 8);
		  return param1_00;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		undefined4
		Gameplay_Collections_Controller_Filters_CollectionTitleFilter__set_FilterInfo
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int *param1_00;
		  
		  if (*(char *)(*(int *)(param1 + 8) + 0x10) == '\0') {
		    return 1;
		  }
		  param1_00 = *(int **)(*(int *)(param1 + 8) + 0xc);
		  if ((param1_00 != (int *)0x0) && (DAT_ram_00a66978 != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,DAT_ram_00a66978);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = Core_Data_CollectionData__get_CurrentCollectionRanksDic(param2,0);
		  param2_00 = func_ii_7775(param1_00,0);
		  uVar1 = func_ii_7903(uVar1,param2_00,0);
		  return uVar1;
		}
		*/

}
