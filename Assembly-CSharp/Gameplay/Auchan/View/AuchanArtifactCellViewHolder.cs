using System;
using System.Collections.Generic;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Gameplay.Auchan.Model;
using Il2CppDummyDll;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C82 RID: 3202
	[Token(Token = "0x2000C82")]
	public class AuchanArtifactCellViewHolder : CellViewsHolder
	{
		// Token: 0x06004E20 RID: 20000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E20")]
		[Address(RVA = "0x9C53", Offset = "0x9C53", VA = "0x9C53", Slot = "7")]
		public override void CollectViews()
		{
		/* --- GHIDRA: CollectViews ---
		void Gameplay_Auchan_View_AuchanArtifactCellViewHolder__CollectViews
		               (int param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *param5_00;
		  undefined4 uVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a59843 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_AuchanArtifactData__Contains__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59843 = '\x01';
		  }
		  iVar2 = func_ii_10159(param4,param2,
		                        Method_System_Collections_Generic_HashSet_AuchanArtifactData__Contains__);
		  if ((iVar2 != 0) ||
		     (iVar2 = func_ii_10159(param5,param2,
		                            Method_System_Collections_Generic_HashSet_AuchanArtifactData__Contains__
		                           ), iVar2 != 0)) {
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    iVar2 = **(int **)(param1 + 0x14);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x1a0) * 4))
		              (*(int **)(param1 + 0x14),1,*(undefined4 *)(iVar2 + 0x1a4));
		    return;
		  }
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  iVar2 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x1a0) * 4))
		            (*(int **)(param1 + 0x14),0,*(undefined4 *)(iVar2 + 0x1a4));
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param5_00 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x140);
		        goto code_r0x810799ae;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param5_00 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x810799ae:
		  uVar4 = (**(code **)((ulonglong)*param5_00 * 4))(param1_00,param5_00[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  Gameplay_Auchan_View_AuchanArtifactView__set_ArtifactData
		            (uVar3,param2,uVar4,*(undefined4 *)(param3 + 100),param5_00);
		  return;
		}
		*/

		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E21")]
		[Address(RVA = "0x9C54", Offset = "0x9C54", VA = "0x9C54")]
		public void UpdateViews(AuchanArtifactData model, AuchanGridWithCategoriesParams parameters, HashSet<AuchanArtifactData> separatorItems, HashSet<AuchanArtifactData> rowCompletionItems)
		{
		}

		// Token: 0x06004E22 RID: 20002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E22")]
		[Address(RVA = "0x9C55", Offset = "0x9C55", VA = "0x9C55")]
		public void SetVisible(bool enabled)
		{
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E23")]
		[Address(RVA = "0x9C56", Offset = "0x9C56", VA = "0x9C56")]
		public AuchanArtifactCellViewHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Auchan_View_AuchanArtifactCellViewHolder___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  bool bVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  int iVar9;
		  uint uVar10;
		  
		  bVar2 = false;
		  if (DAT_ram_00a59844 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Price__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_InventoryChangedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_OnArtifactDropRemoveEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_AuchanArtifactView___);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_GetComponent_ThemeDuelShopItemView___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Price__ForEach__);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Auchan_View_AuchanArtifactInfoPopupWindow___c__DisplayClass4_0__OnShow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Auchan_View_AuchanArtifactInfoPopupWindow___c__DisplayClass4_0_TypeInfo);
		    DAT_ram_00a59844 = '\x01';
		  }
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_Auchan_View_AuchanArtifactInfoPopupWindow___c__DisplayClass4_0_TypeInfo
		                    );
		  if (*(int **)(param2 + 0x18) != (int *)0x0) {
		    iVar9 = **(int **)(param2 + 0x18);
		    if ((uint)*(byte *)(Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView_TypeInfo + 0xb8) <=
		        (uint)*(byte *)(iVar9 + 0xb8)) {
		      bVar2 = *(int *)(*(int *)(iVar9 + 100) +
		                       (uint)*(byte *)(
		                                      Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView_TypeInfo
		                                      + 0xb8) * 4 + -4) ==
		              Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView_TypeInfo;
		    }
		  }
		  *(bool *)(iVar3 + 8) = bVar2;
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x6c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,(uint)*(byte *)(iVar3 + 8),0);
		  uVar7 = *(undefined4 *)(param1 + 0x70);
		  uVar4 = unnamed_function_1417(System_Action_Price__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,iVar3,
		             Method_Gameplay_Auchan_View_AuchanArtifactInfoPopupWindow___c__DisplayClass4_0__OnShow_b__0__
		             ,0);
		  System_Collections_Generic_List_UsageHint___FindLastIndex
		            (uVar7,uVar4,Method_System_Collections_Generic_List_Price__ForEach__);
		  Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow__Awake(param1,param2,0);
		  piVar8 = *(int **)(param2 + 0x18);
		  iVar9 = *piVar8;
		  uVar10 = (uint)*(ushort *)(iVar9 + 0xb6);
		  if (*(char *)(iVar3 + 8) == '\0') {
		    if (uVar10 != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xe8);
		          goto code_r0x81079e80;
		        }
		        uVar1 = uVar1 + 1;
		      } while (uVar10 != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar8,Gameplay_Inventory_View_IArtifactView_TypeInfo,5);
		code_r0x81079e80:
		    uVar4 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		    iVar3 = func_ii_6601(uVar4,Method_UnityEngine_GameObject_GetComponent_AuchanArtifactView___);
		    Gameplay_Auchan_View_AuchanActionInfoDisplay__HandleItemBought
		              (*(undefined4 *)(param1 + 0x68),*(undefined4 *)(iVar3 + 0x20),
		               *(undefined4 *)(iVar3 + 0x14),*(undefined4 *)(param2 + 0x1c),iVar3);
		  }
		  else {
		    if (uVar10 != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xe8);
		          goto code_r0x81079df4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (uVar10 != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar8,Gameplay_Inventory_View_IArtifactView_TypeInfo,5);
		code_r0x81079df4:
		    uVar4 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		    uVar4 = func_ii_6601(uVar4,Method_UnityEngine_GameObject_GetComponent_ThemeDuelShopItemView___);
		    Gameplay_Auchan_View_AuchanActionInfoDisplay__HandleItemBought
		              (*(undefined4 *)(param1 + 0x68),uVar4,0,*(undefined4 *)(param2 + 0x1c),uVar4);
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *piVar8;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar10 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar10 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x81079f4f;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar10);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x81079f4f:
		  iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  iVar9 = *(int *)(iVar3 + 0x20);
		  uVar7 = *(undefined4 *)(iVar9 + 0x14);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_InventoryChangedEvent__,0);
		  piVar8 = (int *)func_ii_7048(uVar7,uVar4,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar8 == (int *)0x0) {
		    *(undefined4 *)(iVar9 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar8) ||
		          (*(int **)(iVar9 + 0x14) = piVar8, *piVar8 != iVar3)) {
		    System_Activator__CreateInstance(piVar8,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *piVar8;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar10 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar10 * 8 + 4) * 8 + iVar3 + 0x150);
		        goto code_r0x8107a065;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar10);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x8107a065:
		  iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  iVar9 = **(int **)(iVar3 + 0x10);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x110) * 4))
		                    (*(int **)(iVar3 + 0x10),*(undefined4 *)(iVar9 + 0x114));
		  uVar7 = *(undefined4 *)(iVar3 + 0x1c);
		  uVar4 = unnamed_function_1417(System_Action_DropTypes__ArtifactData__TypeInfo);
		  System_Action_Int32Enum__Int32Enum___Invoke
		            (uVar4,param1,
		             Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_OnArtifactDropRemoveEvent__
		             ,0);
		  iVar9 = func_ii_7048(uVar7,uVar4,0);
		  uVar4 = System_Action_DropTypes__ArtifactData__TypeInfo;
		  if (iVar9 == 0) {
		    *(undefined4 *)(iVar3 + 0x1c) = 0;
		    return;
		  }
		  iVar6 = func_ii_1082(iVar9,System_Action_DropTypes__ArtifactData__TypeInfo);
		  if (iVar6 != 0) {
		    *(int *)(iVar3 + 0x1c) = iVar6;
		    uVar4 = System_Action_DropTypes__ArtifactData__TypeInfo;
		    iVar3 = func_ii_1082(iVar9,System_Action_DropTypes__ArtifactData__TypeInfo);
		    if (iVar3 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar9,uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar9,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04002AA9 RID: 10921
		[Token(Token = "0x4002AA9")]
		[FieldOffset(Offset = "0x18")]
		private AuchanArtifactView _itemView;
	}
}
