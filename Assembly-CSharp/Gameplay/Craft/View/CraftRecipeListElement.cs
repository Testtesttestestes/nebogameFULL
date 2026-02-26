using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.Craft.View
{
	// Token: 0x020008AC RID: 2220
	[Token(Token = "0x20008AC")]
	public class CraftRecipeListElement : GenericListElement<CraftRecipeListElement.CraftRecipeListElementArgs>
	{
		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06003421 RID: 13345 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003422 RID: 13346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A58")]
		public CraftRecipeListElement.CraftRecipeListElementArgs Data
		{
			[Token(Token = "0x6003421")]
			[Address(RVA = "0x844E", Offset = "0x844E", VA = "0x844E")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003422")]
			[Address(RVA = "0x844F", Offset = "0x844F", VA = "0x844F")]
			set
			{
			}
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003423")]
		[Address(RVA = "0x8450", Offset = "0x8450", VA = "0x8450")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Craft_View_CraftRecipeListElement__Awake(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57cde == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_View_CraftRecipeListElement_CallElementClickedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_View_CraftRecipeListElement_SelectChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CraftRecipeListElement_CraftRecipeListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UnityEngine_Events_UnityAction_CraftRecipeListElement_CraftRecipeListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UnityEngine_Events_UnityEvent_CraftRecipeListElement_CraftRecipeListElementArgs__RemoveListener__
		              );
		    DAT_ram_00a57cde = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x14);
		  uVar3 = unnamed_function_1417
		                    (
		                    UnityEngine_Events_UnityAction_CraftRecipeListElement_CraftRecipeListElementArgs__TypeInfo
		                    );
		  func_ii_7054(uVar3,param1,
		               Method_Gameplay_Craft_View_CraftRecipeListElement_CallElementClickedEvent__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar4,uVar3,
		             Method_UnityEngine_Events_UnityEvent_CraftRecipeListElement_CraftRecipeListElementArgs__RemoveListener__
		            );
		  iVar5 = *(int *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (uVar3,param1,
		             Method_Gameplay_Craft_View_CraftRecipeListElement_SelectChangedEventHandler__,0);
		  if (DAT_ram_00a57ce3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a57ce3 = '\x01';
		  }
		  param1_00 = *(int *)(iVar5 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,uVar3,0);
		    uVar4 = System_Action_bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar5 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003424 RID: 13348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003424")]
		[Address(RVA = "0x8451", Offset = "0x8451", VA = "0x8451")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003425")]
		[Address(RVA = "0x8452", Offset = "0x8452", VA = "0x8452")]
		private void SelectChangedEventHandler(bool select)
		{
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003426")]
		[Address(RVA = "0x8453", Offset = "0x8453", VA = "0x8453")]
		private void CallElementClickedEvent(CraftRecipeListElement.CraftRecipeListElementArgs args)
		{
		/* --- GHIDRA: CallElementClickedEvent ---
		void Gameplay_Craft_View_CraftRecipeListElement__CallElementClickedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  
		  if (DAT_ram_00a57cdf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_View_CraftRecipeListElement_SelectChangedEventHandler__);
		    DAT_ram_00a57cdf = '\x01';
		  }
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  if (param2 == 0) {
		    iVar2 = 0;
		  }
		  else {
		    uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar3,param1,
		               Method_Gameplay_Craft_View_CraftRecipeListElement_SelectChangedEventHandler__,0);
		    if (DAT_ram_00a57ce2 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		      DAT_ram_00a57ce2 = '\x01';
		    }
		    param1_00 = *(int *)(param2 + 0x18);
		    do {
		      iVar2 = 0;
		      param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,uVar3,0);
		      param2_00 = System_Action_bool__TypeInfo;
		      if ((param1_01 != 0) &&
		         (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) {
		        System_Activator__CreateInstance(param1_01,param2_00);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(param2 + 0x18,iVar2,param1_00);
		      bVar1 = iVar2 != param1_00;
		      param1_00 = iVar2;
		    } while (bVar1);
		  }
		  Gameplay_Craft_View_CraftRecipeListElement__OnInit(param1,iVar2);
		  return;
		}
		*/

		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003427")]
		[Address(RVA = "0x8454", Offset = "0x8454", VA = "0x8454", Slot = "4")]
		protected override void OnInit(CraftRecipeListElement.CraftRecipeListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void Gameplay_Craft_View_CraftRecipeListElement__OnInit(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  uint param2_01;
		  int iVar2;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57ce0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CraftRecipeListElement_CraftRecipeListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    DAT_ram_00a57ce0 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x20);
		  iVar1 = *(int *)(*(int *)(param1 + 0x18) + 0x10);
		  param2_00 = Core_Extensions_Dict_CompetitionRatingKindDicExt__GetDescription
		                        (*(undefined4 *)(*(int *)(iVar1 + 0xc) + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  iVar2 = **(int **)(param1 + 0x24);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x138) * 4))
		            (*(int **)(param1 + 0x24),*(undefined4 *)(*(int *)(iVar1 + 0xc) + 0x10),
		             *(undefined4 *)(iVar2 + 0x13c));
		  iVar2 = *(int *)(param1 + 0x24);
		  *(undefined1 *)(iVar2 + 0x44) = 0;
		  local_8 = 0;
		  System_Data_SqlTypes_SqlInt32___ctor
		            (&local_8,*(undefined4 *)(*(int *)(iVar1 + 8) + 0x10),
		             Method_System_Nullable_int___ctor__);
		  local_10 = local_8;
		  local_18 = local_8;
		  Gameplay_Inventory_View_ArtikulView__get_StackSizeExternal(iVar2,&local_18,0);
		  param2_01 = (uint)*(byte *)(*(int *)(param1 + 0x18) + 0xc);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x2c),(uint)(param2_01 == 0),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x28),param2_01,0);
		  return;
		}
		*/

		}

		// Token: 0x06003428 RID: 13352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003428")]
		[Address(RVA = "0x8455", Offset = "0x8455", VA = "0x8455")]
		private void ApplyArgs()
		{
		/* --- GHIDRA: ApplyArgs ---
		void Gameplay_Craft_View_CraftRecipeListElement__ApplyArgs(int param1,uint param2,undefined4 param3)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x2c),param2 ^ 1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x28),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003429 RID: 13353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003429")]
		[Address(RVA = "0x8456", Offset = "0x8456", VA = "0x8456")]
		private void Select(bool isSelected)
		{
		/* --- GHIDRA: Select ---
		void Gameplay_Craft_View_CraftRecipeListElement__Select(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57ce1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CraftRecipeListElement_CraftRecipeListElementArgs___ctor__
		              );
		    DAT_ram_00a57ce1 = '\x01';
		  }
		  UI_Elements_GenericList_GenericListArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_GenericListElement_CraftRecipeListElement_CraftRecipeListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600342A RID: 13354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600342A")]
		[Address(RVA = "0x8457", Offset = "0x8457", VA = "0x8457")]
		public CraftRecipeListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Craft_View_CraftRecipeListElement___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57ce2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a57ce2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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

		}

		// Token: 0x04001C6C RID: 7276
		[Token(Token = "0x4001C6C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001C6D RID: 7277
		[Token(Token = "0x4001C6D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x04001C6E RID: 7278
		[Token(Token = "0x4001C6E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectedImage;

		// Token: 0x04001C6F RID: 7279
		[Token(Token = "0x4001C6F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameObject _bg;

		// Token: 0x020008AD RID: 2221
		[Token(Token = "0x20008AD")]
		public class CraftRecipeListElementArgs : GenericListElementArgs
		{
			// Token: 0x1400016E RID: 366
			// (add) Token: 0x0600342B RID: 13355 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600342C RID: 13356 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1400016E")]
			public event Action<bool> SelectChangedEvent
			{
				[Token(Token = "0x600342B")]
				[Address(RVA = "0x8458", Offset = "0x8458", VA = "0x8458")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x600342C")]
				[Address(RVA = "0x8459", Offset = "0x8459", VA = "0x8459")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x17000A59 RID: 2649
			// (get) Token: 0x0600342D RID: 13357 RVA: 0x0000AA10 File Offset: 0x00008C10
			// (set) Token: 0x0600342E RID: 13358 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A59")]
			public bool Selected
			{
				[Token(Token = "0x600342D")]
				[Address(RVA = "0x845A", Offset = "0x845A", VA = "0x845A")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600342E")]
				[Address(RVA = "0x845B", Offset = "0x845B", VA = "0x845B")]
				set
				{
				}
			}

			// Token: 0x0600342F RID: 13359 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600342F")]
			[Address(RVA = "0x845C", Offset = "0x845C", VA = "0x845C")]
			public CraftRecipeListElementArgs()
			{
			}

			// Token: 0x04001C70 RID: 7280
			[Token(Token = "0x4001C70")]
			[FieldOffset(Offset = "0xC")]
			private bool _selected;

			// Token: 0x04001C71 RID: 7281
			[Token(Token = "0x4001C71")]
			[FieldOffset(Offset = "0x10")]
			public CraftSchemeData CraftData;

			// Token: 0x04001C72 RID: 7282
			[Token(Token = "0x4001C72")]
			[FieldOffset(Offset = "0x14")]
			public Action<CraftRecipeListElement> CraftRecipeButtonClickedEventHandler;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_Craft_View_CraftRecipeListElement__get_Data(int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int param1_00;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a57cdc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_View_CraftRecipeListElement_SelectChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CraftRecipeListElement_CraftRecipeListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CraftRecipeListElement_CraftRecipeListElementArgs__get_Initted__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CraftRecipeListElement_CraftRecipeListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CraftRecipeListElement_CraftRecipeListElementArgs__set_args__
		              );
		    DAT_ram_00a57cdc = '\x01';
		  }
		  if (*(char *)(param1 + 0x1c) == '\0') {
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (param1,param2,
		               Method_UI_Elements_GenericList_GenericListElement_CraftRecipeListElement_CraftRecipeListElementArgs__Init__
		              );
		    return;
		  }
		  iVar6 = *(int *)(param1 + 0x18);
		  if (iVar6 == 0) {
		    iVar5 = 0;
		  }
		  else {
		    uVar4 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar4,param1,
		               Method_Gameplay_Craft_View_CraftRecipeListElement_SelectChangedEventHandler__,0);
		    if (DAT_ram_00a57ce3 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		      DAT_ram_00a57ce3 = '\x01';
		    }
		    iVar3 = *(int *)(iVar6 + 0x18);
		    do {
		      iVar5 = 0;
		      param1_00 = func_ii_7048(iVar3,uVar4,0);
		      uVar2 = System_Action_bool__TypeInfo;
		      if ((param1_00 != 0) &&
		         (iVar5 = func_ii_1082(param1_00,System_Action_bool__TypeInfo), iVar5 == 0)) {
		        System_Activator__CreateInstance(param1_00,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar5 = func_ii_4329(iVar6 + 0x18,iVar5,iVar3);
		      bVar1 = iVar5 != iVar3;
		      iVar3 = iVar5;
		    } while (bVar1);
		  }
		  *(int *)(param1 + 0x18) = param2;
		  if (param2 != 0) {
		    uVar4 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar4,param1,
		               Method_Gameplay_Craft_View_CraftRecipeListElement_SelectChangedEventHandler__,0);
		    if (DAT_ram_00a57ce2 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		      DAT_ram_00a57ce2 = '\x01';
		    }
		    iVar6 = *(int *)(param2 + 0x18);
		    do {
		      iVar3 = 0;
		      iVar5 = UnityEngine_UI_Image__set_sprite(iVar6,uVar4,0);
		      uVar2 = System_Action_bool__TypeInfo;
		      if ((iVar5 != 0) && (iVar3 = func_ii_1082(iVar5,System_Action_bool__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar5,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar5 = func_ii_4329(param2 + 0x18,iVar3,iVar6);
		      bVar1 = iVar5 != iVar6;
		      iVar6 = iVar5;
		    } while (bVar1);
		  }
		  Gameplay_Craft_View_CraftRecipeListElement__OnInit(param1,iVar5);
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_Craft_View_CraftRecipeListElement__set_Data(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57cdd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_View_CraftRecipeListElement_CallElementClickedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               UnityEngine_Events_UnityAction_CraftRecipeListElement_CraftRecipeListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UnityEngine_Events_UnityEvent_CraftRecipeListElement_CraftRecipeListElementArgs__AddListener__
		              );
		    DAT_ram_00a57cdd = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417
		                        (
		                        UnityEngine_Events_UnityAction_CraftRecipeListElement_CraftRecipeListElementArgs__TypeInfo
		                        );
		  func_ii_7054(param1_00,param1,
		               Method_Gameplay_Craft_View_CraftRecipeListElement_CallElementClickedEvent__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,
		             Method_UnityEngine_Events_UnityEvent_CraftRecipeListElement_CraftRecipeListElementArgs__AddListener__
		            );
		  return;
		}
		*/

}
