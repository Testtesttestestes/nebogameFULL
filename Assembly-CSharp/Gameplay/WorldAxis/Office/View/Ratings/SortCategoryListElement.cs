using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UI.Elements;
using UI.Elements.GenericList;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x020002FE RID: 766
	[Token(Token = "0x20002FE")]
	public class SortCategoryListElement : SelectableListElement<SortCategoryListElement.SortCategoryListElementArgs>
	{
		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x00004908 File Offset: 0x00002B08
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B8")]
		public SortCategoryListElement.SortOrder Order
		{
			[Token(Token = "0x6001202")]
			[Address(RVA = "0x63FD", Offset = "0x63FD", VA = "0x63FD")]
			[CompilerGenerated]
			get
			{
				return SortCategoryListElement.SortOrder.DEFAULT;
			}
			[Token(Token = "0x6001203")]
			[Address(RVA = "0x63FE", Offset = "0x63FE", VA = "0x63FE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001204")]
		[Address(RVA = "0x63FF", Offset = "0x63FF", VA = "0x63FF")]
		public void SetOrder(SortCategoryListElement.SortOrder order)
		{
		/* --- GHIDRA: SetOrder ---
		uint Gameplay_WorldAxis_Office_View_Ratings_SortCategoryListElement__SetOrder
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int iVar2;
		  byte bVar3;
		  byte local_1;
		  
		  if (DAT_ram_00a58ba6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_View_Ratings_SortCategoryListElement_SortOrder_var);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_View_Ratings_SortCategoryListElement_SortOrder_TypeInfo);
		    DAT_ram_00a58ba6 = '\x01';
		  }
		  uVar1 = Gameplay_WorldAxis_Office_View_Ratings_SortCategoryListElement_SortOrder_var;
		  bVar3 = *(char *)(param1 + 0x2c) + 1;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar1 = func_ii_2734(uVar1,0);
		  local_1 = bVar3;
		  param2_00 = func_ii_1081(Gameplay_WorldAxis_Office_View_Ratings_SortCategoryListElement_SortOrder_TypeInfo
		                           ,&local_1);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  iVar2 = System_Enum__InternalGetNames(uVar1,param2_00,0);
		  if (iVar2 == 0) {
		    *(undefined1 *)(param1 + 0x2c) = 0;
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x28),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x28),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		  }
		  else {
		    Gameplay_WorldAxis_Office_View_Ratings_SortCategoryListElement__set_Order
		              (param1,(uint)bVar3,param1);
		  }
		  return (uint)*(byte *)(param1 + 0x2c);
		}
		*/

		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x6001205")]
		[Address(RVA = "0x6400", Offset = "0x6400", VA = "0x6400")]
		public SortCategoryListElement.SortOrder SetNextSortOrder()
		{
		/* --- GHIDRA: SetNextSortOrder ---
		void Gameplay_WorldAxis_Office_View_Ratings_SortCategoryListElement__SetNextSortOrder
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ba7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_SortCategoryListElement_SortCategoryListElementArgs__get_args__
		              );
		    DAT_ram_00a58ba7 = '\x01';
		  }
		  UI_Elements_CommonElements___ctor
		            (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(*(int *)(param1 + 0x18) + 0x1c),
		             *(undefined4 *)(*(int *)(param1 + 0x18) + 0x20),0);
		  return;
		}
		*/

			return SortCategoryListElement.SortOrder.DEFAULT;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001206")]
		[Address(RVA = "0x6401", Offset = "0x6401", VA = "0x6401", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001207")]
		[Address(RVA = "0x6402", Offset = "0x6402", VA = "0x6402", Slot = "10")]
		protected override void CallElementClickedEvent(SortCategoryListElement.SortCategoryListElementArgs args)
		{
		/* --- GHIDRA: CallElementClickedEvent ---
		void Gameplay_WorldAxis_Office_View_Ratings_SortCategoryListElement__CallElementClickedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ba8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_SortCategoryListElement_SortCategoryListElementArgs___ctor__
		              );
		    DAT_ram_00a58ba8 = '\x01';
		  }
		  UI_Elements_GenericList_SelectableListElementArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElement_SortCategoryListElement_SortCategoryListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001208")]
		[Address(RVA = "0x6403", Offset = "0x6403", VA = "0x6403")]
		public SortCategoryListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_View_Ratings_SortCategoryListElement___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ba9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElementArgs_SortCategoryListElement___ctor__
		              );
		    DAT_ram_00a58ba9 = '\x01';
		  }
		  UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElementArgs_SortCategoryListElement___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0400096C RID: 2412
		[Token(Token = "0x400096C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CommonElements.IconLabel _iconLabel;

		// Token: 0x0400096D RID: 2413
		[Token(Token = "0x400096D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _orderIcon;

		// Token: 0x020002FF RID: 767
		[Token(Token = "0x20002FF")]
		public enum SortOrder : byte
		{
			// Token: 0x04000970 RID: 2416
			[Token(Token = "0x4000970")]
			DEFAULT,
			// Token: 0x04000971 RID: 2417
			[Token(Token = "0x4000971")]
			ASCENDING,
			// Token: 0x04000972 RID: 2418
			[Token(Token = "0x4000972")]
			DESCENDING
		}

		// Token: 0x02000300 RID: 768
		[Token(Token = "0x2000300")]
		public class SortCategoryListElementArgs : SelectableListElementArgs<SortCategoryListElement>
		{
			// Token: 0x06001209 RID: 4617 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001209")]
			[Address(RVA = "0x6404", Offset = "0x6404", VA = "0x6404")]
			public SortCategoryListElementArgs()
			{
			}

			// Token: 0x04000973 RID: 2419
			[Token(Token = "0x4000973")]
			[FieldOffset(Offset = "0x1C")]
			public string IconAssetId;

			// Token: 0x04000974 RID: 2420
			[Token(Token = "0x4000974")]
			[FieldOffset(Offset = "0x20")]
			public string Title;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Order ---
		void Gameplay_WorldAxis_Office_View_Ratings_SortCategoryListElement__set_Order
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  *(char *)(param1 + 0x2c) = (char)param2;
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  if (param2 == 1) {
		    uVar1 = UnityEngine_UI_Graphic__get_depth(*(undefined4 *)(param1 + 0x28),0);
		    local_4 = 0x3f800000;
		    local_20 = 0x3f800000;
		    local_c = 0xbf8000003f800000;
		    local_28 = 0xbf8000003f800000;
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar1,&local_28,0);
		  }
		  else if (param2 == 2) {
		    uVar1 = UnityEngine_UI_Graphic__get_depth(*(undefined4 *)(param1 + 0x28),0);
		    if (DAT_ram_00a6501f == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		      DAT_ram_00a6501f = '\x01';
		    }
		    local_10 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		    local_18 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar1,&local_18,0);
		  }
		  else {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x28),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		  }
		  return;
		}
		*/

}
