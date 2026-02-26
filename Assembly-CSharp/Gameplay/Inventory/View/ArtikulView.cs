using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Core.Materials;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Inventory.View
{
	// Token: 0x0200065A RID: 1626
	[Token(Token = "0x200065A")]
	public class ArtikulView : AbstractDataRenderer<ArtikulData>, IPointerClickHandler, IEventSystemHandler, IToolTipDataProvider, IGrayscalable
	{
		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x000078D8 File Offset: 0x00005AD8
		// (set) Token: 0x06002779 RID: 10105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000773")]
		public int? StackSizeExternal
		{
			[Token(Token = "0x6002778")]
			[Address(RVA = "0x78A9", Offset = "0x78A9", VA = "0x78A9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002779")]
			[Address(RVA = "0x78AA", Offset = "0x78AA", VA = "0x78AA")]
			set
			{
			}
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277A")]
		[Address(RVA = "0x78AB", Offset = "0x78AB", VA = "0x78AB", Slot = "16")]
		protected override void OnDataInvalidated()
		{
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x000078F0 File Offset: 0x00005AF0
		// (set) Token: 0x0600277C RID: 10108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000774")]
		public bool Interactable
		{
			[Token(Token = "0x600277B")]
			[Address(RVA = "0x78AC", Offset = "0x78AC", VA = "0x78AC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600277C")]
			[Address(RVA = "0x78AD", Offset = "0x78AD", VA = "0x78AD")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277D")]
		[Address(RVA = "0x78AE", Offset = "0x78AE", VA = "0x78AE", Slot = "23")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Inventory_View_ArtikulView__OnPointerClick(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param2_00;
		  int param1_01;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5a095 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    DAT_ram_00a5a095 = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1[0xd],0);
		  if (iVar1 != 0) {
		    param1_01 = param1[0xd];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    UI_ToolTip_ToolTip__get_enabled(param1_01,(uint)(iVar1 != 0),0);
		  }
		  param1_00 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    param2_00 = Core_Extensions_Dict_AprMarkerDicExt__GetTitle
		                          (*(undefined4 *)(*(int *)(iVar1 + 8) + 0x10),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    param1_00 = Core_Extensions_Dict_ArtikulDicExt__GetPetIconAssetId
		                          (*(undefined4 *)(*(int *)(iVar1 + 8) + 0x10),0);
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (param1_00,0);
		    if (iVar1 != 0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      param1_00 = Core_Extensions_Dict_IsleInfoDictExt__GetBackgroundImageAssetId
		                            (*(undefined4 *)(iVar1 + 0x14),0);
		    }
		  }
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1[9],param2_00,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1[10],param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600277E RID: 10110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277E")]
		[Address(RVA = "0x78AF", Offset = "0x78AF", VA = "0x78AF", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Inventory_View_ArtikulView__HandleDataChanged(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  ulonglong local_10;
		  int local_4;
		  
		  if (DAT_ram_00a5a096 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__get_Value__);
		    DAT_ram_00a5a096 = '\x01';
		  }
		  local_10 = *(ulonglong *)(param1 + 0xf);
		  if ((local_10 & 0xff) == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    if (iVar1 == 0) {
		      local_4 = 0;
		    }
		    else {
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      iVar1 = Gameplay_Inventory_Model_InventoryBaseModel__GetArtifactById(uVar2,0);
		      if (iVar1 == 0) {
		        local_4 = 0;
		      }
		      else {
		        piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                                  (param1,*(undefined4 *)(*param1 + 0x134));
		        local_4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xf8) * 4))
		                            (piVar3,*(undefined4 *)(*piVar3 + 0xfc));
		      }
		    }
		  }
		  else {
		    local_4 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                        (&local_10,Method_System_Nullable_int__get_Value__);
		  }
		  piVar3 = (int *)param1[0xb];
		  uVar2 = func_ii_4443(&local_4,0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar3,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[0xc],0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(0 < local_4),0);
		  return;
		}
		*/

		}

		// Token: 0x0600277F RID: 10111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277F")]
		[Address(RVA = "0x78B0", Offset = "0x78B0", VA = "0x78B0")]
		private void RenderStackSize()
		{
		/* --- GHIDRA: RenderStackSize ---
		void Gameplay_Inventory_View_ArtikulView__RenderStackSize(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a097 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ArtikulData__CommitProperties__);
		    DAT_ram_00a5a097 = '\x01';
		  }
		  UI_AbstractDataRenderer_object____ctor
		            (param1,Method_UI_AbstractDataRenderer_ArtikulData__CommitProperties__);
		  if (*(char *)(param1 + 0x38) != '\0') {
		    Gameplay_Inventory_View_ArtikulView__HandleDataChanged(param1,param1);
		    *(undefined1 *)(param1 + 0x38) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002780 RID: 10112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002780")]
		[Address(RVA = "0x78B1", Offset = "0x78B1", VA = "0x78B1", Slot = "5")]
		protected override void CommitProperties()
		{
		/* --- GHIDRA: CommitProperties ---
		int Gameplay_Inventory_View_ArtikulView__CommitProperties(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param4;
		  undefined4 param1_01;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5a098 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ToolTipArtifactInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_IItemInformationProvider___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_ToolTipData_IItemInformationProvider__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_IItemInformationProvider__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12536);
		    DAT_ram_00a5a098 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_IItemInformationProvider__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12536,
		             Method_UI_ToolTip_ToolTipData_IItemInformationProvider___ctor__);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x811c159e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811c159e:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x811c1650;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811c1650:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                     (param1,*(undefined4 *)(*param1 + 0x134));
		  param1_01 = unnamed_function_1417(Gameplay_Inventory_Model_ToolTipArtifactInfoProvider_TypeInfo);
		  Gameplay_Inventory_Model_ToolTipArtifactInfoProvider___ctor(param1_01,uVar3,uVar4,param4,0);
		  *(undefined4 *)(param1_00 + 0x1c) = param1_01;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06002781 RID: 10113 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002781")]
		[Address(RVA = "0x78B2", Offset = "0x78B2", VA = "0x78B2", Slot = "24")]
		public virtual BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		void Gameplay_Inventory_View_ArtikulView__GetData(int param1,float param2,undefined4 param3)
		
		{
		  Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(param1 + 0x24),param2,0);
		  Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(param1 + 0x28),param2,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002782")]
		[Address(RVA = "0x78B3", Offset = "0x78B3", VA = "0x78B3", Slot = "22")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002783")]
		[Address(RVA = "0x78B4", Offset = "0x78B4", VA = "0x78B4")]
		public ArtikulView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Inventory_View_ArtikulView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a09a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12637);
		    DAT_ram_00a5a09a = '\x01';
		  }
		  return StringLiteral_12637;
		}
		*/

		}

		// Token: 0x040015A4 RID: 5540
		[Token(Token = "0x40015A4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameRawImage _icon;

		// Token: 0x040015A5 RID: 5541
		[Token(Token = "0x40015A5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameRawImage _qualityBg;

		// Token: 0x040015A6 RID: 5542
		[Token(Token = "0x40015A6")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _stackLabel;

		// Token: 0x040015A7 RID: 5543
		[Token(Token = "0x40015A7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _stackOwner;

		// Token: 0x040015A8 RID: 5544
		[Token(Token = "0x40015A8")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ToolTip _toolTip;

		// Token: 0x040015A9 RID: 5545
		[Token(Token = "0x40015A9")]
		[FieldOffset(Offset = "0x38")]
		private bool _stackSizeChanged;

		// Token: 0x040015AA RID: 5546
		[Token(Token = "0x40015AA")]
		[FieldOffset(Offset = "0x3C")]
		private int? _stackSizeExternal;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_StackSizeExternal ---
		void Gameplay_Inventory_View_ArtikulView__get_StackSizeExternal
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  undefined8 uVar1;
		  
		  uVar1 = *param2;
		  *(undefined1 *)(param1 + 0x38) = 1;
		  *(undefined8 *)(param1 + 0x3c) = uVar1;
		  UI_AbstractDeferredRenderer__KillCoroutine(param1,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_StackSizeExternal ---
		void Gameplay_Inventory_View_ArtikulView__set_StackSizeExternal(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a093 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ArtikulData__OnDataInvalidated__);
		    DAT_ram_00a5a093 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x38) = 1;
		  return;
		}
		*/


		/* --- GHIDRA: set_Interactable ---
		void Gameplay_Inventory_View_ArtikulView__set_Interactable
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a094 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Info_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ArtikulInfoPopupWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12635);
		    DAT_ram_00a5a094 = '\x01';
		  }
		  if (*(char *)(param1 + 0x44) != '\0') {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		    param1_00 = unnamed_function_1417
		                          (
		                          Gameplay_Inventory_View_Info_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs_TypeInfo
		                          );
		    UI_Windows_BaseWindowArgs__Dispose(param1_00,0);
		    *(int *)(param1_00 + 0x18) = param1;
		    Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		              (uVar1,StringLiteral_12635,param1_00,
		               Method_UI_Windows_PopupController_Show_ArtikulInfoPopupWindow___);
		  }
		  return;
		}
		*/

}
