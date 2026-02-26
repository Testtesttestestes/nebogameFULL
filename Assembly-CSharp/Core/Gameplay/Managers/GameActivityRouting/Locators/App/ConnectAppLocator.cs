using System;
using Core.Application;
using Core.Rounting;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.App
{
	// Token: 0x020011EE RID: 4590
	[Token(Token = "0x20011EE")]
	public class ConnectAppLocator : ILocator, IDisposable
	{
		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06006CFF RID: 27903 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700162F")]
		public string[] Schemes
		{
			[Token(Token = "0x6006CFF")]
			[Address(RVA = "0xB7E8", Offset = "0xB7E8", VA = "0xB7E8", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06006D00 RID: 27904 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001630")]
		public string Host
		{
			[Token(Token = "0x6006D00")]
			[Address(RVA = "0xB7E9", Offset = "0xB7E9", VA = "0xB7E9", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006D01 RID: 27905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D01")]
		[Address(RVA = "0xB7EA", Offset = "0xB7EA", VA = "0xB7EA", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06006D02 RID: 27906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D02")]
		[Address(RVA = "0xB7EB", Offset = "0xB7EB", VA = "0xB7EB")]
		public ConnectAppLocator(IApp app)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_Locators_App_ConnectAppLocator___ctor
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  uVar1 = unnamed_function_2232(&System_NotImplementedException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  UnityEngine_InputSystem_InputActionRebindingExtensions__ApplyBindingOverride(uVar1,0);
		  param2_00 = unnamed_function_2232
		                        (&
		                         Method_Core_Gameplay_Managers_GameActivityRouting_Locators_App_ConnectAppLocator_TryExecute__
		                        );
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006D03 RID: 27907 RVA: 0x00014100 File Offset: 0x00012300
		[Token(Token = "0x6006D03")]
		[Address(RVA = "0xB7EC", Offset = "0xB7EC", VA = "0xB7EC", Slot = "6")]
		public bool TryExecute(Uri uri)
		{
		/* --- GHIDRA: TryExecute ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_Locators_App_ConnectAppLocator__TryExecute
		          (undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a73b == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_14086);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1253);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    DAT_ram_00a5a73b = '\x01';
		  }
		  if (DAT_ram_00a5a739 == '\0') {
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27696);
		    DAT_ram_00a5a739 = '\x01';
		  }
		  param2_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		  *(undefined4 *)(param2_00 + 0x10) = StringLiteral_27696;
		  uVar1 = UnityEngine_Assertions_Assert__IsFalse(StringLiteral_1236,param2_00,0);
		  if (DAT_ram_00a5a73a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_21896);
		    DAT_ram_00a5a73a = '\x01';
		  }
		  uVar1 = System_Int32__ToString(StringLiteral_14086,uVar1,StringLiteral_1253,StringLiteral_21896,0)
		  ;
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006D04 RID: 27908 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006D04")]
		[Address(RVA = "0xB7ED", Offset = "0xB7ED", VA = "0xB7ED", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_Locators_App_ConnectAppLocator__ToString
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a73c == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_7306);
		    DAT_ram_00a5a73c = '\x01';
		  }
		  return StringLiteral_7306;
		}
		*/

			return null;
		}

		// Token: 0x0400390D RID: 14605
		[Token(Token = "0x400390D")]
		[FieldOffset(Offset = "0x8")]
		private IApp _app;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Schemes ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_Locators_App_ConnectAppLocator__get_Schemes
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a73a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_21896);
		    DAT_ram_00a5a73a = '\x01';
		  }
		  return StringLiteral_21896;
		}
		*/

}
