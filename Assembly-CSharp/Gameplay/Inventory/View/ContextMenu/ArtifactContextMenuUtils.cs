using System;
using System.Collections.Generic;
using Gameplay.Inventory.ContextMenu;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.View.ContextMenu
{
	// Token: 0x02000680 RID: 1664
	[Token(Token = "0x2000680")]
	public static class ArtifactContextMenuUtils
	{
		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007A4")]
		public static ArtikulMenuActionDic.Types.Actions[] DefaultActions
		{
			[Token(Token = "0x600284F")]
			[Address(RVA = "0x796F", Offset = "0x796F", VA = "0x796F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002850")]
		[Address(RVA = "0x7970", Offset = "0x7970", VA = "0x7970")]
		public static List<AbstractArtifactContextMenuElement> GetElements(ArtikulMenuActionDic.Types.Actions[] customActions)
		{
		/* --- GHIDRA: GetElements ---
		void Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils__GetElements(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a0e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_AbstractArtifactContextMenuElement___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Auchan_View_ContextMenu_BuyAuchanAndEquipContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Auchan_View_ContextMenu_BuyAuchanContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Portals_View_ContextMenu_BuyPortalsContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_BuyShopAndEquipContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_ContextMenu_BuyShopContextMenuElement_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuel_View_ContextMenu_BuyThemeDuelContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_CompareArtifactContextMenuElements_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_CompareGolemArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_DismantleAllUserArtifactsContextMenuElement_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_DismantleAndSellContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_DismantleArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_DismantleGolemArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_EquipArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_EquipArtifactFromDropContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_EquipDollArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_EquipToGolemContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_FromFavoritesArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_ArtikulMenuActionDic_Types_Actions__Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_HashSet_ArtikulMenuActionDic_Types_Actions___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_HashSet_ArtikulMenuActionDic_Types_Actions__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_InfoArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_JoinArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_MoveToNebomarketContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_MoveToShopContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_MoveToShopCustomContextMenuElements_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_PutInManufactureAssistantContextMenuElement_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_ContextMenu_PutInManufactureAssistantCustomContextMenuElement_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_ReforgeGolemArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_ReforgeUserArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_RepairGolemArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_RepairUserArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_RestoreUserArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_SellFromGolemChestContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_SellUserArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_SplitArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_TakeFromDropItemContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_ContextMenu_TakeFromManufactureAssistantContextMenuElement_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_TakeoffFromShopAndEquipContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_TakeoffFromShopContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_ToBagArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_ToChestArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_ToFavoritesItemContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_ToGolemChestArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_UnEquipUserItemContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_UnequipDollArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_UnequipFromGolemContextMenuElement_TypeInfo);
		    DAT_ram_00a5a0e6 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_HashSet_ArtikulMenuActionDic_Types_Actions__TypeInfo
		                    );
		  System_Collections_Generic_HashSet_int___get_Count
		            (uVar1,
		             Method_System_Collections_Generic_HashSet_ArtikulMenuActionDic_Types_Actions___ctor__);
		  System_Collections_Generic_HashSet_Enumerator_Int32Enum___MoveNext
		            (uVar1,0x1d,
		             Method_System_Collections_Generic_HashSet_ArtikulMenuActionDic_Types_Actions__Add__);
		  System_Collections_Generic_HashSet_Enumerator_Int32Enum___MoveNext
		            (uVar1,0x20,
		             Method_System_Collections_Generic_HashSet_ArtikulMenuActionDic_Types_Actions__Add__);
		  System_Collections_Generic_HashSet_Enumerator_Int32Enum___MoveNext
		            (uVar1,0x23,
		             Method_System_Collections_Generic_HashSet_ArtikulMenuActionDic_Types_Actions__Add__);
		  System_Collections_Generic_HashSet_Enumerator_Int32Enum___MoveNext
		            (uVar1,0x24,
		             Method_System_Collections_Generic_HashSet_ArtikulMenuActionDic_Types_Actions__Add__);
		  **(undefined4 **)(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo + 0x5c) =
		       uVar1;
		  piVar2 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (Gameplay_Inventory_ContextMenu_AbstractArtifactContextMenuElement___TypeInfo
		                             ,0x2b);
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_EquipArtifactContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[4] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_InfoArtifactContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[5] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_CompareArtifactContextMenuElements_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[6] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_SellUserArtifactContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[7] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_ToBagArtifactContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[8] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_ToChestArtifactContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[9] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_DismantleArtifactContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[10] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_TakeFromDropItemContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0xb] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_UnEquipUserItemContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0xc] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_MoveToShopContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0xd] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_TakeoffFromShopContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0xe] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_Inventory_ContextMenu_TakeoffFromShopAndEquipContextMenuElement_TypeInfo
		                    );
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0xf] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_MoveToNebomarketContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x10] = iVar3;
		  iVar3 = unnamed_function_1417(Gameplay_Inventory_ContextMenu_BuyShopContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x11] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_BuyShopAndEquipContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x12] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Auchan_View_ContextMenu_BuyAuchanContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x13] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Auchan_View_ContextMenu_BuyAuchanAndEquipContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x14] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_EquipArtifactFromDropContextMenuElement_TypeInfo
		                    );
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x15] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_ToFavoritesItemContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x16] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_FromFavoritesArtifactContextMenuElement_TypeInfo
		                    );
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x17] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_MoveToShopCustomContextMenuElements_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x18] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_RestoreUserArtifactContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x19] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_SplitArtifactContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x1a] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_JoinArtifactContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x1b] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_RepairUserArtifactContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x1c] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_ReforgeUserArtifactContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x1d] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_Inventory_ContextMenu_DismantleAllUserArtifactsContextMenuElement_TypeInfo
		                    );
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x1e] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_DismantleAndSellContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x1f] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_Inventory_ContextMenu_PutInManufactureAssistantContextMenuElement_TypeInfo
		                    );
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x20] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_Inventory_ContextMenu_PutInManufactureAssistantCustomContextMenuElement_TypeInfo
		                    );
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x21] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_Inventory_ContextMenu_TakeFromManufactureAssistantContextMenuElement_TypeInfo
		                    );
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x22] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_ToGolemChestArtifactContextMenuElement_TypeInfo)
		  ;
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x23] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_EquipToGolemContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x24] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_SellFromGolemChestContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x25] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_UnequipFromGolemContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x26] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_RepairGolemArtifactContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x27] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_ReforgeGolemArtifactContextMenuElement_TypeInfo)
		  ;
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x28] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_CompareGolemArtifactContextMenuElement_TypeInfo)
		  ;
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x29] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_Inventory_ContextMenu_DismantleGolemArtifactContextMenuElement_TypeInfo
		                    );
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x2a] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_EquipDollArtifactContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x2b] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Inventory_ContextMenu_UnequipDollArtifactContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x2c] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_ThemeDuel_View_ContextMenu_BuyThemeDuelContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x2d] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Portals_View_ContextMenu_BuyPortalsContextMenuElement_TypeInfo);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0x2e] = iVar3;
		  *(int **)(*(int *)(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo + 0x5c) +
		           4) = piVar2;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0400163B RID: 5691
		[Token(Token = "0x400163B")]
		[FieldOffset(Offset = "0x0")]
		private static HashSet<ArtikulMenuActionDic.Types.Actions> _excludeFromDefaultElements;

		// Token: 0x0400163C RID: 5692
		[Token(Token = "0x400163C")]
		[FieldOffset(Offset = "0x4")]
		private static AbstractArtifactContextMenuElement[] _allElements;

		// Token: 0x0400163D RID: 5693
		[Token(Token = "0x400163D")]
		[FieldOffset(Offset = "0x8")]
		private static ArtikulMenuActionDic.Types.Actions[] _defaultActions;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DefaultActions ---
		int Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils__get_DefaultActions
		              (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint *puVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  undefined4 param1_01;
		  int iVar8;
		  int *piVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a5a0e5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_ContextMenu_AbstractArtifactContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Where_AbstractArtifactContextMenuElement___);
		    Mono_Security_ASN1__get_Item(&System_Func_AbstractArtifactContextMenuElement__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_AbstractArtifactContextMenuElement__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_AbstractArtifactContextMenuElement__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractArtifactContextMenuElement__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractArtifactContextMenuElement___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_AbstractArtifactContextMenuElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils___c__DisplayClass5_0__GetElements_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils___c__DisplayClass5_0_TypeInfo
		              );
		    DAT_ram_00a5a0e5 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_AbstractArtifactContextMenuElement__TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_AbstractArtifactContextMenuElement___ctor__);
		  iVar2 = Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo;
		  if (param1 == 0) {
		    if (*(int *)(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo);
		    }
		    param1 = Gameplay_Inventory_View_ContextMenu_ItemContextMenuOptions___ctor(iVar2);
		  }
		  if (0 < *(int *)(param1 + 0xc)) {
		    do {
		      iVar2 = unnamed_function_1417
		                        (
		                        Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils___c__DisplayClass5_0_TypeInfo
		                        );
		      *(undefined4 *)(iVar2 + 8) = *(undefined4 *)(param1 + iVar8 * 4 + 0x10);
		      if (*(int *)(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo + 0x74) ==
		          0) {
		        func_ii_306000(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo);
		      }
		      param1_01 = *(undefined4 *)
		                   (*(int *)(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo +
		                            0x5c) + 4);
		      uVar3 = unnamed_function_1417(System_Func_AbstractArtifactContextMenuElement__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (uVar3,iVar2,
		                 Method_Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils___c__DisplayClass5_0__GetElements_b__0__
		                 ,0);
		      piVar4 = (int *)System_Linq_Enumerable__Where_PlayerLoopSystem_
		                                (param1_01,uVar3,
		                                 Method_System_Linq_Enumerable_Where_AbstractArtifactContextMenuElement___
		                                );
		      iVar2 = *piVar4;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerable_AbstractArtifactContextMenuElement__TypeInfo ==
		              *piVar9) {
		            puVar5 = (uint *)(iVar2 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x811c976f;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar4,
		                                    System_Collections_Generic_IEnumerable_AbstractArtifactContextMenuElement__TypeInfo
		                                    ,0);
		code_r0x811c976f:
		      local_4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      local_c = 0;
		      local_8 = &local_4;
		code_r0x811c979e:
		      do {
		        piVar4 = local_4;
		        iVar2 = *local_4;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		              puVar6 = (undefined4 *)(iVar2 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x811c9832;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) break;
		code_r0x811c9832:
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii(*puVar6,piVar4,puVar6[1]);
		        piVar4 = local_4;
		        if (DAT_ram_009d3e38 == 1) break;
		        if (iVar2 == 0) {
		          iVar2 = 7;
		          goto code_r0x811c9b00;
		        }
		        iVar2 = *local_4;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_AbstractArtifactContextMenuElement__TypeInfo
		                == *piVar9) {
		              puVar6 = (undefined4 *)(iVar2 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x811c990c;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_Generic_IEnumerator_AbstractArtifactContextMenuElement__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) break;
		code_r0x811c990c:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii(*puVar6,piVar4,puVar6[1]);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0xbb,uVar3,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        piVar4 = (int *)import::env::invoke_iii
		                                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x182,uVar3,0);
		        iVar2 = Method_System_Collections_Generic_List_AbstractArtifactContextMenuElement__Add__;
		        if (DAT_ram_009d3e38 == 1) break;
		        if (piVar4 != (int *)0x0) {
		          if (((uint)*(byte *)(*piVar4 + 0xb8) <
		               (uint)*(byte *)(
		                              Gameplay_Inventory_ContextMenu_AbstractArtifactContextMenuElement_TypeInfo
		                              + 0xb8)) ||
		             (*(int *)(*(int *)(*piVar4 + 100) +
		                       (uint)*(byte *)(
		                                      Gameplay_Inventory_ContextMenu_AbstractArtifactContextMenuElement_TypeInfo
		                                      + 0xb8) * 4 + -4) !=
		              Gameplay_Inventory_ContextMenu_AbstractArtifactContextMenuElement_TypeInfo)) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar4,
		                       Gameplay_Inventory_ContextMenu_AbstractArtifactContextMenuElement_TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              do {
		                halt_trap();
		              } while( true );
		            }
		            break;
		          }
		        }
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar1 = *(uint *)(param1_00 + 0xc);
		        if (uVar1 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar1 + 1;
		          *(int **)(*(int *)(param1_00 + 8) + uVar1 * 4 + 0x10) = piVar4;
		          goto code_r0x811c979e;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param1_00,piVar4,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar2 = global_1;
		      iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 != iVar7) {
		code_r0x811c9ba1:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x250,&local_c);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) {
		          import::env::__resumeException(uVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		      local_c = *piVar4;
		      iVar2 = 0;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_v(0x123);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		        goto code_r0x811c9ba1;
		      }
		code_r0x811c9b00:
		      DAT_ram_009d3e38 = 0;
		      piVar4 = *local_8;
		      if (piVar4 != (int *)0x0) {
		        iVar7 = *piVar4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (System_IDisposable_TypeInfo == *piVar9) {
		              puVar5 = (uint *)(iVar7 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x811c9b77;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x811c9b77:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      }
		      if (local_c != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_c);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    } while (((iVar2 == 0) ||
		             ((((iVar2 != 1 && (iVar2 != 2)) && (iVar2 != 3)) &&
		              (((iVar2 != 4 && (iVar2 != 5)) && ((iVar2 != 6 && (iVar2 == 7)))))))) &&
		            (iVar8 = iVar8 + 1, iVar8 < *(int *)(param1 + 0xc)));
		  }
		  return param1_00;
		}
		*/

}
