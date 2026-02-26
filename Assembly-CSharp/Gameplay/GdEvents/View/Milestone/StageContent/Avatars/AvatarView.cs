using System;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Avatars
{
	// Token: 0x0200072F RID: 1839
	[Token(Token = "0x200072F")]
	public class AvatarView : MonoBehaviour
	{
		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06002BEA RID: 11242 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700085B")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6002BEA")]
			[Address(RVA = "0x7C7B", Offset = "0x7C7B", VA = "0x7C7B")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06002BEB RID: 11243 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700085C")]
		public AprView Apr
		{
			[Token(Token = "0x6002BEB")]
			[Address(RVA = "0x7C7C", Offset = "0x7C7C", VA = "0x7C7C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BEC")]
		[Address(RVA = "0x7C7D", Offset = "0x7C7D", VA = "0x7C7D")]
		public AvatarView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Avatars_AvatarView___ctor
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a5a289 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_AprDicWrapper__get_Content__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_ToolTip___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_AvatarView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Model_Milestone_StageContentData_AprDicWrapper__get_InteractiveMode__
		              );
		    DAT_ram_00a5a289 = '\x01';
		  }
		  if ((param3 != 0) && (iVar2 = *(int *)(param3 + 8), 0 < *(int *)(iVar2 + 0xc))) {
		    do {
		      uVar3 = *(undefined4 *)(iVar2 + iVar7 * 4 + 0x10);
		      uVar4 = *(undefined4 *)(param1 + 0x14);
		      param1_00 = *(undefined4 *)(param1 + 0x1c);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar1 = func_ii_6805(param1_00,uVar4,Method_UnityEngine_Object_Instantiate_AvatarView___);
		      iVar5 = *(int *)(iVar1 + 0x14);
		      uVar4 = Gameplay_GdEvents_Model_Milestone_StageContentData___Il2CppFullySharedGenericType____ctor
		                        (param3,
		                         Method_Gameplay_GdEvents_Model_Milestone_StageContentData_AprDicWrapper__get_InteractiveMode__
		                        );
		      *(undefined4 *)(iVar5 + 0x58) = uVar4;
		      iVar5 = **(int **)(iVar1 + 0x14);
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0x138) * 4))
		                (*(int **)(iVar1 + 0x14),uVar3,*(undefined4 *)(iVar5 + 0x13c));
		      iVar5 = Gameplay_Aprs_View_AprView__OnPointerExit(*(undefined4 *)(iVar1 + 0x14),0);
		      uVar3 = func_ii_5677(*(undefined4 *)(iVar1 + 0x14),
		                           Method_UnityEngine_Component_GetComponent_ToolTip___);
		      UI_ToolTip_ToolTip__get_enabled(uVar3,(uint)(iVar5 != 0),0);
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,(uint)(iVar5 != 0),0);
		      if (iVar5 != 0) {
		        piVar6 = *(int **)(iVar1 + 0x10);
		        uVar3 = Gameplay_Aprs_Model_AprData__set_SaleMarkersDic(iVar5,0);
		        iVar1 = *piVar6;
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		                  (piVar6,uVar3,*(undefined4 *)(iVar1 + 0x2d4));
		      }
		      iVar7 = iVar7 + 1;
		    } while (iVar7 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0400180C RID: 6156
		[Token(Token = "0x400180C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400180D RID: 6157
		[Token(Token = "0x400180D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private AprView _apr;
	}
}
