using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x02000739 RID: 1849
	[Token(Token = "0x2000739")]
	public class CategoryModel
	{
		// Token: 0x06002C1E RID: 11294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C1E")]
		[Address(RVA = "0x7CAE", Offset = "0x7CAE", VA = "0x7CAE")]
		public CategoryModel()
		{
		/* --- GHIDRA: .ctor ---
		void Com_TheFallenGames_OSA_Demos_GridWithCategories_CategoryModel___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a541b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Com_TheFallenGames_OSA_Demos_Common_DemosUtil_TypeInfo);
		    DAT_ram_00a541b7 = '\x01';
		  }
		  if (*(int *)(Com_TheFallenGames_OSA_Demos_Common_DemosUtil_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Com_TheFallenGames_OSA_Demos_Common_DemosUtil_TypeInfo);
		  }
		  Com_TheFallenGames_OSA_Demos_Common_DemosUtil__GetRandomSmallImageURL(&local_10,1,0);
		  *(undefined8 *)(param1 + 0x18) = local_8;
		  *(undefined8 *)(param1 + 0x10) = local_10;
		  return;
		}
		*/

		}

		// Token: 0x04001829 RID: 6185
		[Token(Token = "0x4001829")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x0400182A RID: 6186
		[Token(Token = "0x400182A")]
		[FieldOffset(Offset = "0xC")]
		public List<CellModel> items;
	}
}
