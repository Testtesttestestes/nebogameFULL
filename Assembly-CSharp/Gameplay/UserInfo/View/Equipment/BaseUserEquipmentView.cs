using System;
using Il2CppDummyDll;

namespace Gameplay.UserInfo.View.Equipment
{
	// Token: 0x0200040E RID: 1038
	[Token(Token = "0x200040E")]
	public class BaseUserEquipmentView : BaseEquipmentView<UserEquipmentSlotConfig>
	{
		// Token: 0x06001861 RID: 6241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001861")]
		[Address(RVA = "0x6A01", Offset = "0x6A01", VA = "0x6A01")]
		public BaseUserEquipmentView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInfo_View_Equipment_BaseUserEquipmentView___ctor
		               (int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  iVar3 = *(int *)(param1 + 0x1c);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    iVar1 = 0;
		    do {
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar3 + iVar1 * 4 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,param2,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  iVar3 = *(int *)(param1 + 0x20);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    iVar1 = 0;
		    do {
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar3 + iVar1 * 4 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,param2 ^ 1,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

		}
	}
}
