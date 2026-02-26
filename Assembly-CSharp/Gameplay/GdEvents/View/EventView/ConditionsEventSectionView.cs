using System;
using Core.MVC.Interfaces;
using Gameplay.GdEvents.Control;
using Il2CppDummyDll;
using TMPro;
using UI.Requirements;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.GdEvents.View.EventView
{
	// Token: 0x02000743 RID: 1859
	[Token(Token = "0x2000743")]
	public class ConditionsEventSectionView : AbstractEventSectionView
	{
		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000867")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6002C45")]
			[Address(RVA = "0x7CD4", Offset = "0x7CD4", VA = "0x7CD4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06002C46 RID: 11334 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000868")]
		public GameObject PlaceholderText
		{
			[Token(Token = "0x6002C46")]
			[Address(RVA = "0x7CD5", Offset = "0x7CD5", VA = "0x7CD5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06002C47 RID: 11335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000869")]
		public Transform RewardsOwner
		{
			[Token(Token = "0x6002C47")]
			[Address(RVA = "0x7CD6", Offset = "0x7CD6", VA = "0x7CD6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06002C48 RID: 11336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700086A")]
		public RewardsRender Rewards
		{
			[Token(Token = "0x6002C48")]
			[Address(RVA = "0x7CD7", Offset = "0x7CD7", VA = "0x7CD7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700086B")]
		public RequirementsView Requirements
		{
			[Token(Token = "0x6002C49")]
			[Address(RVA = "0x7CD8", Offset = "0x7CD8", VA = "0x7CD8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C4A")]
		[Address(RVA = "0x7CD9", Offset = "0x7CD9", VA = "0x7CD9", Slot = "5")]
		protected override void CreateMediator(ref IViewMediator mediator, GdEventsController controller)
		{
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C4B")]
		[Address(RVA = "0x7CDA", Offset = "0x7CDA", VA = "0x7CDA")]
		public ConditionsEventSectionView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_View_EventView_ConditionsEventSectionView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int local_4;
		  
		  if (DAT_ram_00a5a2b7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_TryGetComponent_AbstractEventSectionView___);
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_EventViewState__get_Configs__);
		    DAT_ram_00a5a2b7 = '\x01';
		  }
		  local_4 = 0;
		  if (*(char *)(param1 + 0x19) == '\0') {
		    *(undefined1 *)(param1 + 0x19) = 1;
		    iVar3 = *(int *)(param1 + 0x10);
		    if (0 < *(int *)(iVar3 + 0xc)) {
		      iVar1 = 0;
		      do {
		        iVar2 = func_ii_8014(*(undefined4 *)(*(int *)(iVar3 + iVar1 * 4 + 0x10) + 8),&local_4,
		                             Method_UnityEngine_GameObject_TryGetComponent_AbstractEventSectionView___
		                            );
		        if ((iVar2 != 0) && (*(char *)(local_4 + 0x14) == '\0')) {
		          *(undefined1 *)(local_4 + 0x14) = 1;
		          *(undefined4 *)(local_4 + 0x18) = param2;
		        }
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar3 + 0xc));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x04001844 RID: 6212
		[Token(Token = "0x4001844")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001845 RID: 6213
		[Token(Token = "0x4001845")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _placeholderTest;

		// Token: 0x04001846 RID: 6214
		[Token(Token = "0x4001846")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _rewardsOwner;

		// Token: 0x04001847 RID: 6215
		[Token(Token = "0x4001847")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RewardsRender _rewards;

		// Token: 0x04001848 RID: 6216
		[Token(Token = "0x4001848")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RequirementsView _requirements;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Requirements ---
		void Gameplay_GdEvents_View_EventView_ConditionsEventSectionView__get_Requirements
		               (undefined4 param1,undefined4 *param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *param1_00;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a2b6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5a2b6 = '\x01';
		  }
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x100) * 4))
		                        (param3,*(undefined4 *)(*param3 + 0x104));
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x110) * 4))
		                        (param3,*(undefined4 *)(*param3 + 0x114));
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator_TypeInfo
		                               );
		  Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass9_0___AprsButtonClickedEventHandler_b__1
		            (param1_00,param2_00,param3_00,param3,0);
		  *param2 = param1_00;
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		        goto code_r0x811f58f9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,8);
		code_r0x811f58f9:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1,puVar2[1]);
		  return;
		}
		*/

}
