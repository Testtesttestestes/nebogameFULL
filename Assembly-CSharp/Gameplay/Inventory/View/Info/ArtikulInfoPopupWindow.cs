using System;
using AssetContent.Loaders;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Wiki;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Inventory.View.Info
{
	// Token: 0x0200066D RID: 1645
	[Token(Token = "0x200066D")]
	public class ArtikulInfoPopupWindow : ClosableBaseWindow<ArtikulInfoPopupWindow.ArtikulInfoPopupWindowArgs>
	{
		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000792")]
		public override string WindowId
		{
			[Token(Token = "0x60027EF")]
			[Address(RVA = "0x7915", Offset = "0x7915", VA = "0x7915", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F0")]
		[Address(RVA = "0x7916", Offset = "0x7916", VA = "0x7916", Slot = "24")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Inventory_View_Info_ArtikulInfoPopupWindow__Awake
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  int iVar7;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a0c6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Id__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a0c6 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs__OnShow__
		              );
		  uVar4 = *(undefined4 *)(param2 + 0x18);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar4,0);
		  if (iVar1 == 0) {
		    param1_00 = *(int **)(param2 + 0x1c);
		  }
		  else {
		    iVar1 = **(int **)(param2 + 0x18);
		    param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		                                 (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x134));
		  }
		  iVar1 = **(int **)(param1 + 0x48);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x138) * 4))
		            (*(int **)(param1 + 0x48),param1_00,*(undefined4 *)(iVar1 + 0x13c));
		  piVar5 = *(int **)(param1 + 0x3c);
		  uVar4 = Core_Data_ArtikulData__get_IsSellable(param1_00,0);
		  iVar1 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar5,uVar4,*(undefined4 *)(iVar1 + 0x2d4));
		  uVar6 = *(undefined4 *)(param1 + 0x50);
		  uVar4 = Core_Extensions_Dict_ArtikulDicExt__GetMiddleBgSubstrateAssetId
		                    (*(undefined4 *)(param1_00[2] + 0x10),0);
		  uVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar4,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar6,uVar2 ^ 1,0);
		  piVar5 = *(int **)(param1 + 0x40);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe0) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0xe4));
		  uVar4 = Core_Data_Spells_AbstractSpellsBasedDescription___ctor(uVar4,0);
		  iVar1 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar5,uVar4,*(undefined4 *)(iVar1 + 0x2d4));
		  uVar6 = *(undefined4 *)(param1 + 0x44);
		  uVar4 = Core_Data_ArtikulData__get_CurrentDurability(param1_00,0);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (uVar6,uVar4,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  iVar1 = *(int *)(param1 + 0x4c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar5;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x811c5b4b;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811c5b4b:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar5;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x811c5bfd;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811c5bfd:
		  uVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar6 = func_ii_7112(uVar6,0);
		  iVar7 = unnamed_function_1417(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		  Gameplay_Inventory_Model_ArtifactInfoProvider___ctor(iVar7,uVar4,uVar6,param1_00,0);
		  if (iVar7 != *(int *)(iVar1 + 0x14)) {
		    *(int *)(iVar1 + 0x14) = iVar7;
		    iVar1 = *(int *)(iVar1 + 0x10);
		    if (*(int *)(iVar1 + 0x28) != iVar7) {
		      *(int *)(iVar1 + 0x28) = iVar7;
		      Gameplay_Inventory_View_Info_InfoBox_ArtifactInformationBox__set_Data(iVar1,iVar7);
		    }
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x54);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar2 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar1 = *piVar5;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8 + 4) * 8 + iVar1 + 0x178);
		        goto code_r0x811c5d01;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811c5d01:
		  uVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  piVar5 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,1);
		  local_4 = *(undefined4 *)(param1_00[2] + 0xc);
		  iVar1 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  if ((iVar1 != 0) && (iVar7 = func_ii_1082(iVar1,*(undefined4 *)(*piVar5 + 0x20)), iVar7 == 0)) {
		    uVar4 = func_ii_1083();
		    func_ii_1050(uVar4,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar5[4] = iVar1;
		  UI_MonoBehaviourWithStates_Int32Enum___set_CurrentState(uVar4,uVar6,piVar5,0);
		  return;
		}
		*/

		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F1")]
		[Address(RVA = "0x7917", Offset = "0x7917", VA = "0x7917", Slot = "22")]
		protected override void OnShow(ArtikulInfoPopupWindow.ArtikulInfoPopupWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Inventory_View_Info_ArtikulInfoPopupWindow__OnShow
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a0c7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs___ctor__
		              );
		    DAT_ram_00a5a0c7 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F2")]
		[Address(RVA = "0x7918", Offset = "0x7918", VA = "0x7918")]
		public ArtikulInfoPopupWindow()
		{
		}

		// Token: 0x040015EC RID: 5612
		[Token(Token = "0x40015EC")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/ArtikulInfoPopupWindow";

		// Token: 0x040015ED RID: 5613
		[Token(Token = "0x40015ED")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _titleLabel;

		// Token: 0x040015EE RID: 5614
		[Token(Token = "0x40015EE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _descriptionLabel;

		// Token: 0x040015EF RID: 5615
		[Token(Token = "0x40015EF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameRawImageLoader _qualityBigBgLoader;

		// Token: 0x040015F0 RID: 5616
		[Token(Token = "0x40015F0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x040015F1 RID: 5617
		[Token(Token = "0x40015F1")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ArtifactInfoPropertiesView _propertiesView;

		// Token: 0x040015F2 RID: 5618
		[Token(Token = "0x40015F2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _descriotionGroup;

		// Token: 0x040015F3 RID: 5619
		[Token(Token = "0x40015F3")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private WikiUriRouter _wiki;

		// Token: 0x0200066E RID: 1646
		[Token(Token = "0x200066E")]
		public class ArtikulInfoPopupWindowArgs : BaseWindowArgs
		{
			// Token: 0x060027F3 RID: 10227 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60027F3")]
			[Address(RVA = "0x7919", Offset = "0x7919", VA = "0x7919")]
			public ArtikulInfoPopupWindowArgs()
			{
			}

			// Token: 0x040015F4 RID: 5620
			[Token(Token = "0x40015F4")]
			[FieldOffset(Offset = "0x18")]
			public ArtikulView ArtikulView;

			// Token: 0x040015F5 RID: 5621
			[Token(Token = "0x40015F5")]
			[FieldOffset(Offset = "0x1C")]
			public ArtikulData Data;

			// Token: 0x040015F6 RID: 5622
			[Token(Token = "0x40015F6")]
			[FieldOffset(Offset = "0x20")]
			public uint OptionId;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Inventory_View_Info_ArtikulInfoPopupWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a0c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs__Awake__
		              );
		    DAT_ram_00a5a0c5 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object____ctor
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs__Awake__
		            );
		  *(undefined1 *)(*(int *)(param1 + 0x48) + 0x44) = 0;
		  return;
		}
		*/

}
