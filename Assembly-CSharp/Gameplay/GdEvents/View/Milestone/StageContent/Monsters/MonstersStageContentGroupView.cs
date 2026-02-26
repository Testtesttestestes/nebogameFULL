using System;
using Core.Data;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Monsters
{
	// Token: 0x02000729 RID: 1833
	[Token(Token = "0x2000729")]
	public class MonstersStageContentGroupView : AbstractStageContentGroupView<MonsterData>
	{
		// Token: 0x06002BD1 RID: 11217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD1")]
		[Address(RVA = "0x7C62", Offset = "0x7C62", VA = "0x7C62")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonstersStageContentGroupView__OnDestroy
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  int param1_00;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  int iVar9;
		  
		  iVar9 = 0;
		  if (DAT_ram_00a5a27a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_MonsterData__get_Content__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_MonsterData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonstersStageContentGroupView_HandleClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_MonsterView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a27a = '\x01';
		  }
		  if ((param3 != 0) && (iVar4 = *(int *)(param3 + 8), 0 < *(int *)(iVar4 + 0xc))) {
		    do {
		      iVar5 = *(int *)(iVar4 + iVar9 * 4 + 0x10);
		      uVar6 = *(undefined4 *)(param1 + 0x14);
		      uVar7 = *(undefined4 *)(param1 + 0x1c);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar3 = func_ii_6805(uVar7,uVar6,Method_UnityEngine_Object_Instantiate_MonsterView___);
		      if ((*(int *)(iVar3 + 0x20) != iVar5) && (*(int *)(iVar3 + 0x20) = iVar5, iVar5 != 0)) {
		        piVar8 = *(int **)(iVar3 + 0x10);
		        uVar6 = Core_Data_MonsterData__get_KickPrice(iVar5,0);
		        iVar5 = *piVar8;
		        (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		                  (piVar8,uVar6,*(undefined4 *)(iVar5 + 0x2d4));
		        uVar7 = *(undefined4 *)(iVar3 + 0x14);
		        uVar6 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl
		                          (*(undefined4 *)(iVar3 + 0x20),0);
		        UI_Elements_Counters_CounterAutoHide___ctor(uVar7,uVar6,0);
		        iVar5 = **(int **)(iVar3 + 0x18);
		        (**(code **)((ulonglong)*(uint *)(iVar5 + 0x138) * 4))
		                  (*(int **)(iVar3 + 0x18),*(undefined4 *)(*(int *)(iVar3 + 0x20) + 0xc),
		                   *(undefined4 *)(iVar5 + 0x13c));
		      }
		      uVar6 = unnamed_function_1417(System_Action_MonsterData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar6,param1,
		                 Method_Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonstersStageContentGroupView_HandleClickEvent__
		                 ,0);
		      if (DAT_ram_00a5a275 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_MonsterData__TypeInfo);
		        DAT_ram_00a5a275 = '\x01';
		      }
		      iVar5 = *(int *)(iVar3 + 0x1c);
		      do {
		        iVar2 = 0;
		        param1_00 = UnityEngine_UI_Image__set_sprite(iVar5,uVar6,0);
		        uVar7 = System_Action_MonsterData__TypeInfo;
		        if ((param1_00 != 0) &&
		           (iVar2 = func_ii_1082(param1_00,System_Action_MonsterData__TypeInfo), iVar2 == 0)) {
		          System_Activator__CreateInstance(param1_00,uVar7);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar2 = func_ii_4329(iVar3 + 0x1c,iVar2,iVar5);
		        bVar1 = iVar2 != iVar5;
		        iVar5 = iVar2;
		      } while (bVar1);
		      iVar9 = iVar9 + 1;
		    } while (iVar9 < *(int *)(iVar4 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD2")]
		[Address(RVA = "0x7C63", Offset = "0x7C63", VA = "0x7C63", Slot = "4")]
		protected override void HandleDataChanged(StageContentData<MonsterData> fromData, StageContentData<MonsterData> toData)
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonstersStageContentGroupView__HandleDataChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a27b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_MonsterData__get_Data__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterInfoWindow_MonsterInfoWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_MonsterInfoWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Model_Milestone_StageContentData_MonsterData__get_InteractiveMode__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_12623);
		    DAT_ram_00a5a27b = '\x01';
		  }
		  iVar2 = Gameplay_GdEvents_Model_Milestone_StageContentData___Il2CppFullySharedGenericType____ctor
		                    (*(undefined4 *)(param1 + 0x18),
		                     Method_Gameplay_GdEvents_Model_Milestone_StageContentData_MonsterData__get_InteractiveMode__
		                    );
		  if (iVar2 != 2) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		          goto code_r0x811f1b64;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x811f1b64:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    uVar1 = 0;
		    iVar2 = *piVar4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe8);
		          goto code_r0x811f1be6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x811f1be6:
		    param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    uVar5 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xc);
		    iVar2 = unnamed_function_1417
		                      (
		                      Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterInfoWindow_MonsterInfoWindowArgs_TypeInfo
		                      );
		    UI_Windows_BaseWindowArgs__Dispose(iVar2,0);
		    *(undefined4 *)(iVar2 + 0x18) = param2;
		    *(undefined4 *)(iVar2 + 0x1c) = uVar5;
		    Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		              (param1_00,StringLiteral_12623,iVar2,
		               Method_UI_Windows_PopupController_Show_MonsterInfoWindow___);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD3")]
		[Address(RVA = "0x7C64", Offset = "0x7C64", VA = "0x7C64")]
		private void HandleClickEvent(MonsterData data)
		{
		/* --- GHIDRA: HandleClickEvent ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonstersStageContentGroupView__HandleClickEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a27c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_MonsterData___ctor__
		              );
		    DAT_ram_00a5a27c = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,
		             Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_MonsterData___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD4")]
		[Address(RVA = "0x7C65", Offset = "0x7C65", VA = "0x7C65")]
		public MonstersStageContentGroupView()
		{
		}

		// Token: 0x04001802 RID: 6146
		[Token(Token = "0x4001802")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private MonsterView _monsterPrefab;
	}
}
