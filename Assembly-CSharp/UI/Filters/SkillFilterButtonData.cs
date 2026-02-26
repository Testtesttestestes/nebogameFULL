using System;
using Core.Data.Skills;
using Gameplay.Medals.View;
using Il2CppDummyDll;

namespace UI.Filters
{
	// Token: 0x020001E2 RID: 482
	[Token(Token = "0x20001E2")]
	[Serializable]
	public class SkillFilterButtonData
	{
		// Token: 0x06000C86 RID: 3206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x5F8A", Offset = "0x5F8A", VA = "0x5F8A")]
		public SkillFilterButtonData()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Filters_SkillFilterButtonData___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63929 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Filters_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters___Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Filters_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters___get_Data__
		              );
		    DAT_ram_00a63929 = '\x01';
		  }
		  UnityEngine_Purchasing_Default_WinProductDescription__set_description
		            (param1,param2,
		             Method_UI_Filters_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters___Init__
		            );
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  param2_00 = Core_Extensions_Dict_ArtikulTypeMetaFilterDicExt__GetIconEnabled
		                        (*(undefined4 *)(*(int *)(param1 + 0x18) + 8),0);
		  AssetContent_GameImage__get_AssetId(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		[FieldOffset(Offset = "0x8")]
		public UserSkillsIndexes SkillIndex;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0xC")]
		public FilterButton Button;
	}
}
