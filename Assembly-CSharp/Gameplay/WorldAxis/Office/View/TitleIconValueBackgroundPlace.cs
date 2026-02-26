using System;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View
{
	// Token: 0x020002E8 RID: 744
	[Token(Token = "0x20002E8")]
	public class TitleIconValueBackgroundPlace : TitleIconValueBackground
	{
		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029B")]
		public TextMeshProUGUI Place
		{
			[Token(Token = "0x60011B7")]
			[Address(RVA = "0x63B4", Offset = "0x63B4", VA = "0x63B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B8")]
		[Address(RVA = "0x63B5", Offset = "0x63B5", VA = "0x63B5")]
		public TitleIconValueBackgroundPlace()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_View_TitleIconValueBackgroundPlace___ctor
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  
		  iVar6 = 0;
		  iVar1 = 0;
		  if (DAT_ram_00a58b8b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_WorldAxisOfficeModel_ColossusClanRating__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IList_WorldAxisOfficeModel_ColossusClanRating__TypeInfo);
		    DAT_ram_00a58b8b = '\x01';
		  }
		  iVar5 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar5 + 0xc)) {
		    do {
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar5 + iVar1 * 4 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,0,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar5 + 0xc));
		  }
		  do {
		    iVar1 = *(int *)(param1 + 0x10);
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_ICollection_WorldAxisOfficeModel_ColossusClanRating__TypeInfo
		            == *piVar7) {
		          puVar3 = (uint *)(iVar5 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80f7ea93;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_WorldAxisOfficeModel_ColossusClanRating__TypeInfo
		                                  ,0);
		code_r0x80f7ea93:
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    iVar1 = *(int *)(iVar1 + 0xc);
		    if (iVar5 <= iVar1) {
		      iVar1 = iVar5;
		    }
		    if (iVar1 <= iVar6) {
		      Gameplay_WorldAxis_Office_View_Schedule_ColossusBattleListElement_ColossusBattleListElementArgs___ctor
		                (*(undefined4 *)(param1 + 0x14),param2,param3,iVar5);
		      return;
		    }
		    iVar1 = *param2;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_IList_WorldAxisOfficeModel_ColossusClanRating__TypeInfo ==
		            *piVar7) {
		          puVar3 = (uint *)(iVar1 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80f7eb1f;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_IList_WorldAxisOfficeModel_ColossusClanRating__TypeInfo
		                                  ,0);
		code_r0x80f7eb1f:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,iVar6,puVar3[1]);
		    Gameplay_WorldAxis_Office_View_Schedule_MyRatingRender___c__DisplayClass3_0___Render_b__0
		              (puVar3,uVar4,*(undefined4 *)(*(int *)(param1 + 0x10) + iVar6 * 4 + 0x10),puVar3);
		    iVar6 = iVar6 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000915")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _place;
	}
}
