using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.ProgressBars
{
	// Token: 0x02000220 RID: 544
	[Token(Token = "0x2000220")]
	public class ProgressBarWithText : ProgressBar
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C7")]
		public virtual string Text
		{
			[Token(Token = "0x6000D84")]
			[Address(RVA = "0x6067", Offset = "0x6067", VA = "0x6067", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D85")]
			[Address(RVA = "0x6068", Offset = "0x6068", VA = "0x6068", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D86")]
		[Address(RVA = "0x6069", Offset = "0x6069", VA = "0x6069")]
		public ProgressBarWithText()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_Elements_ProgressBars_ProgressBarWithText___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = **(int **)(param1 + 0x1c);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2c8) * 4))
		                    (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar2 + 0x2cc));
		  return uVar1;
		}
		*/

		}

		// Token: 0x040006B8 RID: 1720
		[Token(Token = "0x40006B8")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _text;
	}
}
