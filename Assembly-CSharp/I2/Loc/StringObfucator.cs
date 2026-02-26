using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x020013B7 RID: 5047
	[Token(Token = "0x20013B7")]
	public class StringObfucator
	{
		// Token: 0x060077F5 RID: 30709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077F5")]
		[Address(RVA = "0x35FF", Offset = "0x35FF", VA = "0x35FF")]
		public static string Encode(string NormalString)
		{
		/* --- GHIDRA: Encode ---
		undefined4
		I2_Loc_StringObfucator__Encode
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          )
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a5971a == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_PersistentStorage_TypeInfo);
		    DAT_ram_00a5971a = '\x01';
		  }
		  piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  if (piVar2 == (int *)0x0) {
		    uVar1 = unnamed_function_1417(I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    **(undefined4 **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c) = uVar1;
		    piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x110) * 4))
		                    (piVar2,param1,param2,param3,param4,*(undefined4 *)(*piVar2 + 0x114));
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060077F6 RID: 30710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077F6")]
		[Address(RVA = "0xC14C", Offset = "0xC14C", VA = "0xC14C")]
		public static string Decode(string ObfucatedString)
		{
		/* --- GHIDRA: Decode ---
		undefined4 I2_Loc_StringObfucator__Decode(undefined4 param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a54e30 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Convert_TypeInfo);
		    DAT_ram_00a54e30 = '\x01';
		  }
		  piVar1 = (int *)func_ii_5618(0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x158) * 4))
		                    (piVar1,param1,*(undefined4 *)(*piVar1 + 0x15c));
		  if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Convert_TypeInfo);
		  }
		  uVar2 = System_Text_StringBuilder__Append(uVar2,0);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x060077F7 RID: 30711 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077F7")]
		[Address(RVA = "0xC14D", Offset = "0xC14D", VA = "0xC14D")]
		private static string ToBase64(string regularString)
		{
		/* --- GHIDRA: ToBase64 ---
		undefined4 I2_Loc_StringObfucator__ToBase64(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a54e31 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Convert_TypeInfo);
		    DAT_ram_00a54e31 = '\x01';
		  }
		  if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Convert_TypeInfo);
		  }
		  iVar1 = System_Xml_XmlConvert__FromBinHexString(param1,0);
		  piVar2 = (int *)func_ii_5618(0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x1f0) * 4))
		                    (piVar2,iVar1,0,*(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(*piVar2 + 500));
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x060077F8 RID: 30712 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077F8")]
		[Address(RVA = "0xC14E", Offset = "0xC14E", VA = "0xC14E")]
		private static string FromBase64(string base64string)
		{
			return null;
		}

		// Token: 0x060077F9 RID: 30713 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077F9")]
		[Address(RVA = "0x18EF", Offset = "0x18EF", VA = "0x18EF")]
		private static string XoREncode(string NormalString)
		{
		/* --- GHIDRA: XoREncode ---
		int I2_Loc_StringObfucator__XoREncode(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a65e9f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_char___);
		    Mono_Security_ASN1__get_Item(&char___TypeInfo);
		    DAT_ram_00a65e9f = '\x01';
		  }
		  iVar1 = Method_System_Array_Empty_char___;
		  if (*(int *)(param1 + 8) == 0) {
		    iVar2 = *(int *)(Method_System_Array_Empty_char___ + 0x1c);
		    if (iVar2 == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_char___);
		      iVar2 = *(int *)(iVar1 + 0x1c);
		    }
		    iVar2 = *(int *)(iVar2 + 8);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    if (*(int *)(iVar2 + 0x74) == 0) {
		      func_ii_306000(iVar2);
		    }
		    iVar1 = *(int *)(*(int *)(iVar1 + 0x1c) + 8);
		    if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		      iVar1 = func_ii_1079(iVar1);
		    }
		    return **(undefined4 **)(iVar1 + 0x5c);
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(char___TypeInfo,*(int *)(param1 + 8));
		  System_Buffer__memcpy1(iVar1 + 0x10,param1 + 0xc,*(int *)(param1 + 8) << 1,0);
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060077FA RID: 30714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077FA")]
		[Address(RVA = "0xC14F", Offset = "0xC14F", VA = "0xC14F")]
		public StringObfucator()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_StringObfucator___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54e33 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_StringObfucator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28782);
		    DAT_ram_00a54e33 = '\x01';
		  }
		  uVar1 = I2_Loc_StringObfucator__XoREncode(StringLiteral_28782,0);
		  **(undefined4 **)(I2_Loc_StringObfucator_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04003EE6 RID: 16102
		[Token(Token = "0x4003EE6")]
		[FieldOffset(Offset = "0x0")]
		public static char[] StringObfuscatorPassword;
	}
}
