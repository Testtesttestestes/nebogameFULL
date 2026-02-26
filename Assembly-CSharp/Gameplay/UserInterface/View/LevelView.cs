using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003BD RID: 957
	[Token(Token = "0x20003BD")]
	public class LevelView : MonoBehaviour
	{
		// Token: 0x06001671 RID: 5745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001671")]
		[Address(RVA = "0x6832", Offset = "0x6832", VA = "0x6832")]
		public void SetExperienceProgress(float value)
		{
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x00005490 File Offset: 0x00003690
		// (set) Token: 0x06001673 RID: 5747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BE")]
		public bool IsPremiumExp
		{
			[Token(Token = "0x6001672")]
			[Address(RVA = "0x6833", Offset = "0x6833", VA = "0x6833")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001673")]
			[Address(RVA = "0x6834", Offset = "0x6834", VA = "0x6834")]
			set
			{
			}
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001674")]
		[Address(RVA = "0x6835", Offset = "0x6835", VA = "0x6835")]
		public void SetValue(uint value)
		{
		/* --- GHIDRA: SetValue ---
		void Gameplay_UserInterface_View_LevelView__SetValue
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = 0x10;
		  if (param3 == 0) {
		    iVar1 = 0x14;
		  }
		  func_ii_7050(*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + iVar1),0);
		  return;
		}
		*/

		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001675")]
		[Address(RVA = "0x6836", Offset = "0x6836", VA = "0x6836")]
		private void HandleIsPremiumExpChanged(bool from, bool to)
		{
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001676")]
		[Address(RVA = "0x6837", Offset = "0x6837", VA = "0x6837")]
		public LevelView()
		{
		}

		// Token: 0x04000BCA RID: 3018
		[Token(Token = "0x4000BCA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Sprite _premiumExp;

		// Token: 0x04000BCB RID: 3019
		[Token(Token = "0x4000BCB")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Sprite _defaultExp;

		// Token: 0x04000BCC RID: 3020
		[Token(Token = "0x4000BCC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _valueField;

		// Token: 0x04000BCD RID: 3021
		[Token(Token = "0x4000BCD")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _expIndicator;

		// Token: 0x04000BCE RID: 3022
		[Token(Token = "0x4000BCE")]
		[FieldOffset(Offset = "0x20")]
		private bool _isPremiumExp;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsPremiumExp ---
		void Gameplay_UserInterface_View_LevelView__get_IsPremiumExp
		               (int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (param2 != *(byte *)(param1 + 0x20)) {
		    *(char *)(param1 + 0x20) = (char)param2;
		    iVar1 = 0x10;
		    if (param2 == 0) {
		      iVar1 = 0x14;
		    }
		    func_ii_7050(*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + iVar1),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_IsPremiumExp ---
		void Gameplay_UserInterface_View_LevelView__set_IsPremiumExp
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  int local_4;
		  
		  local_4 = param2;
		  if (DAT_ram_00a5825c == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5825c = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x18),0);
		  if (param2 == 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,0,0);
		  }
		  else {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,1,0);
		    piVar2 = *(int **)(param1 + 0x18);
		    iVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		    if (iVar1 == 0) {
		      iVar1 = StringLiteral_5;
		    }
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar2,iVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  }
		  return;
		}
		*/

}
