using System;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Counters;
using UnityEngine;

namespace UI.Elements.RightPanel
{
	// Token: 0x020001FA RID: 506
	[Token(Token = "0x20001FA")]
	public class TitleWithLevel : MonoBehaviour
	{
		// Token: 0x170001B6 RID: 438
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B6")]
		public string Title
		{
			[Token(Token = "0x6000D0F")]
			[Address(RVA = "0x1B52", Offset = "0x1B52", VA = "0x1B52")]
			set
			{
			}
		}

		// Token: 0x170001B7 RID: 439
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B7")]
		public uint Level
		{
			[Token(Token = "0x6000D10")]
			[Address(RVA = "0x1B53", Offset = "0x1B53", VA = "0x1B53")]
			set
			{
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D11")]
		[Address(RVA = "0x6006", Offset = "0x6006", VA = "0x6006")]
		public void Init(TitleWithLevelArgs args)
		{
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D12")]
		[Address(RVA = "0x6007", Offset = "0x6007", VA = "0x6007")]
		public TitleWithLevel()
		{
		}

		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private LevelCounter _levelCounter;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Title ---
		void UI_Elements_RightPanel_TitleWithLevel__set_Title
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 local_4;
		  
		  piVar2 = *(int **)(*(int *)(param1 + 0x14) + 0x10);
		  local_4 = param2;
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/


		/* --- GHIDRA: set_Level ---
		void UI_Elements_RightPanel_TitleWithLevel__set_Level(int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  *(int *)(param1 + 0x18) = param2;
		  if (*(int *)(param1 + 0x1c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x1c),0);
		    *(undefined4 *)(param1 + 0x1c) = 0;
		    param2 = *(int *)(param1 + 0x18);
		  }
		  if (param2 != 0) {
		    if (DAT_ram_00a5b861 == '\0') {
		      Mono_Security_ASN1__get_Item(&UI_AbstractBacktimeView__DisplayCurrentBackTime_d__13_TypeInfo);
		      DAT_ram_00a5b861 = '\x01';
		    }
		    param1_00 = unnamed_function_1417
		                          (UI_AbstractBacktimeView__DisplayCurrentBackTime_d__13_TypeInfo);
		    *(int *)(param1_00 + 0x10) = param1;
		    *(undefined4 *)(param1_00 + 8) = 0;
		    uVar1 = Utils_CoroutineSource__GetMono(param1_00,0);
		    *(undefined4 *)(param1 + 0x1c) = uVar1;
		  }
		  return;
		}
		*/

}
