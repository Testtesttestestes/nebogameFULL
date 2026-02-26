using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace JWTDecoder.Algorithms
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	public sealed class HMACSHA512Algorithm : IJwtAlgorithm
	{
		// Token: 0x060007BA RID: 1978 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x5B8F", Offset = "0x5B8F", VA = "0x5B8F", Slot = "4")]
		public byte[] Sign(byte[] key, byte[] bytesToSign)
		{
		/* --- GHIDRA: Sign ---
		undefined4 JWTDecoder_Algorithms_HMACSHA512Algorithm__Sign(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b860 == '\0') {
		    Mono_Security_ASN1__get_Item(&JWTDecoder_HashAlgorithm_TypeInfo);
		    DAT_ram_00a5b860 = '\x01';
		  }
		  local_8 = 0x2ffffffff;
		  local_c = JWTDecoder_HashAlgorithm_TypeInfo;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E3")]
		public string Name
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x5B90", Offset = "0x5B90", VA = "0x5B90", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x170000E4")]
		public bool IsAsymmetric
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x5B91", Offset = "0x5B91", VA = "0x5B91", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x5B92", Offset = "0x5B92", VA = "0x5B92")]
		public HMACSHA512Algorithm()
		{
		}
	}
}
