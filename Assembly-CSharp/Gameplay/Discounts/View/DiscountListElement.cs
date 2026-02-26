using System;
using AssetContent;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.Discounts.View
{
	// Token: 0x02000895 RID: 2197
	[Token(Token = "0x2000895")]
	public class DiscountListElement : GenericListElement<DiscountListElement.DiscountListElementArgs>
	{
		// Token: 0x060033CA RID: 13258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033CA")]
		[Address(RVA = "0x8402", Offset = "0x8402", VA = "0x8402", Slot = "4")]
		protected override void OnInit(DiscountListElement.DiscountListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void Gameplay_Discounts_View_DiscountListElement__OnInit
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57cb1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_DiscountsScope_DiscountClickEventArgs_TypeInfo)
		    ;
		    DAT_ram_00a57cb1 = '\x01';
		  }
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x4c) + 8);
		  if (iVar1 != 0) {
		    param2_00 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param4 = *(undefined4 *)(param2 + 0xc);
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417
		                          (Core_Events_Scopes_DiscountsScope_DiscountClickEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		              (param1_00,param2_00,param3_00,param4,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = *(int *)(*(int *)(param2 + 0xc) + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060033CB RID: 13259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033CB")]
		[Address(RVA = "0x8403", Offset = "0x8403", VA = "0x8403")]
		private void ButtonClickedEventHandler(DiscountListElement.DiscountListElementArgs args)
		{
		/* --- GHIDRA: ButtonClickedEventHandler ---
		void Gameplay_Discounts_View_DiscountListElement__ButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57cb2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DiscountListElement_DiscountListElementArgs___ctor__
		              );
		    DAT_ram_00a57cb2 = '\x01';
		  }
		  UI_Elements_GenericList_GenericListArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_GenericListElement_DiscountListElement_DiscountListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060033CC RID: 13260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033CC")]
		[Address(RVA = "0x8404", Offset = "0x8404", VA = "0x8404")]
		public DiscountListElement()
		{
		}

		// Token: 0x04001C33 RID: 7219
		[Token(Token = "0x4001C33")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImage _bg;

		// Token: 0x04001C34 RID: 7220
		[Token(Token = "0x4001C34")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001C35 RID: 7221
		[Token(Token = "0x4001C35")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001C36 RID: 7222
		[Token(Token = "0x4001C36")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private BacktimeViewUGUI _backTime;

		// Token: 0x02000896 RID: 2198
		[Token(Token = "0x2000896")]
		public class DiscountListElementArgs : GenericListElementArgs
		{
			// Token: 0x060033CD RID: 13261 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60033CD")]
			[Address(RVA = "0x8405", Offset = "0x8405", VA = "0x8405")]
			public DiscountListElementArgs()
			{
			}

			// Token: 0x04001C37 RID: 7223
			[Token(Token = "0x4001C37")]
			[FieldOffset(Offset = "0xC")]
			public DiscountData DiscountData;
		}
	}
}
