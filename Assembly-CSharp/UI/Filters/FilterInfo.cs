using System;
using Il2CppDummyDll;

namespace UI.Filters
{
	// Token: 0x020001DD RID: 477
	[Token(Token = "0x20001DD")]
	public class FilterInfo
	{
		// Token: 0x06000C6E RID: 3182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x5F72", Offset = "0x5F72", VA = "0x5F72")]
		public FilterInfo()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Filters_FilterInfo___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63919 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_AbstractFilterToggleView_ArtikulTypeFilters__Init__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_AbstractFilterToggleView_ArtikulTypeFilters__get_Data__);
		    DAT_ram_00a63919 = '\x01';
		  }
		  UnityEngine_Purchasing_Default_WinProductDescription__set_description
		            (param1,param2,Method_UI_Filters_AbstractFilterToggleView_ArtikulTypeFilters__Init__);
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  param2_00 = Core_Extensions_Dict_ArtikulTypeFilterDicExt__GetIconEnabled
		                        (*(undefined4 *)(param1 + 0x18),0);
		  AssetContent_GameImage__get_AssetId(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x040005FB RID: 1531
		[Token(Token = "0x40005FB")]
		[FieldOffset(Offset = "0x8")]
		public FilterInfo.FilterType Type;

		// Token: 0x040005FC RID: 1532
		[Token(Token = "0x40005FC")]
		[FieldOffset(Offset = "0xC")]
		public object Data;

		// Token: 0x040005FD RID: 1533
		[Token(Token = "0x40005FD")]
		[FieldOffset(Offset = "0x10")]
		public bool Enabled;

		// Token: 0x020001DE RID: 478
		[Token(Token = "0x20001DE")]
		public enum FilterType
		{
			// Token: 0x040005FF RID: 1535
			[Token(Token = "0x40005FF")]
			Skill = 1,
			// Token: 0x04000600 RID: 1536
			[Token(Token = "0x4000600")]
			Other,
			// Token: 0x04000601 RID: 1537
			[Token(Token = "0x4000601")]
			Price,
			// Token: 0x04000602 RID: 1538
			[Token(Token = "0x4000602")]
			Title,
			// Token: 0x04000603 RID: 1539
			[Token(Token = "0x4000603")]
			Achieved,
			// Token: 0x04000604 RID: 1540
			[Token(Token = "0x4000604")]
			Craft
		}
	}
}
