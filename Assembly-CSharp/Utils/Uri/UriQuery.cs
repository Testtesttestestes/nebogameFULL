using System;
using System.Text;
using Il2CppDummyDll;

namespace Utils.Uri
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	public class UriQuery
	{
		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x5772", Offset = "0x5772", VA = "0x5772")]
		public UriQuery()
		{
		/* --- GHIDRA: .ctor ---
		void Utils_Uri_UriQuery___ctor(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = func_ii_4075(*(undefined4 *)(param1 + 8),0);
		  if (0 < iVar1) {
		    func_ii_3135(*(undefined4 *)(param1 + 8),0x26,0);
		  }
		  func_ii_2010(*(undefined4 *)(param1 + 8),param2,0);
		  func_ii_3135(*(undefined4 *)(param1 + 8),0x3d,0);
		  func_ii_2010(*(undefined4 *)(param1 + 8),param3,0);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Utils_Uri_UriQuery___ctor(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = func_ii_4075(*(undefined4 *)(param1 + 8),0);
		  if (0 < iVar1) {
		    func_ii_3135(*(undefined4 *)(param1 + 8),0x26,0);
		  }
		  func_ii_2010(*(undefined4 *)(param1 + 8),param2,0);
		  func_ii_3135(*(undefined4 *)(param1 + 8),0x3d,0);
		  func_ii_2010(*(undefined4 *)(param1 + 8),param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x5773", Offset = "0x5773", VA = "0x5773")]
		public UriQuery(Uri uri)
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x5774", Offset = "0x5774", VA = "0x5774")]
		public void Add(string name, string value)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x5775", Offset = "0x5775", VA = "0x5775", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		undefined4 Utils_Uri_UriQuery__ToString(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a6282d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    DAT_ram_00a6282d = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  uVar1 = unnamed_function_1417(System_Uri_TypeInfo);
		  UI_Windows_ClosableBaseWindow_object___HandleCloseButton(uVar1,param1,0);
		  uVar1 = System_Uri__TryCreate(uVar1,0x20,2,0);
		  iVar2 = System_Net_WebConnection__ReadLine(uVar1,0x26,0,0);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      uVar1 = *(undefined4 *)(iVar2 + iVar4 * 4 + 0x10);
		      iVar3 = func_ii_4769(uVar1,0);
		      if (iVar3 == 0) {
		        iVar3 = System_Net_WebConnection__ReadLine(uVar1,0x3d,0,0);
		        System_Reflection_FieldInfo__get_IsStatic
		                  (param1_00,*(undefined4 *)(iVar3 + 0x10),*(undefined4 *)(iVar3 + 0x14),
		                   Method_System_Collections_Generic_Dictionary_string__string__Add__);
		      }
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar2 + 0xc));
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		public const char SEPARATOR = '&';

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		public const char EQUAL = '=';

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x8")]
		private readonly StringBuilder _builder;
	}
}
