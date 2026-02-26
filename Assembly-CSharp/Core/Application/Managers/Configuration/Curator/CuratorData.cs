using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Application.Managers.Configuration.Curator
{
	// Token: 0x02001270 RID: 4720
	[Token(Token = "0x2001270")]
	[Serializable]
	public class CuratorData
	{
		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06007008 RID: 28680 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007009 RID: 28681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016DD")]
		public string ClientIp
		{
			[Token(Token = "0x6007008")]
			[Address(RVA = "0xBA55", Offset = "0xBA55", VA = "0xBA55")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007009")]
			[Address(RVA = "0xBA56", Offset = "0xBA56", VA = "0xBA56")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x0600700A RID: 28682 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600700B RID: 28683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016DE")]
		public string Country
		{
			[Token(Token = "0x600700A")]
			[Address(RVA = "0xBA57", Offset = "0xBA57", VA = "0xBA57")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600700B")]
			[Address(RVA = "0xBA58", Offset = "0xBA58", VA = "0xBA58")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x0600700C RID: 28684 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600700D RID: 28685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016DF")]
		public string Server
		{
			[Token(Token = "0x600700C")]
			[Address(RVA = "0xBA59", Offset = "0xBA59", VA = "0xBA59")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600700D")]
			[Address(RVA = "0xBA5A", Offset = "0xBA5A", VA = "0xBA5A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600700E RID: 28686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600700E")]
		[Address(RVA = "0xBA5B", Offset = "0xBA5B", VA = "0xBA5B")]
		public CuratorData(Uri endpoint)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Application_Managers_Configuration_Curator_CuratorData___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a887 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_25649);
		    DAT_ram_00a5a887 = '\x01';
		  }
		  uVar1 = StringLiteral_25649;
		  *(undefined4 *)(param1 + 0x14) = StringLiteral_25649;
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  *(undefined4 *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = param2;
		  *(undefined4 *)(param1 + 0x10) = param5;
		  *(undefined4 *)(param1 + 0xc) = param4;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Application_Managers_Configuration_Curator_CuratorData___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a887 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_25649);
		    DAT_ram_00a5a887 = '\x01';
		  }
		  uVar1 = StringLiteral_25649;
		  *(undefined4 *)(param1 + 0x14) = StringLiteral_25649;
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  *(undefined4 *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = param2;
		  *(undefined4 *)(param1 + 0x10) = param5;
		  *(undefined4 *)(param1 + 0xc) = param4;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Application_Managers_Configuration_Curator_CuratorData___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a887 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_25649);
		    DAT_ram_00a5a887 = '\x01';
		  }
		  uVar1 = StringLiteral_25649;
		  *(undefined4 *)(param1 + 0x14) = StringLiteral_25649;
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  *(undefined4 *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = param2;
		  *(undefined4 *)(param1 + 0x10) = param5;
		  *(undefined4 *)(param1 + 0xc) = param4;
		  return;
		}
		*/

		}

		// Token: 0x0600700F RID: 28687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600700F")]
		[Address(RVA = "0xBA5C", Offset = "0xBA5C", VA = "0xBA5C")]
		public CuratorData(Uri endpoint, string server)
		{
		}

		// Token: 0x06007010 RID: 28688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007010")]
		[Address(RVA = "0xBA5D", Offset = "0xBA5D", VA = "0xBA5D")]
		public CuratorData(Uri endpoint, string server, string clientIp, string country)
		{
		}

		// Token: 0x06007011 RID: 28689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007011")]
		[Address(RVA = "0xBA5E", Offset = "0xBA5E", VA = "0xBA5E")]
		public void SetServer(string v)
		{
		/* --- GHIDRA: SetServer ---
		undefined4
		Core_Application_Managers_Configuration_Curator_CuratorData__SetServer(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a888 == '\0') {
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1243);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7308);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5997);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5485);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28690);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1267);
		    DAT_ram_00a5a888 = '\x01';
		  }
		  param1_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,8);
		  *(undefined4 *)(param1_00 + 0x10) = StringLiteral_5997;
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28690,StringLiteral_7308,*(undefined4 *)(param1 + 8),0);
		  *(undefined4 *)(param1_00 + 0x14) = uVar1;
		  *(undefined4 *)(param1_00 + 0x18) = StringLiteral_5485;
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param1 + 0xc);
		  *(undefined4 *)(param1_00 + 0x20) = StringLiteral_1243;
		  *(undefined4 *)(param1_00 + 0x24) = *(undefined4 *)(param1 + 0x10);
		  *(undefined4 *)(param1_00 + 0x28) = StringLiteral_1267;
		  *(undefined4 *)(param1_00 + 0x2c) = *(undefined4 *)(param1 + 0x14);
		  uVar1 = System_Single__ToString(param1_00,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06007012 RID: 28690 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007012")]
		[Address(RVA = "0xBA5F", Offset = "0xBA5F", VA = "0xBA5F", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04003A75 RID: 14965
		[Token(Token = "0x4003A75")]
		[FieldOffset(Offset = "0x8")]
		public readonly Uri Endpoint;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Server ---
		void Core_Application_Managers_Configuration_Curator_CuratorData__set_Server
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a887 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_25649);
		    DAT_ram_00a5a887 = '\x01';
		  }
		  uVar1 = StringLiteral_25649;
		  *(undefined4 *)(param1 + 0x14) = StringLiteral_25649;
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  *(undefined4 *)(param1 + 8) = param2;
		  return;
		}
		*/

}
