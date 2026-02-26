using System;
using AssetContent;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Parts
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	public class MedalViewWhitTitle : MedalView
	{
		// Token: 0x060009C3 RID: 2499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x5D2B", Offset = "0x5D2B", VA = "0x5D2B", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_Parts_MedalViewWhitTitle__HandleDataChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = Core_Extensions_Dict_MedalDicExt__GetMaxRank(param2,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66
		            (*(undefined4 *)(param1 + 0x60),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x5D2C", Offset = "0x5D2C", VA = "0x5D2C")]
		public void SetMedalRankDic(MedalRanks medalRanksDic)
		{
		/* --- GHIDRA: SetMedalRankDic ---
		void UI_ToolTip_Implementations_View_Parts_MedalViewWhitTitle__SetMedalRankDic
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x58);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x58),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x5D2D", Offset = "0x5D2D", VA = "0x5D2D")]
		public void SetTitle(string value)
		{
		/* --- GHIDRA: SetTitle ---
		void UI_ToolTip_Implementations_View_Parts_MedalViewWhitTitle__SetTitle
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x5c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x5c),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x5D2E", Offset = "0x5D2E", VA = "0x5D2E")]
		public void SetSubTitle(string value)
		{
		/* --- GHIDRA: SetSubTitle ---
		void UI_ToolTip_Implementations_View_Parts_MedalViewWhitTitle__SetSubTitle
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Medals_View_MedalView__HandleDataChanged(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x5D2F", Offset = "0x5D2F", VA = "0x5D2F")]
		public MedalViewWhitTitle()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_Parts_MedalViewWhitTitle___ctor
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (param3 == 0) {
		    if (DAT_ram_00a59977 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_Sprite___);
		      DAT_ram_00a59977 = '\x01';
		    }
		    uVar2 = *(undefined4 *)(param1 + 0x10);
		    iVar3 = *(int *)(param1 + 0x14);
		    if ((param2 + -1 < 0) || (*(int *)(iVar3 + 0xc) < param2)) {
		      uVar1 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                        (iVar3,Method_System_Linq_Enumerable_Last_Sprite___);
		    }
		    else {
		      uVar1 = *(undefined4 *)(iVar3 + (param2 + -1) * 4 + 0x10);
		    }
		    func_ii_7050(uVar2,uVar1,0);
		    return;
		  }
		  if (param2 < 4) {
		    if (DAT_ram_00a59977 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_Sprite___);
		      DAT_ram_00a59977 = '\x01';
		    }
		    uVar2 = *(undefined4 *)(param1 + 0x10);
		    iVar3 = *(int *)(param1 + 0x14);
		    if ((param2 + -1 < 0) || (*(int *)(iVar3 + 0xc) < param2)) {
		      uVar1 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                        (iVar3,Method_System_Linq_Enumerable_Last_Sprite___);
		    }
		    else {
		      uVar1 = *(undefined4 *)(iVar3 + (param2 + -1) * 4 + 0x10);
		    }
		    func_ii_7050(uVar2,uVar1,0);
		    return;
		  }
		  func_ii_7050(*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private MedalView _medalView;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TextMeshProUGUI _subtitle;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameRawImage _background;
	}
}
