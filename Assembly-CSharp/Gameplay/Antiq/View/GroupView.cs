using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Antiq.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Antiq.View
{
	// Token: 0x02000D87 RID: 3463
	[Token(Token = "0x2000D87")]
	internal class GroupView : AbstractDataRenderer<GroupData>, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x14000201 RID: 513
		// (add) Token: 0x060054BD RID: 21693 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060054BE RID: 21694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000201")]
		public event Action<GroupData> ClickEvent
		{
			[Token(Token = "0x60054BD")]
			[Address(RVA = "0xA269", Offset = "0xA269", VA = "0xA269")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60054BE")]
			[Address(RVA = "0xA26A", Offset = "0xA26A", VA = "0xA26A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060054BF RID: 21695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054BF")]
		[Address(RVA = "0xA26B", Offset = "0xA26B", VA = "0xA26B", Slot = "8")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Antiq_View_GroupView__OnDestroy(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  float param2_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5948c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Transform__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Antiq_View_GroupView__HandleDataChanged_b__8_0__);
		    Mono_Security_ASN1__get_Item(&Method_Sirenix_Utilities_LinqExtensions_ForEach_Transform___);
		    DAT_ram_00a5948c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar1 != 0) {
		    iVar4 = param1[9];
		    param2_00 = 0.0;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    iVar1 = Gameplay_Antiq_Model_GroupData__GetLevel(uVar2,0);
		    if (iVar1 == 0) {
		      param2_00 = 1.0;
		    }
		    AssetContent_GameAssetViewRawImage__TryGetCurrentContent(iVar4,param2_00,0);
		    iVar4 = param1[9];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar2 = Core_Extensions_Dict_Antiq_ArtifactGroupsDicExt__GetImageAssetId
		                      (*(undefined4 *)(iVar1 + 0xc),0);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(iVar4,uVar2,0);
		    iVar1 = param1[0xc];
		    uVar2 = unnamed_function_1417(System_Action_Transform__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Gameplay_Antiq_View_GroupView__HandleDataChanged_b__8_0__,0);
		    Sirenix_Utilities_LinqExtensions__FilterCast___Il2CppFullySharedGenericType_
		              (iVar1,uVar2,Method_Sirenix_Utilities_LinqExtensions_ForEach_Transform___);
		    piVar5 = (int *)param1[10];
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    local_8 = Gameplay_Antiq_Model_GroupData__GetArtifact(uVar2,0);
		    uVar2 = func_ii_8783(&local_8,0);
		    iVar1 = *piVar5;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (piVar5,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[0xb],0);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar3 = Gameplay_Antiq_View_EffectView__SetData(uVar3,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060054C0 RID: 21696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C0")]
		[Address(RVA = "0xA26C", Offset = "0xA26C", VA = "0xA26C", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Antiq_View_GroupView__HandleDataChanged
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = param1[0xd];
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060054C1 RID: 21697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C1")]
		[Address(RVA = "0xA26D", Offset = "0xA26D", VA = "0xA26D", Slot = "20")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Antiq_View_GroupView__OnPointerClick(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5948d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_GroupData___ctor__);
		    DAT_ram_00a5948d = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_GroupData___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060054C2 RID: 21698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C2")]
		[Address(RVA = "0xA26E", Offset = "0xA26E", VA = "0xA26E")]
		public GroupView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Antiq_View_GroupView___ctor(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param2,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  uVar1 = Gameplay_Antiq_Model_GroupData__GetLevel(uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x04002DEA RID: 11754
		[Token(Token = "0x4002DEA")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameAssetViewRawImage _image;

		// Token: 0x04002DEB RID: 11755
		[Token(Token = "0x4002DEB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TMP_Text _levelField;

		// Token: 0x04002DEC RID: 11756
		[Token(Token = "0x4002DEC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Transform _availMaxLevel;

		// Token: 0x04002DED RID: 11757
		[Token(Token = "0x4002DED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform[] _availFrame;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Antiq_View_GroupView__add_ClickEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5948b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GroupData__TypeInfo);
		    DAT_ram_00a5948b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_GroupData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GroupData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x34,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_Antiq_View_GroupView__remove_ClickEvent(int param1,undefined4 param2)
		
		{
		  UI_AbstractDeferredRenderer__OnDisable(param1,0);
		  *(undefined4 *)(param1 + 0x34) = 0;
		  return;
		}
		*/

}
