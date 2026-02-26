using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip
{
	// Token: 0x0200013C RID: 316
	[Token(Token = "0x200013C")]
	public abstract class BaseToolTipData : IDisposable
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x000037B0 File Offset: 0x000019B0
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000142")]
		public Vector2 MaxSize
		{
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x5CF0", Offset = "0x5CF0", VA = "0x5CF0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000982")]
			[Address(RVA = "0x5CF1", Offset = "0x5CF1", VA = "0x5CF1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x000037C8 File Offset: 0x000019C8
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000143")]
		public Vector2 MinSize
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x5CF2", Offset = "0x5CF2", VA = "0x5CF2")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x5CF3", Offset = "0x5CF3", VA = "0x5CF3")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000985")]
		[Address(RVA = "0x5CF4", Offset = "0x5CF4", VA = "0x5CF4")]
		public BaseToolTipData([Optional] string id)
		{
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000986")]
		[Address(RVA = "0x5CF5", Offset = "0x5CF5", VA = "0x5CF5", Slot = "5")]
		public virtual void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void UI_ToolTip_BaseToolTipData__Dispose(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x10) = 0;
		  *(undefined4 *)(param1 + 0x2c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06000987 RID: 2439
		[Token(Token = "0x6000987")]
		public abstract Transform CreateContent(Transform parent);

		// Token: 0x0400038B RID: 907
		[Token(Token = "0x400038B")]
		public const string DEFAULT_ID = "Prefabs/UI/ToolTip/TextToolTipView";

		// Token: 0x0400038C RID: 908
		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly string Id;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_MinSize ---
		void UI_ToolTip_BaseToolTipData__set_MinSize(int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5b8d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12541);
		    DAT_ram_00a5b8d7 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x14) = 0x7fc000007fc00000;
		  *(undefined8 *)(param1 + 0xc) = 0x7fc000007fc00000;
		  if (param2 == 0) {
		    param2 = StringLiteral_12541;
		  }
		  *(int *)(param1 + 8) = param2;
		  return;
		}
		*/

}
