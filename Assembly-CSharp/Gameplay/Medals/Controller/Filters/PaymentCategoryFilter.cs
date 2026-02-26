using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Medals.Controller.Filters
{
	// Token: 0x02000615 RID: 1557
	[Token(Token = "0x2000615")]
	public class PaymentCategoryFilter : IMedalFilter
	{
		// Token: 0x060025CD RID: 9677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025CD")]
		[Address(RVA = "0x770B", Offset = "0x770B", VA = "0x770B")]
		public PaymentCategoryFilter()
		{
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700071A")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60025CE")]
			[Address(RVA = "0x770C", Offset = "0x770C", VA = "0x770C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60025CF")]
			[Address(RVA = "0x770D", Offset = "0x770D", VA = "0x770D", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D0")]
		[Address(RVA = "0x770E", Offset = "0x770E", VA = "0x770E")]
		public void UpdateLastMedalToShow(MedalData medalData)
		{
		/* --- GHIDRA: UpdateLastMedalToShow ---
		uint Gameplay_Medals_Controller_Filters_PaymentCategoryFilter__UpdateLastMedalToShow
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  
		  uVar1 = 1;
		  if (((*(char *)(*(int *)(param1 + 0x10) + 0x10) != '\0') && (*(int *)(param2 + 0x10) == 0)) &&
		     (*(int *)(*(int *)(*(int *)(param2 + 8) + 0x14) + 0xc) == *(int *)(param1 + 8))) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Int32Enum__object___Dispose
		                      (param2,0);
		    uVar1 = (uint)(uVar1 <= *(uint *)(param1 + 0xc));
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x00007398 File Offset: 0x00005598
		[Token(Token = "0x60025D1")]
		[Address(RVA = "0x770F", Offset = "0x770F", VA = "0x770F", Slot = "6")]
		public bool Filter(MedalData medalData)
		{
		/* --- GHIDRA: Filter ---
		void Gameplay_Medals_Controller_Filters_PaymentCategoryFilter__Filter
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57de1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_View_MarketArtukulInfoPopupWindow_MarketButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57de1 = '\x01';
		  }
		  Gameplay_Inventory_View_Info_ArtikulInfoPopupWindow__Awake(param1,param2,0);
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x58) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Market_View_MarketArtukulInfoPopupWindow_MarketButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x040014A0 RID: 5280
		[Token(Token = "0x40014A0")]
		[FieldOffset(Offset = "0x8")]
		private uint _categoryId;

		// Token: 0x040014A1 RID: 5281
		[Token(Token = "0x40014A1")]
		[FieldOffset(Offset = "0xC")]
		private uint _sortOrder;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		void Gameplay_Medals_Controller_Filters_PaymentCategoryFilter__set_FilterInfo
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  *(undefined4 *)(param1 + 8) = *(undefined4 *)(*(int *)(*(int *)(param2 + 8) + 0x14) + 0xc);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Int32Enum__object___Dispose
		                    (param2,0);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  return;
		}
		*/

}
