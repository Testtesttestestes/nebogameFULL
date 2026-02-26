using System;
using Il2CppDummyDll;

namespace Gameplay.Rating.View
{
	// Token: 0x02000587 RID: 1415
	[Token(Token = "0x2000587")]
	public class UserInCommonRatingListElement : UserRatingListElement
	{
		// Token: 0x060021C5 RID: 8645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C5")]
		[Address(RVA = "0x7324", Offset = "0x7324", VA = "0x7324", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C6")]
		[Address(RVA = "0x7325", Offset = "0x7325", VA = "0x7325")]
		public UserInCommonRatingListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_View_UserInCommonRatingListElement___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  
		  Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView___c__DisplayClass31_0___Remove_b__0
		            (param1,0);
		  if (DAT_ram_00a5803a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserInRatingListElement_UserInRatingListElementArgs__get_args__
		              );
		    DAT_ram_00a5803a = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x18) + 0x28);
		  if ((iVar1 < 1) || (*(int *)(*(int *)(param1 + 0x3c) + 0xc) < iVar1)) {
		    param1_00 = *(undefined4 *)(param1 + 0x38);
		    if (*(char *)(*(int *)(param1 + 0x18) + 0x2c) == '\0') {
		      puVar2 = (undefined4 *)(param1 + 0x40);
		    }
		    else {
		      puVar2 = (undefined4 *)(param1 + 0x44);
		    }
		  }
		  else {
		    puVar2 = (undefined4 *)(iVar1 * 4 + *(int *)(param1 + 0x3c) + 0xc);
		    param1_00 = *(undefined4 *)(param1 + 0x38);
		  }
		  func_ii_7050(param1_00,*puVar2,0);
		  return;
		}
		*/

		}
	}
}
