using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.RegisterV2.View.GenderSelector
{
	// Token: 0x02000564 RID: 1380
	[Token(Token = "0x2000564")]
	public class GenderSelector : MonoBehaviour
	{
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x00006A50 File Offset: 0x00004C50
		[Token(Token = "0x17000618")]
		public int SelectedIndex
		{
			[Token(Token = "0x600214A")]
			[Address(RVA = "0x72AC", Offset = "0x72AC", VA = "0x72AC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214B")]
		[Address(RVA = "0x72AD", Offset = "0x72AD", VA = "0x72AD")]
		public void Init(IList<GenderListElement.GenderListElementArgs> args)
		{
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214C")]
		[Address(RVA = "0x72AE", Offset = "0x72AE", VA = "0x72AE")]
		public GenderSelector()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_RegisterV2_View_GenderSelector_GenderSelector___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5837b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_RegisterV2_View_GenderSelector_GenderSelector___c_TypeInfo);
		    DAT_ram_00a5837b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_RegisterV2_View_GenderSelector_GenderSelector___c_TypeInfo)
		  ;
		  **(undefined4 **)(Gameplay_RegisterV2_View_GenderSelector_GenderSelector___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001230 RID: 4656
		[Token(Token = "0x4001230")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GenderListElement[] _genders;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SelectedIndex ---
		void Gameplay_RegisterV2_View_GenderSelector_GenderSelector__get_SelectedIndex
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a5837a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_GenderListElement_GenderListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_GenderListElement_GenderListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IList_GenderListElement_GenderListElementArgs__TypeInfo);
		    DAT_ram_00a5837a = '\x01';
		  }
		  do {
		    iVar4 = *param2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_GenderListElement_GenderListElementArgs__TypeInfo
		            == *piVar5) {
		          puVar2 = (uint *)(iVar4 + piVar5[1] * 8 + 0xc0);
		          goto code_r0x80ed7ece;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_GenderListElement_GenderListElementArgs__TypeInfo
		                                  ,0);
		code_r0x80ed7ece:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if (iVar4 <= iVar3) {
		      return;
		    }
		    iVar4 = *param2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_GenderListElement_GenderListElementArgs__TypeInfo ==
		            *piVar5) {
		          puVar2 = (uint *)(iVar4 + piVar5[1] * 8 + 0xc0);
		          goto code_r0x80ed7f4d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_IList_GenderListElement_GenderListElementArgs__TypeInfo
		                                  ,0);
		code_r0x80ed7f4d:
		    param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,iVar3,puVar2[1]);
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (*(undefined4 *)(*(int *)(param1 + 0x10) + iVar3 * 4 + 0x10),param2_00,
		               Method_UI_Elements_GenericList_GenericListElement_GenderListElement_GenderListElementArgs__Init__
		              );
		    iVar3 = iVar3 + 1;
		  } while( true );
		}
		*/

}
