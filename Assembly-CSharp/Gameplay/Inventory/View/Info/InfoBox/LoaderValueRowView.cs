using System;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x02000679 RID: 1657
	[Token(Token = "0x2000679")]
	public class LoaderValueRowView : TitleIconLoaderValueRow
	{
		// Token: 0x06002827 RID: 10279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002827")]
		[Address(RVA = "0x794C", Offset = "0x794C", VA = "0x794C", Slot = "6")]
		public override void SetTitle(string value)
		{
		/* --- GHIDRA: SetTitle ---
		void Gameplay_Inventory_View_Info_InfoBox_LoaderValueRowView__SetTitle
		               (int param1,uint *param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  uVar2 = *param2;
		  local_8 = (float4)((float)(uVar2 >> 0x10 & 0xff) / 255.0);
		  local_4 = (float4)((float)(uVar2 >> 0x18) / 255.0);
		  local_10 = (float4)((float)(uVar2 & 0xff) / 255.0);
		  local_c = (float4)((float)(uVar2 >> 8 & 0xff) / 255.0);
		  iVar1 = **(int **)(param1 + 0x10);
		  local_18 = CONCAT44(local_4,local_8);
		  local_20 = CONCAT44(local_c,local_10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x10),&local_20,*(undefined4 *)(iVar1 + 0x17c));
		  uVar2 = *param2;
		  local_8 = (float4)((float)(uVar2 >> 0x10 & 0xff) / 255.0);
		  local_4 = (float4)((float)(uVar2 >> 0x18) / 255.0);
		  local_10 = (float4)((float)(uVar2 & 0xff) / 255.0);
		  local_c = (float4)((float)(uVar2 >> 8 & 0xff) / 255.0);
		  iVar1 = **(int **)(param1 + 0x28);
		  local_28 = CONCAT44(local_4,local_8);
		  local_30 = CONCAT44(local_c,local_10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x28),&local_30,*(undefined4 *)(iVar1 + 0x17c));
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x3c),0);
		  if (iVar1 != 0) {
		    UI_Price_PriceItemRenderer__set_ResId(*(undefined4 *)(param1 + 0x3c),param2,0);
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x40),0);
		  if (iVar1 != 0) {
		    UI_Price_Price__OnDisable(*(undefined4 *)(param1 + 0x40),param2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002828 RID: 10280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002828")]
		[Address(RVA = "0x794D", Offset = "0x794D", VA = "0x794D", Slot = "7")]
		public override void SetTitleColor(in Color32 color)
		{
		/* --- GHIDRA: SetTitleColor ---
		void Gameplay_Inventory_View_Info_InfoBox_LoaderValueRowView__SetTitleColor
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int *param1_00;
		  int iVar7;
		  int iVar8;
		  uint uVar9;
		  undefined8 local_20;
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a5a0db == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool__get_Value__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    DAT_ram_00a5a0db = '\x01';
		  }
		  if (DAT_ram_00a5a0dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationRow_TypeInfo);
		    DAT_ram_00a5a0dd = '\x01';
		  }
		  uVar9 = 0;
		  piVar5 = (int *)param1[8];
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Data_InfoRows_IInformationRow_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x811c7d41;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Data_InfoRows_IInformationRow_TypeInfo,1);
		code_r0x811c7d41:
		  uVar1 = CONCAT44(in_register_20000014,puVar2[1]);
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar1);
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),uVar3);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		            (param1,uVar1,*(undefined4 *)(*param1 + 0xf4));
		  piVar5 = (int *)param1[8];
		  if (piVar5 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar5 + 0xb8) <
		         (uint)*(byte *)(Core_Data_InfoRows_ValueRow_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar5 + 100) +
		                 (uint)*(byte *)(Core_Data_InfoRows_ValueRow_TypeInfo + 0xb8) * 4 + -4) !=
		        Core_Data_InfoRows_ValueRow_TypeInfo)) {
		      System_Activator__CreateInstance(piVar5,Core_Data_InfoRows_ValueRow_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[4],0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,(uint)(piVar5[3] != 0),0);
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[0xc],0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,(uint)*(byte *)(piVar5 + 4),0);
		    iVar6 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1[9],0);
		    if (iVar6 != 0) {
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1[9],0);
		      uVar9 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                        (piVar5[5],0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,uVar9 ^ 1,0);
		      iVar6 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                        (piVar5[5],0);
		      if (iVar6 == 0) {
		        Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1[9],piVar5[5],0);
		      }
		    }
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[10],0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,(uint)(piVar5[6] != 0),0);
		    uVar9 = piVar5[7];
		    local_8 = (float4)((float)(uVar9 >> 0x10 & 0xff) / 255.0);
		    local_4 = (float4)((float)(uVar9 >> 0x18) / 255.0);
		    local_10 = (float4)((float)(uVar9 & 0xff) / 255.0);
		    local_c = (float4)((float)(uVar9 >> 8 & 0xff) / 255.0);
		    iVar6 = *(int *)param1[10];
		    local_18 = CONCAT44(local_4,local_8);
		    local_20 = CONCAT44(local_c,local_10);
		    uVar1 = CONCAT44(uVar3,&local_20);
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x178) * 4))
		              ((int *)param1[10],uVar1,*(undefined4 *)(iVar6 + 0x17c));
		    iVar6 = *(int *)param1[10];
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),piVar5[6]);
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		              ((int *)param1[10],uVar1,*(undefined4 *)(iVar6 + 0x2d4));
		    uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (0 < *(longlong *)(piVar5 + 10)) {
		      iVar6 = param1[0xf];
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar8 = *param1_00;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + iVar8 + 0x178);
		            goto code_r0x811c7f9b;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		      }
		      puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811c7f9b:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,CONCAT44(uVar3,puVar2[1]));
		      uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		      uVar3 = System_Collections_Generic_Dictionary_int__object___get_Item(uVar3,5,0);
		      uVar3 = Core_Extensions_Dict_UserSkillDicExt__GetTitle(uVar3,0);
		      UI_Price_PriceItemRenderer__SetIcon(iVar6,uVar3,0);
		      UI_Price_PriceItemRenderer__set_ValidIconEnabled
		                (param1[0xf],(double)*(longlong *)(piVar5 + 10),0);
		    }
		    iVar6 = param1[0xf];
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar6 = UnityEngine_Component__GetComponent_object_(iVar6,0);
		    if (iVar6 != 0) {
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1[0xf],0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,(uint)(0 < *(longlong *)(piVar5 + 10)),0);
		    }
		    iVar6 = param1[0x10];
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar6 = UnityEngine_Component__GetComponent_object_(iVar6,0);
		    if (iVar6 != 0) {
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1[0x10],0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,(uint)(piVar5[8] != 0),0);
		    }
		    iVar6 = piVar5[8];
		    if (iVar6 != 0) {
		      iVar8 = piVar5[0xd];
		      iVar7 = param1[0x10];
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      uVar3 = Core_Money_Money__op_Explicit(iVar6,0);
		      UI_Price_Price__SetColor(iVar7,iVar8,uVar3,0);
		    }
		    if ((char)piVar5[4] != '\0') {
		      iVar8 = param1[0xc];
		      iVar7 = 0x34;
		      iVar6 = UnityEngine_UI_RawImage__set_texture
		                        (piVar5 + 4,Method_System_Nullable_bool__get_Value__);
		      if (iVar6 == 0) {
		        iVar7 = 0x38;
		      }
		      func_ii_7050(iVar8,*(undefined4 *)((int)param1 + iVar7),0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002829 RID: 10281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002829")]
		[Address(RVA = "0x794E", Offset = "0x794E", VA = "0x794E", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282A")]
		[Address(RVA = "0x794F", Offset = "0x794F", VA = "0x794F")]
		public LoaderValueRowView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_Info_InfoBox_LoaderValueRowView___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000004;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  int *piVar8;
		  int iVar9;
		  int iVar10;
		  int iVar11;
		  undefined8 uVar12;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a0dc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_GenericListElement_SpellItemArgs__Init__);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ModifierRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Elements_Buildings_SpellItemArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_UserSkillsIndexes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_47);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2004);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11185);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5a0dc = '\x01';
		  }
		  piVar7 = (int *)param1[8];
		  if (piVar7 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar7 + 0xb8) <
		         (uint)*(byte *)(Core_Data_InfoRows_ModifierRow_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar7 + 100) +
		                 (uint)*(byte *)(Core_Data_InfoRows_ModifierRow_TypeInfo + 0xb8) * 4 + -4) !=
		        Core_Data_InfoRows_ModifierRow_TypeInfo)) {
		      System_Activator__CreateInstance(piVar7,Core_Data_InfoRows_ModifierRow_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = 0;
		    iVar11 = *(int *)param1[0xb];
		    uVar12 = CONCAT44(in_register_20000004,(int *)param1[0xb]);
		    (**(code **)((ulonglong)*(uint *)(iVar11 + 0x2d0) * 4))
		              (uVar12,StringLiteral_5,*(undefined4 *)(iVar11 + 0x2d4));
		    uVar6 = (undefined4)((ulonglong)uVar12 >> 0x20);
		    iVar11 = piVar7[3];
		    piVar8 = (int *)param1[8];
		    iVar9 = *piVar8;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (Core_Data_InfoRows_IInformationRow_TypeInfo ==
		            *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xd0);
		          goto code_r0x811c8257;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar8,Core_Data_InfoRows_IInformationRow_TypeInfo,2);
		code_r0x811c8257:
		    uVar12 = CONCAT44(uVar6,piVar8);
		    (**(code **)((ulonglong)*puVar5 * 4))(uVar12,iVar11,puVar5[1]);
		    uVar6 = (undefined4)((ulonglong)uVar12 >> 0x20);
		    uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar2,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    iVar11 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                       (*(undefined4 *)(piVar7[8] + 0x10),
		                        Method_System_Collections_Generic_Dictionary_int__Skill__get_Count__);
		    if (0 < iVar11) {
		      iVar9 = 0;
		      do {
		        iVar4 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                          (*(undefined4 *)(piVar7[8] + 0x10),iVar9,
		                           Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		        local_4 = *(undefined4 *)(iVar4 + 8);
		        local_8 = 0xffffffff;
		        local_c = Core_Data_Skills_UserSkillsIndexes_TypeInfo;
		        iVar10 = Spine_SkeletonJson__GetFloat(&local_c,0);
		        if (iVar10 == 0) {
		          iVar10 = StringLiteral_5;
		        }
		        uVar12 = *(undefined8 *)(iVar4 + 0x10);
		        uVar3 = Core_Data_Skills_Skill__get_IsProcent(uVar12,0);
		        uVar6 = (undefined4)((ulonglong)uVar12 >> 0x20);
		        System_Reflection_FieldInfo__get_IsStatic
		                  (uVar2,iVar10,uVar3,
		                   Method_System_Collections_Generic_Dictionary_string__string__Add__);
		        iVar9 = iVar9 + 1;
		      } while (iVar9 != iVar11);
		    }
		    uVar3 = Core_Extensions_Dict_ModifierDicExt__GetTitle(*(undefined4 *)(piVar7[8] + 8),0);
		    iVar11 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar3,0);
		    if (iVar11 == 0) {
		      iVar11 = 0;
		      uVar3 = Core_Extensions_Dict_ModifierDicExt__GetTitle(*(undefined4 *)(piVar7[8] + 8),0);
		      uVar2 = Core_GameLocalization__GetTranslation(uVar3,uVar2,0);
		      uVar12 = CONCAT44(uVar6,uVar2);
		      iVar9 = System_Net_WebConnection__ReadLine(uVar2,0x23,0,0);
		      in_register_20000004 = (undefined4)((ulonglong)uVar12 >> 0x20);
		      iVar10 = *(int *)(iVar9 + 0xc);
		      if (0 < iVar10) {
		        do {
		          uVar6 = *(undefined4 *)(iVar9 + iVar11 * 4 + 0x10);
		          uVar12 = CONCAT44((int)((ulonglong)uVar12 >> 0x20),uVar6);
		          iVar4 = System_Net_WebConnection__ReadLine(uVar6,0x7c,0,0);
		          if (*(int *)(iVar4 + 0xc) != 0) {
		            uVar6 = (undefined4)((ulonglong)uVar12 >> 0x20);
		            uVar2 = UnityEngine_Assertions_Assert__IsFalse(StringLiteral_2004,iVar4,0);
		            piVar8 = (int *)param1[0xb];
		            uVar12 = CONCAT44(uVar6,piVar8);
		            uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar8 + 0x2c8) * 4))
		                              (uVar12,*(undefined4 *)(*piVar8 + 0x2cc));
		            uVar6 = (undefined4)((ulonglong)uVar12 >> 0x20);
		            uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                              (uVar3,uVar2,StringLiteral_47,0);
		            uVar12 = CONCAT44(uVar6,piVar8);
		            (**(code **)((ulonglong)*(uint *)(*piVar8 + 0x2d0) * 4))
		                      (uVar12,uVar2,*(undefined4 *)(*piVar8 + 0x2d4));
		          }
		          in_register_20000004 = (undefined4)((ulonglong)uVar12 >> 0x20);
		          iVar11 = iVar11 + 1;
		        } while (iVar11 != iVar10);
		      }
		    }
		    else {
		      iVar11 = *(int *)param1[0xb];
		      uVar12 = CONCAT44(uVar6,(int *)param1[0xb]);
		      (**(code **)((ulonglong)*(uint *)(iVar11 + 0x2d0) * 4))
		                (uVar12,StringLiteral_11185,*(undefined4 *)(iVar11 + 0x2d4));
		      in_register_20000004 = (undefined4)((ulonglong)uVar12 >> 0x20);
		    }
		    uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[9],0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar6,(uint)(piVar7[4] != 0),0);
		    uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[10],0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar6,(uint)(piVar7[5] != 0),0);
		    if (piVar7[4] != 0) {
		      iVar11 = param1[9];
		      uVar6 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl(piVar7[8],0);
		      uVar2 = Core_Extensions_Dict_SpellDicExt__GetAssetId(piVar7[4],0);
		      uVar3 = unnamed_function_1417(UI_Elements_Buildings_SpellItemArgs_TypeInfo);
		      UI_Elements_Buildings_SpellItem___ctor(uVar3,uVar6,0,uVar2,0,0);
		      UI_Elements_Buildings_SpellItemArgs___ctor
		                (iVar11,uVar3,
		                 Method_UI_Elements_GenericList_GenericListElement_SpellItemArgs__Init__);
		    }
		    if (piVar7[5] != 0) {
		      iVar11 = *(int *)param1[10];
		      uVar12 = CONCAT44(in_register_20000004,(int *)param1[10]);
		      (**(code **)((ulonglong)*(uint *)(iVar11 + 0x138) * 4))
		                (uVar12,piVar7[5],*(undefined4 *)(iVar11 + 0x13c));
		      in_register_20000004 = (undefined4)((ulonglong)uVar12 >> 0x20);
		    }
		  }
		  if (DAT_ram_00a5a0dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationRow_TypeInfo);
		    DAT_ram_00a5a0dd = '\x01';
		  }
		  piVar7 = (int *)param1[8];
		  iVar11 = *piVar7;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_InfoRows_IInformationRow_TypeInfo ==
		          *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 200);
		        goto code_r0x811c8542;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar7,Core_Data_InfoRows_IInformationRow_TypeInfo,1);
		code_r0x811c8542:
		  uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(CONCAT44(in_register_20000004,piVar7),puVar5[1]);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		            (param1,uVar6,*(undefined4 *)(*param1 + 0xf4));
		  return;
		}
		*/

		}

		// Token: 0x04001620 RID: 5664
		[Token(Token = "0x4001620")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _image;

		// Token: 0x04001621 RID: 5665
		[Token(Token = "0x4001621")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Sprite _valid_OK;

		// Token: 0x04001622 RID: 5666
		[Token(Token = "0x4001622")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _valid_NOT_OK;

		// Token: 0x04001623 RID: 5667
		[Token(Token = "0x4001623")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private PriceItemRenderer _manaPrice;

		// Token: 0x04001624 RID: 5668
		[Token(Token = "0x4001624")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Price _resourcesPrice;
	}
}
