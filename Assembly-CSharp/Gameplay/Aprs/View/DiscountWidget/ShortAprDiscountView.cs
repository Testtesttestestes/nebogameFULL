using System;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Aprs.View.DiscountWidget
{
	// Token: 0x02000D5F RID: 3423
	[Token(Token = "0x2000D5F")]
	public class ShortAprDiscountView : MonoBehaviour, IAprDiscountWidget
	{
		// Token: 0x060053D3 RID: 21459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D3")]
		[Address(RVA = "0xA18F", Offset = "0xA18F", VA = "0xA18F", Slot = "4")]
		public void SetData(IAprDataDiscountProvider data)
		{
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D4")]
		[Address(RVA = "0xA190", Offset = "0xA190", VA = "0xA190")]
		public ShortAprDiscountView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Aprs_View_DiscountWidget_ShortAprDiscountView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a59428 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo);
		    DAT_ram_00a59428 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 ||
		         (Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 8,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance
		            (param1_01,Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04002D72 RID: 11634
		[Token(Token = "0x4002D72")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _view;
	}
}
