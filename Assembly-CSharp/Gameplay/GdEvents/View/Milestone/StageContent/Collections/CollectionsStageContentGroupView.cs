using System;
using Core.Data;
using Gameplay.Collections.View;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Collections
{
	// Token: 0x0200072E RID: 1838
	[Token(Token = "0x200072E")]
	public class CollectionsStageContentGroupView : AbstractStageContentGroupView<CollectionData>
	{
		// Token: 0x06002BE6 RID: 11238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE6")]
		[Address(RVA = "0x7C77", Offset = "0x7C77", VA = "0x7C77")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Collections_CollectionsStageContentGroupView__OnDestroy
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param2_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a5a286 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_CollectionData__get_Content__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_Collections_CollectionsStageContentGroupView_HandleItemClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_AddComponent_MonoPointerClickHandler___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_CollectionView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a286 = '\x01';
		  }
		  if ((param3 != 0) && (iVar1 = *(int *)(param3 + 8), 0 < *(int *)(iVar1 + 0xc))) {
		    do {
		      param2_00 = *(int *)(iVar1 + iVar4 * 4 + 0x10);
		      uVar2 = *(undefined4 *)(param1 + 0x14);
		      uVar3 = *(undefined4 *)(param1 + 0x1c);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      uVar2 = func_ii_6805(uVar3,uVar2,Method_UnityEngine_Object_Instantiate_CollectionView___);
		      Gameplay_Collections_View_CollectionView__set_IgnoreAchieved
		                (uVar2,param2_00,*(undefined4 *)(*(int *)(param3 + 0x10) + 0x1c),
		                 *(undefined4 *)(param2_00 + 0x1c),0);
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar2,0);
		      uVar2 = UnityEngine_GameObject__GetComponent_object_
		                        (uVar2,Method_UnityEngine_GameObject_AddComponent_MonoPointerClickHandler___
		                        );
		      uVar3 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_GdEvents_View_Milestone_StageContent_Collections_CollectionsStageContentGroupView_HandleItemClickEvent__
		                 ,0);
		      Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(uVar2,uVar3,0);
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar1 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE7")]
		[Address(RVA = "0x7C78", Offset = "0x7C78", VA = "0x7C78", Slot = "4")]
		protected override void HandleDataChanged(StageContentData<CollectionData> fromData, StageContentData<CollectionData> toData)
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Collections_CollectionsStageContentGroupView__HandleDataChanged
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *param1_01;
		  int local_4;
		  
		  if (DAT_ram_00a5a287 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_CollectionData__get_Data__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_TryGetComponent_CollectionView___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Model_Milestone_StageContentData_CollectionData__get_InteractiveMode__
		              );
		    DAT_ram_00a5a287 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = Gameplay_GdEvents_Model_Milestone_StageContentData___Il2CppFullySharedGenericType____ctor
		                    (*(undefined4 *)(param1 + 0x18),
		                     Method_Gameplay_GdEvents_Model_Milestone_StageContentData_CollectionData__get_InteractiveMode__
		                    );
		  if ((iVar2 != 2) &&
		     (iVar2 = func_ii_8014(*(undefined4 *)(param2 + 0x24),&local_4,
		                           Method_UnityEngine_GameObject_TryGetComponent_CollectionView___),
		     iVar2 != 0)) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x280);
		          goto code_r0x811f30c7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x38);
		code_r0x811f30c7:
		    param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		    param2_00 = System_Linq_Enumerable__FirstOrDefault_uint_(*(undefined4 *)(local_4 + 0x20),0);
		    Core_Gameplay_Managers_CollectionsManager__ShowCollectionsWindow
		              (param1_00,param2_00,*(undefined4 *)(*(int *)(local_4 + 0x20) + 0x1c),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE8")]
		[Address(RVA = "0x7C79", Offset = "0x7C79", VA = "0x7C79")]
		private void HandleItemClickEvent(PointerEventData pointerData)
		{
		/* --- GHIDRA: HandleItemClickEvent ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Collections_CollectionsStageContentGroupView__HandleItemClickEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a288 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_CollectionData___ctor__
		              );
		    DAT_ram_00a5a288 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,
		             Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_CollectionData___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE9")]
		[Address(RVA = "0x7C7A", Offset = "0x7C7A", VA = "0x7C7A")]
		public CollectionsStageContentGroupView()
		{
		}

		// Token: 0x0400180B RID: 6155
		[Token(Token = "0x400180B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CollectionView _collectionPrefb;
	}
}
