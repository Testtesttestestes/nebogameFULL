using System;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Collections.Model;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Collections.View
{
	// Token: 0x020009C7 RID: 2503
	[Token(Token = "0x20009C7")]
	[Serializable]
	public class CollectionRowHelper
	{
		// Token: 0x06003BFC RID: 15356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BFC")]
		[Address(RVA = "0x8ACD", Offset = "0x8ACD", VA = "0x8ACD")]
		public void RenderMedalCollectionRow(MedalDicWrapper medal, ICollectionsMaterialsStorage storage)
		{
		/* --- GHIDRA: RenderMedalCollectionRow ---
		void Gameplay_Collections_View_CollectionRowHelper__RenderMedalCollectionRow
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_Collections_View_CollectionRowHelper__RenderAprCollectionRow
		            (param1,param2,param3,**(undefined4 **)(DAT_ram_00a66978 + 0x5c),param3);
		  return;
		}
		*/

		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BFD")]
		[Address(RVA = "0x8ACE", Offset = "0x8ACE", VA = "0x8ACE")]
		public void RenderAprCollectionRow(MedalDicWrapper medal, ICollectionsMaterialsStorage storage)
		{
		/* --- GHIDRA: RenderAprCollectionRow ---
		void Gameplay_Collections_View_CollectionRowHelper__RenderAprCollectionRow
		               (int param1,int param2,int *param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57e8c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Id__);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_CollectionRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Model_ICollectionsMaterialsStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57e8c = '\x01';
		  }
		  local_4 = 0;
		  uVar5 = *(undefined4 *)(param2 + 0xc);
		  iVar6 = *param3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Collections_Model_ICollectionsMaterialsStorage_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x80e73464;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,
		                                Gameplay_Collections_Model_ICollectionsMaterialsStorage_TypeInfo,1);
		code_r0x80e73464:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param3,uVar5,&local_4,puVar2[1]);
		  uVar5 = local_4;
		  param1_00 = *(undefined4 *)(param1 + 8);
		  if (iVar6 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *param1_01;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		          goto code_r0x80e7351e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e7351e:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		    uVar3 = func_ii_7112(uVar3,0);
		    iVar4 = unnamed_function_1417(Core_Data_InfoRows_CollectionRow_TypeInfo);
		    Core_Data_InfoRows_ModifierRow__Create(iVar4,uVar5,uVar3,0);
		    *(undefined4 *)(iVar4 + 0xc) = param4;
		    UI_Requirements_RequirementsView__GetRowPrefab(param1_00,iVar4,0);
		    param1_00 = *(undefined4 *)(param1 + 8);
		  }
		  uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1_00,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar5,iVar6,0);
		  return;
		}
		*/

		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BFE")]
		[Address(RVA = "0x8ACF", Offset = "0x8ACF", VA = "0x8ACF")]
		private void RenderRow(MedalDicWrapper medal, ICollectionsMaterialsStorage storage, string text)
		{
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BFF")]
		[Address(RVA = "0x8AD0", Offset = "0x8AD0", VA = "0x8AD0")]
		public CollectionRowHelper()
		{
		/* --- GHIDRA: .ctor ---
		uint Gameplay_Collections_View_CollectionRowHelper___ctor(int param1,undefined4 param2)
		
		{
		  return (uint)*(byte *)(*(int *)(param1 + 0x1c) + 0x30);
		}
		*/

		}

		// Token: 0x0400211C RID: 8476
		[Token(Token = "0x400211C")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private CollectionRowView _row;
	}
}
