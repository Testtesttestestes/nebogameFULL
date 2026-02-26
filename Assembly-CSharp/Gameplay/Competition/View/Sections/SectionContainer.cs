using System;
using Gameplay.Competition.Control;
using Gameplay.Competition.Model;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Competition.View.Sections
{
	// Token: 0x020008E1 RID: 2273
	[Token(Token = "0x20008E1")]
	[AddComponentMenu("Competition/View/Sections/SectionContainer")]
	public class SectionContainer : MonoBehaviourWithStates<Sections>
	{
		// Token: 0x0600357A RID: 13690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600357A")]
		[Address(RVA = "0x8588", Offset = "0x8588", VA = "0x8588")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Competition_View_Sections_SectionContainer__Awake
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  uint uVar2;
		  int iVar3;
		  uint *puVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  int *local_4;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a63a8a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_TryGetComponent_ISectionView___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_View_Sections_ISectionView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_Sections__get_Configs__);
		    DAT_ram_00a63a8a = '\x01';
		  }
		  local_4 = (int *)0x0;
		  if (*(char *)(param1 + 0x19) == '\0') {
		    *(undefined1 *)(param1 + 0x19) = 1;
		    iVar5 = *(int *)(param1 + 0x10);
		    if (0 < *(int *)(iVar5 + 0xc)) {
		      do {
		        iVar3 = func_ii_8014(*(undefined4 *)(*(int *)(iVar5 + iVar6 * 4 + 0x10) + 8),&local_4,
		                             Method_UnityEngine_GameObject_TryGetComponent_ISectionView___);
		        piVar1 = local_4;
		        if (iVar3 != 0) {
		          iVar3 = *local_4;
		          if (*(ushort *)(iVar3 + 0xb6) != 0) {
		            uVar2 = 0;
		            do {
		              piVar7 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		              if (Gameplay_Competition_View_Sections_ISectionView_TypeInfo == *piVar7) {
		                puVar4 = (uint *)(iVar3 + piVar7[1] * 8 + 0xc0);
		                goto code_r0x82335e8e;
		              }
		              uVar2 = uVar2 + 1;
		            } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		          }
		          puVar4 = (uint *)func_ii_1080(local_4,
		                                        Gameplay_Competition_View_Sections_ISectionView_TypeInfo,0);
		code_r0x82335e8e:
		          (**(code **)((ulonglong)*puVar4 * 4))(piVar1,param2,puVar4[1]);
		        }
		        iVar6 = iVar6 + 1;
		      } while (iVar6 < *(int *)(iVar5 + 0xc));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600357B RID: 13691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600357B")]
		[Address(RVA = "0x8589", Offset = "0x8589", VA = "0x8589")]
		public void Init(CompetitionController controller)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Competition_View_Sections_SectionContainer__Init(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63a8b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_Sections___ctor__);
		    DAT_ram_00a63a8b = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_Sections___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600357C RID: 13692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600357C")]
		[Address(RVA = "0x858A", Offset = "0x858A", VA = "0x858A")]
		public SectionContainer()
		{
		}

		// Token: 0x04001D41 RID: 7489
		[Token(Token = "0x4001D41")]
		[FieldOffset(Offset = "0x19")]
		private bool _isInit;
	}
}
