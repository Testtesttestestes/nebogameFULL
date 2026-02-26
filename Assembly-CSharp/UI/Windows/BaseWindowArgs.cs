using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UI.Windows
{
	// Token: 0x0200026C RID: 620
	[Token(Token = "0x200026C")]
	public abstract class BaseWindowArgs : IDisposable
	{
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x00004380 File Offset: 0x00002580
		// (set) Token: 0x06000EEE RID: 3822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020B")]
		public LayerId Layer
		{
			[Token(Token = "0x6000EED")]
			[Address(RVA = "0x6141", Offset = "0x6141", VA = "0x6141")]
			[CompilerGenerated]
			get
			{
				return LayerId.None;
			}
			[Token(Token = "0x6000EEE")]
			[Address(RVA = "0x6142", Offset = "0x6142", VA = "0x6142")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00004398 File Offset: 0x00002598
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020C")]
		public bool IsResourceBarInteractive
		{
			[Token(Token = "0x6000EEF")]
			[Address(RVA = "0x6143", Offset = "0x6143", VA = "0x6143")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EF0")]
			[Address(RVA = "0x6144", Offset = "0x6144", VA = "0x6144")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x000043B0 File Offset: 0x000025B0
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020D")]
		public WindowOpenReasonSource Source
		{
			[Token(Token = "0x6000EF1")]
			[Address(RVA = "0x6145", Offset = "0x6145", VA = "0x6145")]
			[CompilerGenerated]
			get
			{
				return WindowOpenReasonSource.DefaultSource;
			}
			[Token(Token = "0x6000EF2")]
			[Address(RVA = "0x6146", Offset = "0x6146", VA = "0x6146")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700020E")]
		public Dictionary<string, object> Properties
		{
			[Token(Token = "0x6000EF3")]
			[Address(RVA = "0x6147", Offset = "0x6147", VA = "0x6147")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x6148", Offset = "0x6148", VA = "0x6148", Slot = "5")]
		public virtual void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void UI_Windows_BaseWindowArgs__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a639d9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a639d9 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0xc) = 1;
		  *(undefined4 *)(param1 + 8) = 1;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x6149", Offset = "0x6149", VA = "0x6149")]
		protected BaseWindowArgs()
		{
		}
	}
}
