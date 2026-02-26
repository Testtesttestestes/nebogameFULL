using System;
using Gameplay.Collections.Model;
using Gameplay.Inventory.View;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Collections.View
{
	// Token: 0x020009D0 RID: 2512
	[Token(Token = "0x20009D0")]
	public class CollectionArtikulView : ArtikulView
	{
		// Token: 0x06003C23 RID: 15395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C23")]
		[Address(RVA = "0x8AF2", Offset = "0x8AF2", VA = "0x8AF2")]
		public void Init(CollectionsModel.ArtikulMaterial material, bool sameUser)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Collections_View_CollectionArtikulView__Init
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  ushort local_4;
		  ushort local_2;
		  
		  if (DAT_ram_00a57ea2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Info_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_MarketArtukulInfoPopupWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12641);
		    DAT_ram_00a57ea2 = '\x01';
		  }
		  local_2 = 0;
		  iVar2 = *(int *)(param1 + 0x50);
		  if (*(char *)(iVar2 + 0x14) != '\0') {
		    if (DAT_ram_00a57ec6 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		      DAT_ram_00a57ec6 = '\x01';
		    }
		    local_4 = 0;
		    System_Data_SqlTypes_SqlByte__ToSqlInt64
		              (&local_4,(uint)(*(uint *)(iVar2 + 0xc) <= *(uint *)(iVar2 + 8)),
		               Method_System_Nullable_bool___ctor__);
		    local_2 = local_4;
		    iVar2 = UnityEngine_UI_RawImage__set_texture(&local_2,Method_System_Nullable_bool__get_Value__);
		    if (iVar2 == 0) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		      iVar2 = unnamed_function_1417
		                        (
		                        Gameplay_Inventory_View_Info_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs_TypeInfo
		                        );
		      Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar2,0);
		      *(int *)(iVar2 + 0x18) = param1;
		      Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                (uVar1,StringLiteral_12641,iVar2,
		                 Method_UI_Windows_PopupController_Show_MarketArtukulInfoPopupWindow___);
		      return;
		    }
		  }
		  Gameplay_Inventory_View_ArtikulView__set_Interactable(param1,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C24")]
		[Address(RVA = "0x8AF3", Offset = "0x8AF3", VA = "0x8AF3", Slot = "23")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Collections_View_CollectionArtikulView__OnPointerClick
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Inventory_View_CraftSlotArtikulView__Dispose(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C25")]
		[Address(RVA = "0x8AF4", Offset = "0x8AF4", VA = "0x8AF4")]
		public CollectionArtikulView()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Collections_View_CollectionArtikulView___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57ea3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_MedalView___);
		    DAT_ram_00a57ea3 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x1c);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_MedalView___);
		    *(int *)(param1 + 0x1c) = iVar1;
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x0400213A RID: 8506
		[Token(Token = "0x400213A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected LoaderValueRowView _valueRow;

		// Token: 0x0400213B RID: 8507
		[Token(Token = "0x400213B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GameObject _marketIndicator;

		// Token: 0x0400213C RID: 8508
		[Token(Token = "0x400213C")]
		[FieldOffset(Offset = "0x50")]
		private CollectionsModel.ArtikulMaterial _artikulMaterial;
	}
}
